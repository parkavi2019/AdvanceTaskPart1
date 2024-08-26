using AdvanceTaskNunit.Steps;
using AdvanceTaskNunit.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTaskNunit.Components
{
    public class ProfileTabComponent : CommonDriver
    {
#pragma warning disable
        private IWebElement languagesTab;
       
        private IWebElement skillsTab;
       
        private IWebElement availabilityPencilIcon;
        private IWebElement hourspencilIcon;
        private IWebElement earnTargetPencilIcon;
        private static IWebElement shareSkillButton;
        private static IWebElement saveButton;
     
        private static IWebElement clickSearchicon;
        private static IWebElement clickDashboard;
     


        public void renderComponents()
        {
            try
            {
                languagesTab = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));

                 skillsTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
                availabilityPencilIcon = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i"));
                hourspencilIcon = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i"));
                earnTargetPencilIcon = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/i"));
                
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void clickLangaugesTab()
        {
            renderComponents();
            Thread.Sleep(1000);
            languagesTab.Click();
        }
        public void clickSkillsTab()
        {
            
            renderComponents();
           
            skillsTab.Click();
            Thread.Sleep(1000);
        }
        public void clickAvailabilityeditButton()
        {
            renderComponents();
            Thread.Sleep(1000);
            availabilityPencilIcon.Click();
           
        }
        public void clickHoursWeekPencilIcon()
        {
            renderComponents();
            Thread.Sleep(2000);
            hourspencilIcon.Click();
           

        }
        public void clickEarnTargetPencilIcon()
        {
            renderComponents();
            Thread.Sleep(2000);
            earnTargetPencilIcon.Click();
            
        }
       public void renderShareskill()
        {
            try
            {
                shareSkillButton = driver.FindElement(By.XPath("//a[contains(text(),'Share Skill')]"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void clickShareSkillButton()
        {
            renderShareskill();
            Thread.Sleep(1000);
            shareSkillButton.Click();
            
        }
        public void renderSaveButton()
        {
            try
            {
                saveButton = driver.FindElement(By.XPath("//input[@value='Save']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void ClickSavebutton()
        {
            renderSaveButton();
            saveButton.Click();
            Thread.Sleep(1000);
        }
         public void renderClicksearch()
         {
             try
             {
                 clickSearchicon = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[1]/i"));
                //*[@id="service-search-section"]/div[1]/div[1]/i
            }
            catch (Exception ex)
             {

             Console.WriteLine(ex); 
             }
         }
         public void clickSearchIcon()
         {
            Thread.Sleep(2000);
             renderClicksearch();
            
             clickSearchicon.Click();
            Thread.Sleep(1000);
        }
        public void renderClickDashboard()
        {
            try
            {
                clickDashboard = driver.FindElement(By.LinkText("Dashboard"));
             
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
      
        public void clickDashboardTab()
        {
            renderClickDashboard();
            clickDashboard.Click();
            Thread.Sleep(1000);
        }
      
    }
}
