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
    public class SkillTest : CommonDriver
    {
        ProfileTabComponent profileTabComponentObj;
        SkillStep skillStepObj;
        



#pragma warning disable

        public SkillTest()
        {
           
            profileTabComponentObj = new ProfileTabComponent();
            skillStepObj = new SkillStep();
          

        }

        [Test, Order(1),Description("Verify that a Skill and its level can be added")]

        public void TestAddSkill()
        {
            Thread.Sleep(1000);
            profileTabComponentObj.clickSkillsTab();
           
            skillStepObj.AddSkill();

        }

        [Test, Order(2)]
        public void TestEditSkill()
        {
            profileTabComponentObj.clickSkillsTab();
            
            
            skillStepObj.AddSkill();
            skillStepObj.updateSkill();
            
        }


        
        [Test, Order(3)]

        public void TestDeleteLanguage()
        {
            profileTabComponentObj.clickSkillsTab();
           
            skillStepObj.AddSkill();
            skillStepObj.deleteSkill();

       

         }
       
        
    }
}
