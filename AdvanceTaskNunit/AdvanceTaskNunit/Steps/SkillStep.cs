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
   public class SkillStep : CommonDriver
    {
        SkillComponents skillComponentObj;
        AddEditDeleteSkillComponents addEditDeleteSkillComponentObj;
        SkillAssert SkillAssertObj;
        ProfileTabComponent profileTabComponentObj;

        public SkillStep()
        {
            skillComponentObj = new SkillComponents();
            addEditDeleteSkillComponentObj = new AddEditDeleteSkillComponents();
            SkillAssertObj = new SkillAssert();
            profileTabComponentObj = new ProfileTabComponent();
        }
        public void AddSkill()
        {
            List<SkillTestModel> AddSkillfile = JsonHelper.ReadTestDataFromJson<SkillTestModel>("F:\\Advance Task\\AdvanceTaskPart1\\AdvanceTaskNunit\\AdvanceTaskNunit\\JsonFile\\AddSkillfile.json");
            foreach (SkillTestModel model in AddSkillfile)
            {
                profileTabComponentObj.clickSkillsTab();
                skillComponentObj.clickAddSkill();
                
                addEditDeleteSkillComponentObj.addNewSkill(model);
                SkillAssert.AddSkillAssert(model.AddSkill);



            }


        }
        public void updateSkill()
        {
            List<SkillTestModel> EditSkillfile = JsonHelper.ReadTestDataFromJson<SkillTestModel>("F:\\Advance Task\\AdvanceTaskPart1\\AdvanceTaskNunit\\AdvanceTaskNunit\\JsonFile\\EditSkillfile.json");

            foreach (SkillTestModel model in EditSkillfile)
            {
                profileTabComponentObj.clickSkillsTab();
                skillComponentObj.clickAddSkill();
                skillComponentObj.clickUpdateSkill();
                addEditDeleteSkillComponentObj.updateSkill(model);
                SkillAssert.UpdateSkillAssert(model.AddSkill);


            }
        }
        public void deleteSkill()
        {
            List<SkillTestModel> DeleteLanguagefile = JsonHelper.ReadTestDataFromJson<SkillTestModel>("F:\\Advance Task\\AdvanceTaskPart1\\AdvanceTaskNunit\\AdvanceTaskNunit\\JsonFile\\DeleteSkillfile.json");
            foreach (SkillTestModel model in DeleteLanguagefile)
            {
                profileTabComponentObj.clickSkillsTab();
                skillComponentObj.clickAddSkill();

                
                skillComponentObj.clickDeleteSkill();
                addEditDeleteSkillComponentObj.DeleteSkill(model);
                
                SkillAssert.DeleteSkillAssert(model.AddSkill);
            }
        }
    }
}
