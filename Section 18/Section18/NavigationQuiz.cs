using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Data;
using System.Threading;

namespace Section18
{
    [TestClass]
    public class NavigationQuiz
    {
        public static IWebDriver driver;
        public static WebDriverWait wait;

        [TestInitialize]
        public void Start()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            if (driver != null)
            {
                return;
            }
        }

        [TestMethod]
        [TestCategory("Navigation")]
        public void SeleniumNavigationTest()
        {
            //Go here and assert for title - "http://www.ultimateqa.com"
            driver.Navigate().GoToUrl("http://www.ultimateqa.com");
            Assert.AreEqual("Home - Ultimate QA", driver.Title);

            //Go here and assert for title - "http://www.ultimateqa.com/automation"
            driver.Navigate().GoToUrl("http://www.ultimateqa.com/automation");
            Assert.AreEqual("Home - Ultimate QA", driver.Title);

            //Go here and assert for title - "http://www.ultimateqa.com/complicated-page"
            driver.FindElement(By.XPath("//*[@href='../complicated-page']")).Click();
            Assert.AreEqual("Complicated Page - Ultimate QA", driver.Title);
            
            //Go back and assert
            driver.Navigate().Back();
            Assert.AreEqual("Automation Practice - Ultimate QA", driver.Title);
        }

        [TestMethod]
        [TestCategory("Manipulation")]
        public void Manipulation()
        {
            driver.Navigate().GoToUrl("http://www.ultimateqa.com/filling-out-forms/");
            //find the name field
            //clear the field
            //type into the field
            var nameField = driver.FindElement(By.Id("et_pb_contact_name_0"));
            nameField.Clear();
            nameField.SendKeys("test");

            //find the text field
            //clear the field
            //type into the field
            var textBox = driver.FindElement(By.Id("et_pb_contact_message_0"));
            textBox.Clear();
            textBox.SendKeys("testing");
            //submit
            var submitButton = driver.FindElements(By.ClassName("et_contact_bottom_container"));
            submitButton[0].Submit();

        }

        [TestMethod]
        [TestCategory("Manipulation")]
        public void ManipulationTest()
        {
            driver.Navigate().GoToUrl("http://www.ultimateqa.com/filling-out-forms/");
            var name = driver.FindElement(By.Id("et_pb_contact_name_1"));
            name.SendKeys("Test Name");

            var textarea = driver.FindElement(By.Id("et_pb_contact_message_1"));
            textarea.SendKeys("Test Text area");

            var captcha = driver.FindElement(By.ClassName("et_pb_contact_captcha_question"));
            var table = new DataTable();
            var captchaAnswer = (int)table.Compute(captcha.Text, "");

            var captchaTextBox = driver.FindElement(By.ClassName("et_pb_contact_captcha"));
            captchaTextBox.SendKeys(captchaAnswer.ToString());

            driver.FindElements(By.XPath("//*[@class='et_pb_contact_submit et_pb_button']"))[1].Submit();
            var successMessage = driver.FindElements(By.ClassName("et-pb-contact-message"))[1].FindElement(By.TagName("p"));
            Assert.IsTrue(successMessage.Text.Equals("Success"));

            Thread.Sleep(2000);
        }

        [TestMethod]
        [TestCategory("Driver Interrogation")]
        public void DriverLevelInterrogation()
        {
            driver.Navigate().GoToUrl("http://www.ultimateqa.com/automation");
            var x = driver.CurrentWindowHandle;
            var y = driver.WindowHandles;
            x = driver.PageSource;
            x = driver.Title;
            x = driver.Url;
        }

        [TestMethod]
        [TestCategory("Element Interrogation")]
        public void ElementInterrogation()
        {
            driver.Navigate().GoToUrl("http://www.ultimateqa.com/automation");
            var myElement = driver.FindElement(By.XPath("//*[@href='http://courses.ultimateqa.com/users/sign_in']"));
        }

        [TestMethod]
        [TestCategory("Element Interrogation")]
        public void ElementInterrogationTest()
        {
            driver.Url = "http://www.ultimateqa.com/simple-html-elements-for-automation/";
            driver.Manage().Window.Maximize();

            var myElement = driver.FindElement(By.Id("button1"));
            Assert.AreEqual("submit", myElement.GetAttribute("type"));
            Assert.AreEqual("normal", myElement.GetCssValue("letter-spacing"));
            Assert.IsTrue(myElement.Displayed);
            Assert.IsTrue(myElement.Enabled);
            Assert.IsFalse(myElement.Selected);
            Assert.AreEqual(myElement.Text, "Click Me!");
            Assert.AreEqual("button", myElement.TagName);
            Assert.AreEqual(24, myElement.Size.Height);
            Assert.AreEqual(341, myElement.Location.X);
            Assert.AreEqual(168, myElement.Location.Y);

            Thread.Sleep(2000);
        }

        [TestCleanup]
        public void Stop()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
