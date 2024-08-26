using AdvanceTaskNunit.Test_Model;
using AdvanceTaskNunit.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTaskNunit.Components
{
    public class SearchSkillComponent : CommonDriver
    {
#pragma warning disable
        ProfileTabComponent profileTabComponentObj;
        private static IWebElement searchSkillTextBox;
        private static IWebElement searchIcon;
      
       
        private static IWebElement onlineButton;
        
        private IWebElement messageBox;
        private string Message = "";
        public SearchSkillComponent()
        {
            profileTabComponentObj = new ProfileTabComponent();
        }
        public void renderSearchSkillTextBox()
        {

            try
            {
                searchSkillTextBox = driver.FindElement(By.XPath("//*[@id=\"service-search-section\"]/div[1]/div[1]/input"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
     
        public void renderSearchicon()
        {
            try
            {
                searchIcon = driver.FindElement(By.XPath("//*[@id=\"service-search-section\"]/div[1]/div[1]/i"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderOnlineButton()
        {
            try
            {
                onlineButton = driver.FindElement(By.XPath("//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[1]/div[5]/button[1]"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void AddCategoriesSkill(SearchSkillTestModel searchSkilldata)
        {
         
            renderSearchSkillTextBox();
             searchSkillTextBox.SendKeys(searchSkilldata.Categories);
            renderSearchicon();
            searchIcon.Click();
            Thread.Sleep(2000);
            
        }
       
        public void AddSubCategories(SearchSkillTestModel searchSkilldata)
        {
            renderSearchSkillTextBox();

            searchSkillTextBox.SendKeys(searchSkilldata.SubCategories);
            renderSearchicon();
            searchIcon.Click();
            Thread.Sleep(2000);
        }
       public void FilterSearch(SearchSkillTestModel searchSkilldata)
        {
            renderOnlineButton();
            onlineButton.Click();
            Thread.Sleep(2000);
        }
    }
}
