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
    public class ShareSkillStep : CommonDriver
    {
        ProfileTabComponent ProfileTabComponentObj;
        ShareSkillComponent ShareSkillComponentObj;
        ShareSkillAssert ShareSkillAssertObj;

        public ShareSkillStep()
        {
            ProfileTabComponentObj = new ProfileTabComponent();
            ShareSkillAssertObj = new ShareSkillAssert();
            ShareSkillComponentObj = new ShareSkillComponent();
        }

        public void AddShareSkill()
        {
            List<ShareSkillTestModel> AddShareSkillfile = JsonHelper.ReadTestDataFromJson<ShareSkillTestModel>("F:\\Advance Task\\AdvanceTaskPart1\\AdvanceTaskNunit\\AdvanceTaskNunit\\JsonFile\\AddShareSkillfile.json");
            foreach (ShareSkillTestModel model in AddShareSkillfile)
            {



                ShareSkillComponentObj.addShareSkill(model);
                ShareSkillAssert.AddShareSkillAssert(model);



            }
        }
    }
}
