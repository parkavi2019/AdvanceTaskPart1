using AdvanceTaskNunit.AssertHelpers;
using AdvanceTaskNunit.Components;
using AdvanceTaskNunit.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTaskNunit.Steps
{
    public class NotificationStep : CommonDriver
    {
        ProfileTabComponent profileTabComponentObj;
        NotificationComponent notificationComponentObj;
        NotificationAssert notificationAssertObj;

        public NotificationStep()
        {
            profileTabComponentObj = new ProfileTabComponent();
            notificationComponentObj = new NotificationComponent();
            notificationAssertObj = new NotificationAssert();
        }
        public void SelectNotification()
        {


            notificationComponentObj.SelectAll();
            

        }
       public void UnSelectNotification()
        {
            notificationComponentObj.Unselect();
        }
        public void MarkselectionasRead()
        {
            notificationComponentObj.MarkselectionasRead();
            NotificationAssert.AddNotificationAssert();
        }
        public void LoadmoreNotification()
        {
            notificationComponentObj.LoadMore();
        }
        public void ShowLessNotification()
        {
            notificationComponentObj.ShowLess();

        }
       public void deleteNotification()
        {
            notificationComponentObj.DeleteNotification();
            NotificationAssert.AddNotificationAssert();
        }
    }
}
