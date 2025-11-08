using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;


namespace SeleniumTestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            ///sudo code for selenium

            ///create a new instance of the selenium web driver
            IWebDriver driver = new ChromeDriver();

            ///navigate to a URL
            driver.Navigate().GoToUrl("http://www.google.com/"); //driver->object of IWebDriver, Navigate()-> method on IWebDriver,it returns INavigation, GoToUrl()-> method on INavigation

            ///maximize the browser window
            driver.Manage().Window.Maximize();//Manage()-> method on IWebDriver, it returns IOptions, Window-> property on IOptions, it returns IWindow, Maximize()-> method on IWindow
                                              //driver.Manage()-> is indirectly IOptions     //driver.Manage().Window-> is indirectly IWindow 

            ///find an element
            IWebElement webelement = driver.FindElement(By.Name("q"));//FindElement()-> method on IWebDriver, it returns IWebElement, By.Name()-> is a locator 
            //IWebElement-> interface representing an HTML element

            ///type in the element
            webelement.SendKeys("selenium");//SendKeys()-> method on IWebElement, it simulates typing into the element

            ///click on the element
            webelement.SendKeys(Keys.Return);//Keys.Return-> simulates pressing the Enter key
        }

        [Test]
        public void Test2()
        {
            // 1.create a new instance of the selenium web driver
            IWebDriver driver = new ChromeDriver();
            // 2.navigate to a URL
            driver.Navigate().GoToUrl("http://eaapp.somee.com/");
            // 3.find the login link
            IWebElement loginlink = driver.FindElement(By.LinkText("Login"));
            // 4.click the login link
            loginlink.Click();
            // 5.find the username textbox
            IWebElement txtUserName = driver.FindElement(By.Name("UserName"));
            // 6.type in the username
            txtUserName.SendKeys("admin");
            // 7. find the password textbox
            IWebElement txtPassword = driver.FindElement(By.Name("Password"));
            // 8. type in the password
            txtPassword.SendKeys("password");
            // 9. find the login button using class name
            //IWebElement btn = driver.FindElement(By.ClassName("btn"));
            // 9a. alternative way to find the login button using CSS Selector
            IWebElement btn = driver.FindElement(By.CssSelector(".btn"));
            // 10.submit the login form
            btn.Submit();
        }

        [Test]
        public void TestWithReducedCode()
        {
            // create a new instance of the selenium web driver
            IWebDriver driver = new ChromeDriver();
            // navigate to a URL
            driver.Navigate().GoToUrl("http://eaapp.somee.com/");
            // find the login link and click it
            driver.FindElement(By.LinkText("Login")).Click();
            // find the username textbox and type in the username
            driver.FindElement(By.Name("UserName")).SendKeys("admin");
            // find the password textbox and type in the password
            driver.FindElement(By.Name("Password")).SendKeys("password");
            // find the login button using CSS selector and submit the login form
            driver.FindElement(By.CssSelector(".btn")).Submit();
        }

        [Test]
        public void TestWithAdvancedSelectors()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.tutorialspoint.com/selenium/practice/select-menu.php");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

            Actions actions = new Actions(driver);

            // Try clicking the span overlay first
            IWebElement dropdownSpan = driver.FindElement(By.XPath("//span[contains(@class,'mbsc-textfield-tags')]"));
            dropdownSpan.Click();

 
            // Select the option by visible text, update as needed
            IWebElement booksOption = wait.Until(d => d.FindElement(By.XPath("//div[@role='option' and normalize-space()='Books']")));
            booksOption.Click();

            // select the next option
            IWebElement electronicsOption = wait.Until(d => d.FindElement(By.XPath("//div[@role='option' and normalize-space()='Electronics & Computers']")));
            electronicsOption.Click();

            actions.SendKeys(Keys.Escape).Perform();

            // find the select one box and click 
            //IWebElement selectOne = driver.FindElement(By.Id("inputGroupSelect03"));
            //selectOne.Click();

            //pick one 
            SelectElement selectElement = new SelectElement(driver.FindElement(By.Id("inputGroupSelect03")));
            selectElement.SelectByText("Dr.");
        }

    }
}