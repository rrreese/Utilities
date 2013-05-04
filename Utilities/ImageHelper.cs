using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;


namespace Utilities
{
    public static class ImageHelper
    {
        /// <summary>
        /// Based on the dimensions of the old image rectangle, returns the dimensions for a new image rectangle that fits within the new dimensions. 
        /// This will result in a letterboxed rectangle that has the same aspect ratio as the original rectangle.
        /// </summary>
        public static Point ResizeDimensions(double imageWidth, double imageHeight, double fitWidth, double fitHeight)
        {
            if (imageWidth <= fitWidth && imageHeight <= fitHeight)
            {
                return new Point((int)imageWidth, (int)imageHeight);
            }

            if (imageWidth > fitWidth)
            {
                return new Point((int)fitWidth, (int)Math.Round((fitWidth / imageWidth) * imageHeight));
            }

            if (imageHeight > fitHeight)
            {
                return new Point((int)Math.Round((fitHeight / imageHeight) * imageWidth), (int)fitHeight);
            }

            return new Point(0, 0);
        }

        public static Image Resize(this Image image, int newWidth, int newHeight, SmoothingMode quality = SmoothingMode.HighQuality)
        {
            var newImage = new Bitmap(newWidth, newHeight);

            using (var graphics = Graphics.FromImage(newImage))
            {
                graphics.SmoothingMode = quality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                graphics.DrawImage(image, new Rectangle(0, 0, newWidth, newHeight));
            }

            return newImage;
        }

        public static void SaveAtQuality(this Image image, string path, int quality)
        {
            ImageCodecInfo jgpEncoder = GetImageEncoder(ImageFormat.Jpeg);

            var myEncoderParameters = new EncoderParameters(1);
            myEncoderParameters.Param[0] = new EncoderParameter(Encoder.Quality, quality);
            image.Save(path, jgpEncoder, myEncoderParameters);
        }

        public class Point
        {
            public int X { get; set; }
            public int Y { get; set; }

            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }
        }

        private static ImageCodecInfo GetImageEncoder(ImageFormat format)
        {

            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();

            return codecs.FirstOrDefault(codec => codec.FormatID == format.Guid);
        }
    }



}
