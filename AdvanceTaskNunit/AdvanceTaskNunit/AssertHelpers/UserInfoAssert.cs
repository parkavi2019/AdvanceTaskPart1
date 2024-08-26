using AdvanceTaskNunit.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using RazorEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTaskNunit.AssertHelpers
{
    public class UserInfoAssert : CommonDriver
    {
        private static IWebElement messageBox => driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));

       static string expectedMessage1 = "Availability updated";

        public static void AddAvailabilityAssert(string avilability)
        {
            string actualMessage = messageBox.Text;
            Console.WriteLine(actualMessage);
            Assert.That(actualMessage, Is.EqualTo(expectedMessage1));

        }
        public static void AddHoursAssert(string hours)
        {
            string actualMessage = messageBox.Text;
            Console.WriteLine(actualMessage);
            Assert.That(actualMessage, Is.EqualTo(expectedMessage1));

        }
        public static void AddEarnTargetAssert(string earntarget)
        {
            string actualMessage = messageBox.Text;
            Console.WriteLine(actualMessage);
            Assert.That(actualMessage, Is.EqualTo(expectedMessage1));

        }
    }
}
