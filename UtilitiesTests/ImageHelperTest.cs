using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utilities;

namespace UtilitiesTests
{
    [TestClass]
    public class ImageHelperTest
    {
        [TestMethod]
        public void BothImageDimensionsLargerThenFitDiemnsions()
        {
            var point = ImageHelper.ResizeDimensions(1024, 720, 600, 600);
            Assert.AreEqual(point.X, 600);
            Assert.AreEqual(point.Y, 422);
        }

        [TestMethod]
        public void XImageDimensionsLargerThenFitDiemnsions()
        {
            var point = ImageHelper.ResizeDimensions(1024, 720, 800, 800);
            Assert.AreEqual(point.X, 800);
            Assert.AreEqual(point.Y, 562);
        }

        [TestMethod]
        public void YImageDimensionsLargerThenFitDiemnsions()
        {
            var point = ImageHelper.ResizeDimensions(720, 1024, 800, 800);
            Assert.AreEqual(point.X, 562);
            Assert.AreEqual(point.Y, 800);
        }

        [TestMethod]
        public void BothImageDimensionsSmallerThenFitDiemnsions()
        {
            var point = ImageHelper.ResizeDimensions(1024, 720, 1200, 1200);
            Assert.AreEqual(point.X, 1024);
            Assert.AreEqual(point.Y, 720);
        }

        [TestMethod]
        public void ImageDimensionsEqualFitDiemnsions()
        {
            var point = ImageHelper.ResizeDimensions(1024, 720, 1024, 720);
            Assert.AreEqual(point.X, 1024);
            Assert.AreEqual(point.Y, 720);
        }

        [TestMethod]
        public void ImageDimensionsWiderButHeightOutsideFitWidthInsideFit()
        {
            var point = ImageHelper.ResizeDimensions(790, 610, 800, 600);
            Assert.AreEqual(point.X, 777);
            Assert.AreEqual(point.Y, 600);
        }

        [TestMethod]
        public void ZeroCase()
        {
            var point = ImageHelper.ResizeDimensions(0, 0, 800, 600);
            Assert.AreEqual(point.X, 0);
            Assert.AreEqual(point.Y, 0);


            point = ImageHelper.ResizeDimensions(800, 800, 0, 0);
            Assert.AreEqual(point.X, 0);
            Assert.AreEqual(point.Y, 0);
        }
    }
}
