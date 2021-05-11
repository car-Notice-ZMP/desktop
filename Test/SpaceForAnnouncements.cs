using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class SpaceForAnnouncements
    {
        [TestMethod]
        public void TestMethod1()
        {
            var view = new NoticeMyCar.BuyACar.WindowMain.View.ViewB();

            Assert.AreEqual(4, view.spaceForAnnouncements());
        }
    }
}
