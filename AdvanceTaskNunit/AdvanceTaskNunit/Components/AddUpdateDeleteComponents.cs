using AdvanceTaskNunit.Test_Model;
using AdvanceTaskNunit.Utilities;
using OpenQA.Selenium;
using RazorEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTaskNunit.Components
{
    public class AddUpdateDeleteComponents : CommonDriver
    {
#pragma warning disable
        private IWebElement AddLanguageTextBox;
        private IWebElement ChooseLanguageLevel;
        private IWebElement AddButton;
        private IWebElement UpdateLanguage;
        private IWebElement UpdateLevel;
        private IWebElement UpdateButton;
        private IWebElement messageBox;
        private string Message = "";

        public void renderAddComponents()
        {
            try
            {
                AddLanguageTextBox = driver.FindElement(By.Name("name"));
                ChooseLanguageLevel = driver.FindElement(By.Name("level"));
                AddButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
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
        public void renderUpdateLanguage()
        {
            try
            {
                UpdateLanguage = driver.FindElement(By.Name("name"));
                UpdateLevel = driver.FindElement(By.Name("level"));
                UpdateButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex);
            }
        }
       
        public void addNewLanguage(LanguageTestModel languagedata)
        {
            renderAddComponents();
            AddLanguageTextBox.SendKeys(languagedata.AddLanguage);
            //Choose the language level
            ChooseLanguageLevel.Click();
            ChooseLanguageLevel.SendKeys(languagedata.ChooseLanguageLevel);
            //Click on Add button
            AddButton.Click();
            Thread.Sleep(5000);
        }

        public void updateLanguage(LanguageTestModel languageupdatedata)
        {
            renderUpdateLanguage();
            UpdateLanguage.Clear();
            UpdateLanguage.SendKeys(languageupdatedata.AddLanguage);
            Thread.Sleep(1000);
            //Choose the level from the drop down
            UpdateLevel.Click();
            Thread.Sleep(1000);
            UpdateLevel.SendKeys(languageupdatedata.ChooseLanguageLevel);
            //Click on Update button
            UpdateButton.Click();
            Thread.Sleep(2000);
        }

        public void DeleteLanguage(LanguageTestModel languagedata)
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
