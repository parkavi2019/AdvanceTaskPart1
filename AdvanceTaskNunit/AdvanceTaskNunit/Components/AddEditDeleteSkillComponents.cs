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
    public class AddEditDeleteSkillComponents : CommonDriver
    {
#pragma warning disable
        private IWebElement AddSkillTextBox;
        private IWebElement ChooseSkillLevel;
        private IWebElement AddButton;
        private IWebElement UpdateSkill;
        private IWebElement UpdateLevel;
        private IWebElement UpdateButton;
        private IWebElement messageBox;
        private string Message = "";

        public void renderAddComponents()
        {
            try
            {
                AddSkillTextBox = driver.FindElement(By.Name("name"));
                ChooseSkillLevel = driver.FindElement(By.Name("level"));
                AddButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderAddMessage()
        {
            try
            {
                messageBox = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderUpdateSkill()
        {
            try
            {
                UpdateSkill = driver.FindElement(By.Name("name"));
                UpdateLevel = driver.FindElement(By.Name("level"));
                UpdateButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td/div/span/input[1]"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void addNewSkill(SkillTestModel skilldata)
        {
            renderAddComponents();
            AddSkillTextBox.SendKeys(skilldata.AddSkill);
            //Choose the language level
            Thread.Sleep(1000);
            ChooseSkillLevel.Click();
            ChooseSkillLevel.SendKeys(skilldata.ChooseSkillLevel);
            //Click on Add button
           
            AddButton.Click();
            Thread.Sleep(3000);

        }

        public void updateSkill(SkillTestModel skilldata)
        {
            renderUpdateSkill();
            UpdateSkill.Clear();
            UpdateSkill.SendKeys(skilldata.AddSkill);
            Thread.Sleep(1000);
            //Choose the level from the drop down
            UpdateLevel.Click();
            Thread.Sleep(1000);
            UpdateLevel.SendKeys(skilldata.ChooseSkillLevel);
            //Click on Update button
            UpdateButton.Click();
            Thread.Sleep(2000);
        }

        public void DeleteSkill(SkillTestModel skilldata)
        {
            renderAddComponents();
            



        }
        public string GetMessageBoxText()
        {
            renderAddMessage();
            //get the text of the message element
            string Message = messageBox.Text;
            return Message;
        }

    }
}
