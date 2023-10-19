using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektiTestim
{
    public class FirstTest
    {
        WebDriver driver1 = new ChromeDriver("D:\\");

        [Test]
        public void LogInPage() // Kycja ne sistem me te dhena valide - Bardha Gashi
        {
            driver1.Navigate().GoToUrl("http://localhost:3000/");

            driver1.FindElement(By.Id("user_email"));
            IWebElement username = driver1.FindElement(By.Id("user_email"));


            driver1.FindElement(By.Id("user_password"));
            IWebElement password = driver1.FindElement(By.Id("user_password"));


            username.SendKeys("recepsionist@gmail.com");
            password.SendKeys("rec123");

            IWebElement button = driver1.FindElement(By.Id("user_submit"));
            button.Click();
        }
    }
}
