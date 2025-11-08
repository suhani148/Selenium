using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace SeleniumDemo
{
    
    public class TestClass
    {
        
        public void Test()
        {
            //sudo code for selenium
            //create a new instance of the selenium web driver
            IWebDriver driver = new ChromeDriver();
            //navigate to a URL
            driver.Navigate().GoToUrl("http://www.google.com/");
            //maximize the browser window

            //find an element
            //type in the element
            //click on the element
            driver.Quit();
        }
    }
}
