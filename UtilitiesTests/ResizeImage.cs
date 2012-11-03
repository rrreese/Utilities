using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utilities;

namespace UtilitiesTests
{
    [TestClass]
    public class ResizeImage
    {
        [TestMethod]
        public void ResizeDown()
        {
            Image image = new Bitmap(500, 500);

            var newImage = image.Resize(100, 200);

            Assert.AreEqual(newImage.Width, 100);
            Assert.AreEqual(newImage.Height, 200);
        }
    }
}
