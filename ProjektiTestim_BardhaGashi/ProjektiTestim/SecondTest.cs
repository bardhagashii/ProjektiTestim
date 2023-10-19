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
    public class SecondTest
    {
        WebDriver driver2 = new ChromeDriver("D:\\");

        [Test]
        public void LogInPageWithInvalidInputs() // Kycja ne sistem me te dhena jovalide - Bardha Gashi
        {
            driver2.Navigate().GoToUrl("http://localhost:3000/");

            driver2.FindElement(By.Id("user_email"));
            IWebElement username = driver2.FindElement(By.Id("user_email"));


            driver2.FindElement(By.Id("user_password"));
            IWebElement password = driver2.FindElement(By.Id("user_password"));


            username.SendKeys("alma@gmail.com");
            password.SendKeys("alma");

            IWebElement button = driver2.FindElement(By.Id("user_submit"));
            button.Click();
        }
    }
}
