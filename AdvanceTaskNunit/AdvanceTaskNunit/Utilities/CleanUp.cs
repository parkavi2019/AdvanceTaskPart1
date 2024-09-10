using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTaskNunit.Utilities
{
    public class CleanUp : CommonDriver
    {
        public void ClearLanguageExistingdata()
        {
            try
            {
                IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
                var deleteButtons = driver.FindElements(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
                foreach (var button in deleteButtons)
                {
                    button.Click();
                    Thread.Sleep(2000);
                }

            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("no items to delete");
            }

        }
        public void clearSkillExistingdata()
        {
            try
            {


                IWebElement DeleteButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
                var DeleteButtons = driver.FindElements(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));

                foreach (var Button in DeleteButtons)
                {
                    Button.Click();
                }

            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("no items to delete");
            }

        }

    }
}
