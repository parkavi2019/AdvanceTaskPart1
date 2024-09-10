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
    public class LanguageStep : CommonDriver

    {
        LanguageComponent languageComponentObj;
        AddUpdateDeleteComponents addUpdateDeleteLanguageComponentObj;
        LanguageAssert LanguageAssertObj;
        ProfileTabComponent profileTabComponentObj;

        public LanguageStep()
        {
            languageComponentObj = new LanguageComponent();
            addUpdateDeleteLanguageComponentObj = new AddUpdateDeleteComponents();
            LanguageAssertObj = new LanguageAssert();
            profileTabComponentObj = new ProfileTabComponent();
        }
        public void AddLanguage()
        {
            List<LanguageTestModel> AddLanguagefile = JsonHelper.ReadTestDataFromJson<LanguageTestModel>("F:\\Advance Task\\AdvanceTaskPart1\\AdvanceTaskNunit\\AdvanceTaskNunit\\JsonFile\\AddLanguagefile.json");
            foreach (LanguageTestModel model in AddLanguagefile)
            {
                    
                    languageComponentObj.clickAddLanguage();
                    addUpdateDeleteLanguageComponentObj.addNewLanguage(model);
                LanguageAssert.AddLanguageAssert(model.AddLanguage);
                


            }
            

        }
        public void updateLanguage()
        {
            List<LanguageTestModel> EditLanguagefile = JsonHelper.ReadTestDataFromJson<LanguageTestModel>("F:\\Advance Task\\AdvanceTaskPart1\\AdvanceTaskNunit\\AdvanceTaskNunit\\JsonFile\\EditLanguagefile.json");

            foreach (LanguageTestModel model in EditLanguagefile)
            {
                languageComponentObj.clickAddLanguage();
                languageComponentObj.clickUpdateLanguage();
                addUpdateDeleteLanguageComponentObj.updateLanguage(model);
                LanguageAssert.UpdateLanguageAssert(model.AddLanguage);
                
               
            }
        }
        public void deleteLanguage()
        {
            List<LanguageTestModel> DeleteLanguagefile = JsonHelper.ReadTestDataFromJson<LanguageTestModel>("F:\\Advance Task\\AdvanceTaskPart1\\AdvanceTaskNunit\\AdvanceTaskNunit\\JsonFile\\DeleteLanguagefile.json");
            foreach (LanguageTestModel model in DeleteLanguagefile)
            {
                languageComponentObj.clickAddLanguage();
                languageComponentObj.clickDeleteLanguage();
                addUpdateDeleteLanguageComponentObj.DeleteLanguage(model);
               LanguageAssert.DeleteAssert(model.AddLanguage);
            }
        }
    }
}
