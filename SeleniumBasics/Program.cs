using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools;

namespace SeleniumBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
           // step 1 Launch Chrome browser in maximised mode
             IWebDriver driver = new ChromeDriver();
             driver.Manage().Window.Maximize();
           // step 2 Navigate Turnup Portal URL
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            // step 3 Enter Username 
            driver.FindElement(By.Id("UserName")).SendKeys("hari");
            // step 4 Enter Password
            driver.FindElement(By.Id("Password")).SendKeys("123123");
            // step 5 Click Login Button
            driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]")).Click();
            // step 6 Verify User Login successful
            string message = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a")).Text;
            if (message == "Hello Hari!")
                { 
                Console.WriteLine("User Login was Successful");
            }
            else
            {
                Console.WriteLine("User Login was unsuccessful");
            }
            // step 7 Close chrome browser
           // driver.Quit(); // driver.Close();
        }
    }
}
