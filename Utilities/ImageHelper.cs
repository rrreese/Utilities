using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                return new Point((int) fitWidth, (int) Math.Round((fitWidth/imageWidth)*imageHeight));
            }

            if (imageHeight > fitHeight)
            {
                return new Point((int)Math.Round((fitHeight / imageHeight) * imageWidth), (int)fitHeight);
            }

            return new Point(0, 0);
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
    }



}
