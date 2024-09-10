using AdvanceTaskNunit.Utilities;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using NUnit.Framework;
using OpenQA.Selenium;
using RazorEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTaskNunit.AssertHelpers
{
   public class LanguageAssert : CommonDriver
    {
       private static IWebElement messageBox => driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));



       static string expectedMessage1 = "has been added to your languages";
        static string expectedMessage2 = "Please enter language and level";
       static string expectedMessage3 = "This language is already exist in your language list.";
        static string expectedMessage4 = "English has been updated to your languages";
        static string expectedMessage5 = "Tamil has been deleted from your languages";
        
        public static void AddLanguageAssert(string language)
        {
            Thread.Sleep(1000);
            string actualMessage = messageBox.Text;
            Console.WriteLine(actualMessage);
            string exMes = language + " has been added to your languages";
            Assert.That(actualMessage, Is.EqualTo(exMes).Or.EqualTo(expectedMessage1).Or.EqualTo(expectedMessage2).Or.EqualTo(expectedMessage3));
        }

      
       

        public static void UpdateLanguageAssert( string language)
        {
            Thread.Sleep(1000);
            string actualMessage = messageBox.Text;
            Console.WriteLine(actualMessage);
            string exMes = language + " has been updated to your languages";
            Assert.That(actualMessage, Is.EqualTo(expectedMessage1).Or.EqualTo(expectedMessage2).Or.EqualTo(expectedMessage3).Or.EqualTo(expectedMessage4));
        }

        public static void DeleteAssert(string language)
        {
            Thread.Sleep(1000);
            string actualMessage = messageBox.Text;
            Console.WriteLine(actualMessage);
            string exMes = language + " has been deleted from your languages";
            Assert.That(actualMessage, Is.EqualTo(expectedMessage1).Or.EqualTo(expectedMessage2).Or.EqualTo(expectedMessage3).Or.EqualTo(expectedMessage5));
        }
       
    }
}
