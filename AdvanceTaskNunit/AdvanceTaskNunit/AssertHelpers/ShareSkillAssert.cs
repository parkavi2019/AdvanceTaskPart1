using AdvanceTaskNunit.Test_Model;
using AdvanceTaskNunit.Utilities;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AdvanceTaskNunit.AssertHelpers
{
    public class ShareSkillAssert : CommonDriver
    {
       private static IWebElement SkillTitle => driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[3]"));
      
        public static void AddShareSkillAssert(ShareSkillTestModel addShareSkill)
        {
            List<ShareSkillTestModel> AddShareSkillfile = JsonHelper.ReadTestDataFromJson<ShareSkillTestModel>("F:\\Advance Task\\AdvanceTaskPart1\\AdvanceTaskNunit\\AdvanceTaskNunit\\JsonFile\\AddShareSkillfile.json");
            Thread.Sleep(2000);
             string actualSkillTitle = SkillTitle.Text;
            
            string expectedTitle= addShareSkill.Title;
            
          Assert.That(expectedTitle, Is.EqualTo(actualSkillTitle), "Service Listing Added successfully.");
            Console.WriteLine("Skill Title: {actualSkillTitle} has been added sucessfully");
        }
    }
}
