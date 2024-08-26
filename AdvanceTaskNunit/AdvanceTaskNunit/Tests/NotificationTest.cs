using AdvanceTaskNunit.Components;
using AdvanceTaskNunit.Steps;
using AdvanceTaskNunit.Utilities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTaskNunit.Tests
{
    [TestFixture]
    public class NotificationTest : CommonDriver
    {
        ProfileTabComponent profileTabComponentObj;
        NotificationStep notificationStepObj;
        public NotificationTest()
        {
            profileTabComponentObj = new ProfileTabComponent();
            notificationStepObj = new NotificationStep();
        }
        [Test, Order(1)]
        public void TestSelectAll()
        {
            profileTabComponentObj.clickDashboardTab();
            notificationStepObj.SelectNotification();
        }
         [Test, Order(2)]
         public void TestUnSelect()
         {
             profileTabComponentObj.clickDashboardTab();
             notificationStepObj.UnSelectNotification();
         }
         [Test, Order(3)]
         public void TestMarkRead()
         {
             profileTabComponentObj.clickDashboardTab();
             notificationStepObj.MarkselectionasRead();
         }
         [Test, Order(4)]
         public void TestMoreNotification()
         {
             profileTabComponentObj.clickDashboardTab();
             notificationStepObj.LoadmoreNotification();
         }
        [Test, Order(5)]
        public void TestShowLes()
        {
            profileTabComponentObj.clickDashboardTab();
            notificationStepObj.ShowLessNotification();
        }
        [Test, Order(6)]
        public void TestDelete()
        {
            profileTabComponentObj.clickDashboardTab();
            notificationStepObj.deleteNotification();
        }
    }
}
