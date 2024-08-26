using AdvanceTaskNunit.Components;
using AdvanceTaskNunit.Pages;
using AdvanceTaskNunit.Steps;
using AdvanceTaskNunit.Test_Model;
using AdvanceTaskNunit.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.DevTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTaskNunit.Tests
{
    [TestFixture]
    public class UserInfoTest : CommonDriver
    {
        ProfileTabComponent profileTabComponentObj;
        UserInfoStep userInfoStepObj;

        public UserInfoTest()
        {
            profileTabComponentObj = new ProfileTabComponent();
            userInfoStepObj = new UserInfoStep();
        }
        [Test, Order(1)]

        public void TestUserData()
        {
            userInfoStepObj.AddAvailabilityInfo();
        }
       

    }
}
