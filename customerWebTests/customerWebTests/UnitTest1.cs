using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace customerWebTests
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver browser;
        IWebElement tb_fio, tb_passport, tb_requisites, lb_result, btn_add, btn_delete, btn_update, form1;

        [TestInitialize]
        public void TestInit()
        {
            browser = new OpenQA.Selenium.IE.InternetExplorerDriver();
            browser.Navigate().GoToUrl("http://localhost:10119/WebForm1.aspx");

            tb_fio = browser.FindElement(By.Id("TextBox1"));
            tb_passport = browser.FindElement(By.Id("TextBox2"));
            tb_requisites = browser.FindElement(By.Id("TextBox3"));
            lb_result = browser.FindElement(By.Id("Label1"));
            btn_add = browser.FindElement(By.Id("Button5"));
            btn_delete = browser.FindElement(By.Id("Button6"));
            btn_update = browser.FindElement(By.Id("Button4"));
            form1 = browser.FindElement(By.Id("form1"));
        }

        [TestCleanup]
        public void TestClean()
        {
            browser.Close();
        }
        [TestMethod]
        public void UpdateEmptyTest()
        {
            btn_update.Click();
            lb_result = browser.FindElement(By.Id("Label1"));
            Assert.AreEqual(lb_result.Text, "Ничего не выбрано");
        }
        [TestMethod]
        public void InsertEmptyTest()
        {
            btn_add.Click();
            lb_result = browser.FindElement(By.Id("Label1"));
            Assert.AreEqual(lb_result.Text, "Введены недопустимые данные");
        }
        [TestMethod]
        public void DeleteEmptyTest()
        {
            btn_delete.Click();
            lb_result = browser.FindElement(By.Id("Label1"));
            Assert.AreEqual(lb_result.Text, "Ничего не выбрано");
        }
        [TestMethod]
        public void TestAddEmptyFIO()
        {
            tb_fio.SendKeys(OpenQA.Selenium.Keys.Backspace);
            tb_passport.SendKeys("222");
            tb_requisites.SendKeys("333");
            btn_add.Click();
            lb_result = browser.FindElement(By.Id("Label1"));
            Assert.AreEqual(lb_result.Text, "Введены недопустимые данные");
        }
        [TestMethod]
        public void TestAddEmptyPassport()
        {
            tb_fio.SendKeys("qqq");
            tb_passport.SendKeys(OpenQA.Selenium.Keys.Backspace);
            tb_requisites.SendKeys("333");
            btn_add.Click();
            lb_result = browser.FindElement(By.Id("Label1"));
            Assert.AreEqual(lb_result.Text, "Введены недопустимые данные");
        }
        [TestMethod]
        public void TestUpdateEmptyRequisites()
        {
            tb_fio.SendKeys("qqq");
            tb_passport.SendKeys("333");
            tb_requisites.SendKeys(OpenQA.Selenium.Keys.Backspace);
            btn_update.Click();
            lb_result = browser.FindElement(By.Id("Label1"));
            Assert.AreEqual(lb_result.Text, "Ничего не выбрано");
        }
    }
}
