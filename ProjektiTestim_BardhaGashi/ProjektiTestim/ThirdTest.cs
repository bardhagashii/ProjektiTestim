using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ProjektiTestim
{
    public class ThirdTest
    {
        WebDriver driver3 = new ChromeDriver("D:\\");

        [Test]
        public void ShikoActivityLog() // Shikimi i faqes ActivityLog nga Admini -- Bardha Gashi
        {
            driver3.Navigate().GoToUrl("http://localhost:3000/");

            driver3.FindElement(By.Id("user_email"));
            IWebElement username = driver3.FindElement(By.Id("user_email"));


            driver3.FindElement(By.Id("user_password"));
            IWebElement password = driver3.FindElement(By.Id("user_password"));


            username.SendKeys("bardha@gmail.com");
            password.SendKeys("bardha123");

            IWebElement button = driver3.FindElement(By.Id("user_submit"));
            button.Click();

            Thread.Sleep(2000);
            IWebElement button8 = driver3.FindElement(By.XPath("//a[4]"));
            button8.Click();
        }
    }
}
