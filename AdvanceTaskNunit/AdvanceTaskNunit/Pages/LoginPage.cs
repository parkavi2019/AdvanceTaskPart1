using AdvanceTaskNunit.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTaskNunit.Pages
{
    public class LoginPage : CommonDriver
    {
#pragma warning disable

        private IWebElement emailTextbox;
        private IWebElement passwordTextbox;
        private IWebElement loginButton;
        public void renderAddComponents()
        {
            try
            {
                
                emailTextbox = driver.FindElement(By.Name("email"));
                passwordTextbox = driver.FindElement(By.Name("password"));
                loginButton = driver.FindElement(By.XPath("//button[text()='Login']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void LoginSteps()
        {
           
            
           
                renderAddComponents();
               
                emailTextbox.SendKeys("manjujayanthi03@gmail.com");
                passwordTextbox.SendKeys("12345678");
                loginButton.Click();
                Thread.Sleep(5000);
            
        }
    }
}

