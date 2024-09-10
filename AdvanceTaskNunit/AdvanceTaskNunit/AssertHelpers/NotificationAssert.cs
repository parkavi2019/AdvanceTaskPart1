using AdvanceTaskNunit.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTaskNunit.AssertHelpers
{
    public class NotificationAssert : CommonDriver
    {
        private static IWebElement messageBox => driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));

        static string expectedMessage1 = "Notification updated";
        
        public static void AddNotificationAssert()
        {
            string actualMessage = messageBox.Text;
            Console.WriteLine(actualMessage);
            Assert.That(actualMessage, Is.EqualTo(expectedMessage1));

        }
       


    }
}
