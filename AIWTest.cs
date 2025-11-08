using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestProject
{
    public class AIWTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestA()
        {
            // create a new instance of the selenium web driver
            IWebDriver driver = new ChromeDriver();
            // navigate to a URL
            driver.Navigate().GoToUrl("http://192.168.0.173/AIW-DQMS/");
            // find the login link (using Xpath)
            IWebElement loginlink = driver.FindElement(By.XPath("//input[@placeholder='UserName']"));
            // type in the username
            loginlink.SendKeys("admin"); 
            // find the password textbox (using CssSelector)
            IWebElement txtPassword = driver.FindElement(By.CssSelector("input[placeholder = 'Password']"));
            // type in the password
            txtPassword.SendKeys("admin");
            // find the login button
            IWebElement btn = driver.FindElement(By.XPath("//button[normalize-space()='LOGIN']"));
            // click the LOGIN button
            btn.Click();
        }


    }
}
