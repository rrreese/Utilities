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
        public static Tuple<int,int> ResizeDimensions(double imageWidth, double imageHeight, double fitWidth, double fitHeight)
        {
            if (imageWidth <= fitWidth && imageHeight <= fitHeight)
            {
                return new Tuple<int, int>((int)imageWidth, (int)imageHeight);
            }

            if (imageWidth > fitWidth)
            {
                return new Tuple<int, int>((int) fitWidth, (int) Math.Round((fitWidth/imageWidth)*imageHeight));
            }

            if (imageHeight > fitHeight)
            {
                return new Tuple<int, int>((int)Math.Round((fitHeight / imageHeight) * imageWidth), (int)fitHeight);
            }
         
            return new Tuple<int, int>(0, 0);
        }
    }
}
