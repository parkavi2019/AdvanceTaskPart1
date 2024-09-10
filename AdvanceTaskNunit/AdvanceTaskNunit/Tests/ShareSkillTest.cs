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
    public class ShareSkillTest : CommonDriver
    {
        ProfileTabComponent profileTabComponentObj;
        ShareSkillStep shareSkillStepObj;

        public ShareSkillTest()
        {

            profileTabComponentObj = new ProfileTabComponent();
            shareSkillStepObj = new ShareSkillStep();
            

        }
        [Test]
        public void TestShareSkill()
        {
            shareSkillStepObj.AddShareSkill();
        }
    }
}
