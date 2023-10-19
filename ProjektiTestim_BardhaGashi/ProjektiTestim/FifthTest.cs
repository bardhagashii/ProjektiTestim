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
    public class FifthTest
    {
        WebDriver driver5 = new ChromeDriver("D:\\");

        [Test]
        public void getText() // Gjetja e nje fjale specifike - Bardha Gashi
        {
            driver5.Navigate().GoToUrl("http://localhost:3000/");

            driver5.FindElement(By.Id("user_email"));
            IWebElement username = driver5.FindElement(By.Id("user_email"));


            driver5.FindElement(By.Id("user_password"));
            IWebElement password = driver5.FindElement(By.Id("user_password"));


            username.SendKeys("recepsionist@gmail.com");
            password.SendKeys("rec123");

            IWebElement button = driver5.FindElement(By.Id("user_submit"));
            button.Click();

            Thread.Sleep(2000);
            IWebElement element = driver5.FindElement(By.XPath("//nav[@class='navbar row navbar-light mx-5 mt-2']/a[contains(.,'Faturat')]"));
            string text = element.Text;
            element.Click();

            Console.WriteLine("Teksti i kerkuar eshte " + text + ".");
        }
    }
}