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
    public class SearchSkillTest : CommonDriver
    {
        ProfileTabComponent profileTabComponentObj;
        SearchSkillStep searchSkillStepObj;

        public SearchSkillTest()
        {
            profileTabComponentObj = new ProfileTabComponent();
            searchSkillStepObj = new SearchSkillStep();
        }
        
      
        [Test, Order(1)]
        public void TestCategories()
        {
            profileTabComponentObj.clickSearchIcon();
            searchSkillStepObj.categories();
        }
        [Test, Order(2)]
        public void TestSubCategories()
        {
            profileTabComponentObj.clickSearchIcon();
            searchSkillStepObj.SubCategories();
        }
        [Test, Order(3)]
         public void TestFilter()
         {
             profileTabComponentObj.clickSearchIcon();
             searchSkillStepObj.FilterCategories();

         }

       
    }
}
