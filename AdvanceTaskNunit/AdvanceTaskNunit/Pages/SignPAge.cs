using AdvanceTaskNunit.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTaskNunit.Pages
{
    public class SignPAge : CommonDriver
    {
#pragma warning disable
        private IWebElement signInButton;
        public void renderAddComponent()
        {
            try
            {
                signInButton = driver.FindElement(By.XPath("//a[text()='Sign In']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void ClickSignIn()
        {
            renderAddComponent();
            signInButton.Click();
            Thread.Sleep(2000);
        }
    }
}
