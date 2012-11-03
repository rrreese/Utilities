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
            Assert.AreEqual(point.Item1, 600);
            Assert.AreEqual(point.Item2, 422);
        }

        [TestMethod]
        public void XImageDimensionsLargerThenFitDiemnsions()
        {
            var point = ImageHelper.ResizeDimensions(1024, 720, 800, 800);
            Assert.AreEqual(point.Item1, 800);
            Assert.AreEqual(point.Item2, 562);
        }

        [TestMethod]
        public void YImageDimensionsLargerThenFitDiemnsions()
        {
            var point = ImageHelper.ResizeDimensions(720, 1024, 800, 800);
            Assert.AreEqual(point.Item1, 562);
            Assert.AreEqual(point.Item2, 800);
        }

        [TestMethod]
        public void BothImageDimensionsSmallerThenFitDiemnsions()
        {
            var point = ImageHelper.ResizeDimensions(1024, 720, 1200, 1200);
            Assert.AreEqual(point.Item1, 1024);
            Assert.AreEqual(point.Item2, 720);
        }

        [TestMethod]
        public void ImageDimensionsEqualFitDiemnsions()
        {
            var point = ImageHelper.ResizeDimensions(1024, 720, 1024, 720);
            Assert.AreEqual(point.Item1, 1024);
            Assert.AreEqual(point.Item2, 720);
        }

        [TestMethod]
        public void ImageDimensionsWiderButHeightOutsideFitWidthInsideFit()
        {
            var point = ImageHelper.ResizeDimensions(790, 610, 800, 600);
            Assert.AreEqual(point.Item1, 777);
            Assert.AreEqual(point.Item2, 600);
        }
    }
}
