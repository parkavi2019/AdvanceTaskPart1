using AdvanceTaskNunit.AssertHelpers;
using AdvanceTaskNunit.Components;
using AdvanceTaskNunit.Test_Model;
using AdvanceTaskNunit.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTaskNunit.Steps
{
    public class UserInfoStep : CommonDriver
    {
        
        UserInfoAssert userInfoAssertObj;
        UserInfoComponents userInfoComponentsObj;

        public UserInfoStep()
        {
            
            userInfoAssertObj = new UserInfoAssert();
            userInfoComponentsObj = new UserInfoComponents();

        }

        public void AddAvailabilityInfo()
        {
            List<UserInfoTestModel> AddUserInfofile = JsonHelper.ReadTestDataFromJson<UserInfoTestModel>("F:\\Advance Task\\AdvanceTaskPart1\\AdvanceTaskNunit\\AdvanceTaskNunit\\JsonFile\\AddUserInfofile.json");
            foreach (UserInfoTestModel model in AddUserInfofile)
            {
                
               
               
                userInfoComponentsObj.addUserinfo(model);
                UserInfoAssert.AddAvailabilityAssert(model.Availability);



            }
            

        }
       

    }
}
