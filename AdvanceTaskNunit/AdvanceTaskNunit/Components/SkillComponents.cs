using AdvanceTaskNunit.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTaskNunit.Components
{
    public class SkillComponents : CommonDriver
    {
#pragma warning disable
        private IWebElement AddNew;
        private IWebElement editButton;
        private IWebElement deleteButton;
        public void renderComponents()
        {
            try
            {
                AddNew = driver.FindElement(By.XPath("//div[@class='ui teal button']"));
                editButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
                deleteButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void clickAddSkill()
        {
            renderComponents();
            AddNew.Click();

        }
        public void clickUpdateSkill()
        {
            renderComponents();
            Thread.Sleep(2000);
            editButton.Click();
        }
        public void clickDeleteSkill()
        {
            renderComponents();
            Thread.Sleep(2000);
            deleteButton.Click();
        }
    }
}
