using AdvanceTaskNunit.Test_Model;
using AdvanceTaskNunit.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTaskNunit.Components
{
    public class ShareSkillComponent : CommonDriver
    {
#pragma warning disable
        ProfileTabComponent profileTabComponentObj;

        private static IWebElement titleTextBox;
        private static IWebElement descriptionTextBox;
        private static IWebElement categoryBox;
        private static IWebElement subcategoryBox;
        private static IWebElement tagsBox;
        private static IWebElement availableStartday;
        private static  IWebElement availableEndday;
        private static IWebElement skillexchangeBox;

        private static IReadOnlyList<IWebElement> serviceType;
        private static IReadOnlyList<IWebElement> locationType;
        private static IReadOnlyList<IWebElement> skillTrade;
        private static IReadOnlyList<IWebElement> active;
        string serviceHourly = "Hourly basis service";
        string serviceOneoff = "One-off service";
        string locationOnsite = "On-site";
        string locationOnline = "Online";
        string skillExchange = "Skill-exchange";
        string skillCredit = "Credit";
        string activeBox = "active";
        string activeHidden = "Hidden";

        
        
#pragma warning disable
        public ShareSkillComponent()

        {
            profileTabComponentObj = new ProfileTabComponent();
        }
        public void renderTiltle()
        {
            try
            {
                titleTextBox = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderDescription()
        {
            try
            {
                descriptionTextBox = driver.FindElement(By.XPath("//body/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[2]/div[1]/div[2]/div[1]/textarea[1]"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderCategory()
        {
            try
            {
                categoryBox = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div/select"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderSubcategory()
        {
            try
            {
                subcategoryBox = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void renderTags()
        {
            try
            {
                tagsBox = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div/div/div/div/input"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderServiceType()
        {
            try
            {
               
                serviceType = driver.FindElements(By.Name("serviceType"));


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    
        public void renderLocationType()
        {
            try
            {
                locationType = driver.FindElements(By.Name("locationType"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderAvailableStartdays()
        {
            try
            {
                availableStartday = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[1]/div[2]/input"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderAvailableEnddays()
        {
            try
            {
                availableEndday = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[1]/div[2]/input"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderSkilltrade()
        {
            try
            {
                skillTrade = driver.FindElements(By.Name("skillTrades"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderSkillExchange()
        {
            try
            {
                skillexchangeBox = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderActive()
        {
            try
            {
                active = driver.FindElements(By.Name("isActive"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

       
        public void addShareSkill(ShareSkillTestModel shareskilldata)
        {
            profileTabComponentObj.clickShareSkillButton();
            Thread.Sleep(1000);

            renderTiltle();
           
            titleTextBox.SendKeys(shareskilldata.Title);
            Thread.Sleep(1000);


            renderDescription();
            descriptionTextBox.SendKeys(shareskilldata.Description);
            

            renderCategory();
            categoryBox.SendKeys(shareskilldata.Category);
            Thread.Sleep(2000);

            renderSubcategory();
            
            subcategoryBox.Click();
            subcategoryBox.SendKeys(shareskilldata.Subcategory);
           

            renderTags();
            tagsBox.SendKeys(shareskilldata.Tags);
            tagsBox.SendKeys("\n");
           

            renderServiceType();
            
            if(shareskilldata.ServiceType==serviceHourly)
            {
                serviceType.ElementAt(0).Click();
            }
            else
            {
                serviceType.ElementAt(1).Click();
            }
           
            
           renderLocationType();
            if (shareskilldata.LocationType == locationOnline)
            { 
                locationType.ElementAt(0).Click();
            }
            else
            {
                locationType.ElementAt(1).Click();
            }

            renderAvailableStartdays();
            availableStartday.Click();
            availableStartday.SendKeys(shareskilldata.Startdate);
            Thread.Sleep(1000);

            renderAvailableEnddays();
            availableEndday.Click();
            availableEndday.SendKeys(shareskilldata.Enddate);


            renderSkilltrade();
            if (shareskilldata.SkillTrade== skillExchange)
            { 
                skillTrade.ElementAt(0).Click();

            }
            else
            {
                skillTrade.ElementAt(1).Click();
            }
            renderSkillExchange();
            skillexchangeBox.SendKeys(shareskilldata.SkillExchange);
            skillexchangeBox.SendKeys("\n");
            

            renderActive();
            if(shareskilldata.Active== activeBox)
            {
                active.ElementAt(0).Click();
            }
            else
            {
                active.ElementAt(1).Click();
            }
            profileTabComponentObj.ClickSavebutton();

            Thread.Sleep(1000);
        }
    }
}
