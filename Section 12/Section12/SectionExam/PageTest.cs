using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Section12.SectionExam
{
    [TestClass]
    public class PageTest
    {
        [TestMethod]
        public void Test_Page1()
        {
            IPageObject pageObject1 = new PageObjectOne();
            Assert.AreEqual("Page Name 1", pageObject1.PageName);
        }

        [TestMethod]
        public void Test_Page2()
        {
            IPageObject pageObject2 = new PageObjectTwo();
            Assert.AreEqual("Page Name 2", pageObject2.PageName);
        }
    }
}
