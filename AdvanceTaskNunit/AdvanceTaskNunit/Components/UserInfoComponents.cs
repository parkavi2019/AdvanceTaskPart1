using AdvanceTaskNunit.Test_Model;
using AdvanceTaskNunit.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using RazorEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace AdvanceTaskNunit.Components
{
    public class UserInfoComponents : CommonDriver
    {
#pragma warning disable
        ProfileTabComponent profileTabComponentObj;
        
        private IWebElement availabilityTextBox;
        private IWebElement hoursTextBox;
        private IWebElement earnTargetBox;
        private IWebElement messageBox;
        private string Message = "";

        public UserInfoComponents()
        {
            profileTabComponentObj = new ProfileTabComponent();
        }

        public void renderAvailability()
        {
            try
            {
                availabilityTextBox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select"));

                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
       public void renderHours()
        {
            try
            {
                hoursTextBox = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/select"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderEarnTarget()
        {
            try
            {
                earnTargetBox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/select"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void addUserinfo(UserInfoTestModel userinfodata)
        {
            profileTabComponentObj.clickAvailabilityeditButton();
            renderAvailability();
             availabilityTextBox.SendKeys(userinfodata.Availability);
            Thread.Sleep(1000);

            profileTabComponentObj.clickHoursWeekPencilIcon();
            renderHours();
             Thread.Sleep(2000);
            hoursTextBox.SendKeys(userinfodata.Hours);
           
            profileTabComponentObj.clickEarnTargetPencilIcon();
            renderEarnTarget();
            Thread.Sleep(3000);
            earnTargetBox.SendKeys(userinfodata.EarnTarget);
            
        }
       



    }
}
