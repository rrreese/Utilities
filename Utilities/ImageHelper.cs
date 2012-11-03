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
        public static Tuple<int,int> ResizeDimensions(int imageWidth, int imageHeight, int fitWidth, int fitHeight)
        {
            throw new NotImplementedException();
        }
    }
}
