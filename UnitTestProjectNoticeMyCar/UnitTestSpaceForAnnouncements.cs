using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjectNoticeMyCar
{
    [TestClass]
    public class UnitTestSpaceForAnnouncements
    {
        //1080x1920

        [TestMethod]
        public void SpaceForAnnouncements()
        {
            var view = new NoticeMyCar.BuyACar.WindowMain.View.ViewB();

            Assert.AreEqual(4, view.spaceForAnnouncements());
        }
    }
}
