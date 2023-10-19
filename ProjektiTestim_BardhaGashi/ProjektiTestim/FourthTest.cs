using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Threading;
using System.Security.Cryptography;
using OpenQA.Selenium.Support.UI;

namespace ProjektiTestim
{
    public class FourthTest
    {
        WebDriver driver4 = new ChromeDriver("D:\\");

        [Test]
        public void AddAnaliza()          //Shtimi i nje analize nga laboranti - Bardha Gashi
        {
            driver4.Navigate().GoToUrl("http://localhost:3000/");


            driver4.FindElement(By.Id("user_email"));
            IWebElement username = driver4.FindElement(By.Id("user_email"));


            driver4.FindElement(By.Id("user_password"));
            IWebElement password = driver4.FindElement(By.Id("user_password"));


            username.SendKeys("laborant@gmail.com");
            password.SendKeys("lab123");

            IWebElement button = driver4.FindElement(By.Id("user_submit"));
            button.Click();


            Thread.Sleep(2000);
            IWebElement button2 = driver4.FindElement(By.XPath("//nav[@class='navbar row navbar-light mx-5 mt-2']/a[@href='/laboratori']"));
            button2.Click();

            Thread.Sleep(2000);
            IWebElement button3 = driver4.FindElement(By.XPath("//a[.='Shto Analize']"));
            button3.Click();


            Thread.Sleep(2000);
            driver4.FindElement(By.Name("idUserLaboranti"));
            IWebElement idlab = driver4.FindElement(By.Name("idUserLaboranti"));
            idlab.SendKeys("7");

            driver4.FindElement(By.Name("idPacienti"));
            IWebElement pacienti = driver4.FindElement(By.Name("idPacienti"));
            pacienti.SendKeys("1");

            driver4.FindElement(By.Name("data"));
            IWebElement data = driver4.FindElement(By.Name("data"));
            data.SendKeys("05/21/2023");

            driver4.FindElement(By.Name("lloji"));
            IWebElement lloji = driver4.FindElement(By.Name("lloji"));
            lloji.SendKeys("Pasqyre e gjakut");


            Thread.Sleep(2000);
            IWebElement button4 = driver4.FindElement(By.Id("//button[@class='btn btn-dark btn-lg w-100 mt-5']"));
            button4.Click();

        }
    }
}
