using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageDownsizerParallel
{
    class DownscalingService
    {
        private Bitmap Image;
        int stride;

        public DownscalingService(Bitmap Image)
        {
            this.Image = Image;
        }

        public byte[] ConvertImageToArray()
        {
            if (Image == null)
            {
                throw new ArgumentNullException("image");
            }


            BitmapData bmpData = Image.LockBits(new Rectangle(0, 0, Image.Width, Image.Height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);

            stride = bmpData.Stride;
            int byteCount = bmpData.Stride * Image.Height;


            byte[] byteArray = new byte[byteCount];
            System.Runtime.InteropServices.Marshal.Copy(bmpData.Scan0, byteArray, 0, byteCount);

            Image.UnlockBits(bmpData);

            return byteArray;
        }

        public Bitmap ConvertArrayToBitmap(byte[] downsizedImageBytes, double scale)
        {

            int newWidth = (int)Math.Round(Image.Width * scale);
            int newHeight = (int)Math.Round(Image.Height * scale);
            Bitmap downsizedBitmap = new Bitmap(newWidth, newHeight, PixelFormat.Format24bppRgb);
            BitmapData bmpData = downsizedBitmap.LockBits(new Rectangle(0, 0, newWidth, newHeight), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);
            System.Runtime.InteropServices.Marshal.Copy(downsizedImageBytes, 0, bmpData.Scan0, downsizedImageBytes.Length);
            downsizedBitmap.UnlockBits(bmpData);
            return downsizedBitmap;
        }

        public byte[] DownscaleImage(byte[] imageData, double scale)
        {

            int newWidth = (int)(Image.Width * scale);
            int newHeight = (int)(Image.Height * scale);


            //ensuring that the stride is a multiple of 4
            int newStride = (newWidth * 3 + 3) & ~3;

            byte[] outputData = new byte[newStride * newHeight];


            int numThreads = 10;
            int rowsPerThread = newHeight / numThreads;

            List<Thread> threads = new List<Thread>();

           

            for (int i = 0; i < numThreads; i++)
            {
                int startY = i * rowsPerThread;
                int endY;
                if (i == numThreads - 1)
                {
                    endY = newHeight;
                }else
                {
                    endY = (i + 1) * rowsPerThread;
                }

                threads.Add(new Thread(() =>
                {
                    ProcessImageRegion(imageData, outputData, newWidth, startY, endY, scale,newStride);
                }));
            }

            foreach (var thread in threads)
            {
                thread.Start();
            }

        /*    foreach (var thread in threads)
            {
                thread.Join();
            }
           */
           
            return outputData;
        }

        private void ProcessImageRegion(byte[] imageData, byte[] outputData, int newWidth, int startY, int endY, double scale, int newStride)
        {
            for (int y = startY; y < endY; y++)
            {
                for (int x = 0; x < newWidth; x++)
                {
                    double originalX = x / scale;
                    double originalY = y / scale;

                    int x0 = (int)originalX;
                    int x1 = x0 + 1;
                    int y0 = (int)originalY;
                    int y1 = y0 + 1;

                    double weightX1 = originalX - x0;
                    double weightX0 = 1 - weightX1;
                    double weightY1 = originalY - y0;
                    double weightY0 = 1 - weightY1;

                    int inputIndex00 = (y0 * stride) + (x0 * 3);
                    int inputIndex01 = (y1 * stride) + (x0 * 3);
                    int inputIndex10 = (y0 * stride) + (x1 * 3);
                    int inputIndex11 = (y1 * stride) + (x1 * 3);

                    byte blue00 = imageData[inputIndex00];
                    byte green00 = imageData[inputIndex00 + 1];
                    byte red00 = imageData[inputIndex00 + 2];

                    byte blue01 = imageData[inputIndex01];
                    byte green01 = imageData[inputIndex01 + 1];
                    byte red01 = imageData[inputIndex01 + 2];

                    byte blue10 = imageData[inputIndex10];
                    byte green10 = imageData[inputIndex10 + 1];
                    byte red10 = imageData[inputIndex10 + 2];

                    byte blue11 = imageData[inputIndex11];
                    byte green11 = imageData[inputIndex11 + 1];
                    byte red11 = imageData[inputIndex11 + 2];

                    byte newBlue = (byte)(blue00 * weightX0 * weightY0 + blue01 * weightX0 * weightY1 +
                        blue10 * weightX1 * weightY0 + blue11 * weightX1 * weightY1);

                    byte newGreen = (byte)(green00 * weightX0 * weightY0 + green01 * weightX0 * weightY1 +
                        green10 * weightX1 * weightY0 + green11 * weightX1 * weightY1);

                    byte newRed = (byte)(red00 * weightX0 * weightY0 + red01 * weightX0 * weightY1 +
                        red10 * weightX1 * weightY0 + red11 * weightX1 * weightY1);

                    int outputIndex = (y * newStride) + (x * 3);
                    outputData[outputIndex] = newBlue;
                    outputData[outputIndex + 1] = newGreen;
                    outputData[outputIndex + 2] = newRed;
                }
            }
        }
    }

}
