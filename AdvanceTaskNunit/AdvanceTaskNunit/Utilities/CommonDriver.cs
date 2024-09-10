using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvanceTaskNunit.Pages;
using AdvanceTaskNunit.Steps;
using AdvanceTaskNunit.Components;

namespace AdvanceTaskNunit.Utilities
{
    public class CommonDriver
    {
#pragma warning disable
        public static IWebDriver driver;
        private ExtentReports extent;
        private ExtentTest test;
        SignPAge signPAgeObj;
        LoginStep loginStepObj;
        public static ProfileTabComponent profileTabComponentObj;

        public static LanguageComponent languageComponentObj;
        public static AddUpdateDeleteComponents addUpdateDeleteComponentsObj;
        public static SkillComponents skillComponentObj;
        AddEditDeleteSkillComponents addEditDeleteSkillComponentsObj;
        CleanUp cleanUpObj;
        [OneTimeSetUp]
        public void ExtentReportsSetup()
        {
            try
            {

                extent = new ExtentReports();
                var htmlReporter = new ExtentHtmlReporter("F:\\Advance Task\\AdvanceTaskPart1\\AdvanceTaskNunit\\AdvanceTaskNunit\\ExtentReports\\");
                extent.AttachReporter(htmlReporter);
            }
            catch(Exception ex) 
            {
                Console.WriteLine($"Error setting up ExtentReports: {ex.Message}");

            }
           
            CleanUpData();
        }
        [SetUp]
        public void SetupActions()
        {
            
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:5000/");

            signPAgeObj = new SignPAge();
            signPAgeObj.ClickSignIn();

            loginStepObj = new LoginStep();
            loginStepObj.doLoginStep();

            test = extent.CreateTest(TestContext.CurrentContext.Test.Name);
        }
        [TearDown]
        public void TearDownActions()
        {
            if 
                (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Passed)
            {
                test.Log(Status.Pass, "Test Passed");
                
            }

            Close();

        }
        [OneTimeTearDown]
        public void ExtentReportsCleanup()
        {
            extent.Flush();
        }
        public void CleanUpData()
        {
            languageComponentObj = new LanguageComponent();
            cleanUpObj = new CleanUp();
            profileTabComponentObj.clickLangaugesTab();
           cleanUpObj.ClearLanguageExistingdata();

            skillComponentObj = new SkillComponents();
            profileTabComponentObj.clickSkillsTab();
            cleanUpObj.clearSkillExistingdata();
           
           
        }
        public void Close()
        {
            driver.Quit();
        }
    }
}
