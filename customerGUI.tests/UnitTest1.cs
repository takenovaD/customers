using System;
using System.Threading;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;

namespace customerGUI.tests
{
    [TestClass]
    public class UnitTest1
    {
        public static WindowsDriver<WindowsElement> winDriver;
        public static WindowsElement tb_fio,tb_passport, tb_requisites, status, btn_insert, btn_delete, btn_update, moveEnd, movePrev;

        [TestInitialize]
        public void TestInit()
        {
            var desiredCapabilities = new AppiumOptions();

            //Задание пути к тестируемому приложению
            desiredCapabilities.AddAdditionalCapability(
                "app", @"D:\7 семестр\Программная инженерия\курсовая Панов\customers\CustomerGUI\bin\Debug\CustomerGUI.exe");
            //Инициализация билиотеки Апиум ВинАпДрайвер
            //Установка соединения с утилитой ВинАпДрайвер
            //Запуск тестируемого приложения
            winDriver = new WindowsDriver<WindowsElement>(
                new Uri("http://127.0.0.1:4723"), desiredCapabilities);

            //Приостановка на 1 секунду для уверенности,
            //что тестируемое приложение успело запуститься
            Thread.Sleep(1000);

            tb_fio = winDriver.FindElementByAccessibilityId("textBox1");
            tb_passport = winDriver.FindElementByAccessibilityId("textBox2");
            tb_requisites  = winDriver.FindElementByAccessibilityId("textBox3");
            status = winDriver.FindElementByAccessibilityId("label5");
            btn_insert = winDriver.FindElementByAccessibilityId("add_btn");
            btn_delete = winDriver.FindElementByAccessibilityId("delete_btn");
            btn_update = winDriver.FindElementByAccessibilityId("edit_btn");
            moveEnd = winDriver.FindElementByAccessibilityId("next_last_btn");
            movePrev = winDriver.FindElementByAccessibilityId("prev_first_btn");
        }

        [TestCleanup]
        public void TestClean()
        {//По завершению теста, закрыть тестируемое приложение
            winDriver.Quit();
        }

        [TestMethod]
        public void InsertFailedTest()
        {

            tb_fio.SendKeys(OpenQA.Selenium.Keys.Backspace);
            
            tb_passport.SendKeys("111");
            tb_requisites.SendKeys("222");
            btn_insert.Click();
            Assert.AreEqual("Введены недопустимые данные", status.Text);
        }
        [TestMethod]
        public void InsertedTest()
        {

            tb_fio.SendKeys("qqq www eee");
            tb_passport.SendKeys("111");
            tb_requisites.SendKeys("222");
            btn_insert.Click();
            Assert.AreEqual("Добавлен новый гость", status.Text);
        }
        [TestMethod]
        public void UpdateFailed()
        {
            moveEnd.Click();
            tb_fio.SendKeys(OpenQA.Selenium.Keys.Backspace);
            btn_update.Click();
            Assert.AreEqual("Введены недопустимые данные", status.Text);
        }
        [TestMethod]
        public void UpdateSucces()
        {
            moveEnd.Click();
            tb_passport.SendKeys("333");
            btn_update.Click();
            Assert.AreEqual("Данные гостя успешно изменены", status.Text);
        }
        [TestMethod]
        public void DeleteSucces()
        {
            moveEnd.Click();
            btn_delete.Click();
            Assert.AreEqual("Гость успешно удален", status.Text);
        }
        [TestMethod]
        public void DeleteFailed()
        {
            movePrev.Click();
            btn_delete.Click();
            Assert.AreEqual("Невозможно удалить элемент.", status.Text);
        }
    }
}
