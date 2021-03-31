using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Section15.Inheritance_Exam
{
    [TestClass]
    [TestCategory("Final Exam")]
    public class ExamTest
    {
        [TestMethod]
        public void Test_ComplicatedPage()
        {
            ComplicatedPage compPage = new ComplicatedPage();
            string pageName = compPage.PageName;
            Assert.AreEqual("Complicated Page", pageName);
        }

        [TestMethod]
        public void Test_RandomStuff()
        {
            SectionOfRandomStuff random = new SectionOfRandomStuff();
            random.FillForm();
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void Test_Buttons()
        {
            SectionOfButtons buttons = new SectionOfButtons();
            buttons.Button.Click();

            Console.WriteLine("Null reference to the button element");
        }
    }
}
