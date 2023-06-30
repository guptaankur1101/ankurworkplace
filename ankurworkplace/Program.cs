using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public class Program
{
    private static void Main(string[] args)
    {
        IWebDriver driver = new ChromeDriver();

        // open link 
        driver.Navigate().GoToUrl("http://192.168.1.251/sscmain/login.html");

        // identify usename and enter username
        IWebElement idtextbox = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/form/div[1]/input"));
        idtextbox.SendKeys("ankur");

        // identify password and enter password
        IWebElement passwordtextbox = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/form/div[2]/input"));
        passwordtextbox.SendKeys("sscnz01");

        // click signinbutton 
        IWebElement signinbutton = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/form/div[4]/div[2]/button[1]"));
        signinbutton.Click();

        // make sure user is successfully login


    }

    }
