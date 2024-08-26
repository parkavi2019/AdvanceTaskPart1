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
    public class SearchSkillStep : CommonDriver
    {
        ProfileTabComponent profileTabComponentObj;
        SearchSkillComponent searchSkillComponentObj;
        SearchSkillAssert searchSkillAssertObj;

        public SearchSkillStep()
        {
            profileTabComponentObj = new ProfileTabComponent();
            searchSkillComponentObj = new SearchSkillComponent();
           searchSkillAssertObj = new SearchSkillAssert();
        }

       
        public void categories()
        {
            List<SearchSkillTestModel>CategoriesSearch = JsonHelper.ReadTestDataFromJson<SearchSkillTestModel>("F:\\Advance Task\\AdvanceTaskPart1\\AdvanceTaskNunit\\AdvanceTaskNunit\\JsonFile\\CategoriesSearch.json");
            foreach (SearchSkillTestModel model in CategoriesSearch)
            {
                searchSkillComponentObj.AddCategoriesSkill(model);
                SearchSkillAssert.CategoriesSkillAssert(model.Categories);

            }
        }
        public void SubCategories()
        {
            List<SearchSkillTestModel> SubCategoriesSearch = JsonHelper.ReadTestDataFromJson<SearchSkillTestModel>("F:\\Advance Task\\AdvanceTaskPart1\\AdvanceTaskNunit\\AdvanceTaskNunit\\JsonFile\\SubCategoriesSearch.json");
            foreach (SearchSkillTestModel model in SubCategoriesSearch)
            {
                searchSkillComponentObj.AddSubCategories(model);
                SearchSkillAssert.SubCategoriesSkillAssert(model.SubCategories);
            }
        }
        public void FilterCategories()
        {
            List<SearchSkillTestModel> FiltersSearch = JsonHelper.ReadTestDataFromJson<SearchSkillTestModel>("F:\\Advance Task\\AdvanceTaskPart1\\AdvanceTaskNunit\\AdvanceTaskNunit\\JsonFile\\FiltersSearch.json");
            foreach (SearchSkillTestModel model in FiltersSearch)
            {
                searchSkillComponentObj.FilterSearch(model);
                SearchSkillAssert.FilterCategoriesAssert(model.Filter);
            }
        }
    }
}
