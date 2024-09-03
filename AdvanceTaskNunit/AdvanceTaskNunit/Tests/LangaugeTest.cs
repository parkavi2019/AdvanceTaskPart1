using AdvanceTaskNunit.Components;
using AdvanceTaskNunit.Pages;
using AdvanceTaskNunit.Steps;
using AdvanceTaskNunit.Test_Model;
using AdvanceTaskNunit.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTaskNunit.Tests
{
    [TestFixture]
    public class LangaugeTest : CommonDriver
    {
        ProfileTabComponent profileTabComponentObj;
        LanguageStep languageStepObj;
      


#pragma warning disable

        public LangaugeTest()
        {
          
            profileTabComponentObj = new ProfileTabComponent();
            languageStepObj = new LanguageStep();
           
        }

        [Test, Order(1),Description("Verify that a language and its level can be added")]

        public void TestAddLanguage()
        {
            profileTabComponentObj.clickLangaugesTab();
           
            languageStepObj.AddLanguage();

        }

        [Test, Order(2)]
        public void TestEditLanguage()
        {
            profileTabComponentObj.clickLangaugesTab();

            languageStepObj.AddLanguage();
            languageStepObj.updateLanguage();
            
        }


        
        [Test, Order(3)]

        public void TestDeleteLanguage()
        {
            profileTabComponentObj.clickLangaugesTab();

            languageStepObj.AddLanguage();
            languageStepObj.deleteLanguage();

       

         }
       
        
    }
}
