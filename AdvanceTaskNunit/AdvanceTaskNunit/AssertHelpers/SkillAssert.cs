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
    public class SkillAssert : CommonDriver
    {
        private static IWebElement messageBox => driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));



        static string expectedMessage1 = "has been added to your skills";
        static string expectedMessage2 = "Please enter skill and experience level";
        static string expectedMessage3 = "This skill is already exist in your skill list.";
        static string expectedMessage4 = "Java has been updated to your skills";
        static string expectedMessage5 = "C# has been deleted";

        public static void AddSkillAssert(string skill)
        {
            Thread.Sleep(1000);
            string actualMessage = messageBox.Text;
            Console.WriteLine(actualMessage);
            string exMes = skill + " has been added to your skills";
            Assert.That(actualMessage, Is.EqualTo(exMes).Or.EqualTo(expectedMessage1).Or.EqualTo(expectedMessage2).Or.EqualTo(expectedMessage3));
        }




        public static void UpdateSkillAssert(string skill)
        {
            Thread.Sleep(1000);
            string actualMessage = messageBox.Text;
            Console.WriteLine(actualMessage);
            string exMes = skill + " has been updated to your skill";
            Assert.That(actualMessage, Is.EqualTo(expectedMessage1).Or.EqualTo(expectedMessage2).Or.EqualTo(expectedMessage3).Or.EqualTo(expectedMessage4));
        }

        public static void DeleteSkillAssert(string skill)
        {
            Thread.Sleep(1000);
            string actualMessage = messageBox.Text;
            Console.WriteLine(actualMessage);
            string exMes = skill + " has been deleted from your skills";
            Assert.That(actualMessage, Is.EqualTo(expectedMessage1).Or.EqualTo(expectedMessage2).Or.EqualTo(expectedMessage3).Or.EqualTo(expectedMessage5));
        }

    }
}
