using AdvanceTaskNunit.Test_Model;
using AdvanceTaskNunit.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTaskNunit.AssertHelpers
{
  public class  SearchSkillAssert : CommonDriver
    {
        private static IWebElement categoriesCheck => driver.FindElement(By.XPath("//*[@id=\"service-detail-section\"]/div[2]/div/div[2]/div[1]/div[1]/div[2]/div[2]/div/div/div[2]/div/div[1]/div/div[2]"));
        private static IWebElement searchcategories => driver.FindElement(By.XPath("//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[2]/div/div[2]/div/div/div[1]/div[1]"));
       
        private static IWebElement subCategories => driver.FindElement(By.XPath("//*[@id=\"service-detail-section\"]/div[2]/div/div[2]/div[1]/div[1]/div[2]/div[2]/div/div/div[2]/div/div[2]/div/div[2]"));
      
        private static IWebElement filterCategories => driver.FindElement(By.XPath("//*[@id=\"service-detail-section\"]/div[2]/div/div[2]/div[1]/div[1]/div[2]/div[2]/div/div/div[3]/div/div[3]/div/div[2]"));
        public static void CategoriesSkillAssert(string categories)
        {
            Thread.Sleep(2000);
            searchcategories.Click();
            Thread.Sleep(2000);
            string actualSearchTitle = categoriesCheck.Text;

         

            Assert.That( actualSearchTitle ,Is.EqualTo(categories) );
            Console.WriteLine("Categories: "+actualSearchTitle);
        }
        public static void SubCategoriesSkillAssert(string Subcategory)
        {

            Thread.Sleep(2000);
            searchcategories.Click();
            Thread.Sleep(2000);
            string actualSearchTitle = subCategories.Text;

            

            Assert.That(actualSearchTitle, Is.EqualTo(Subcategory));
            Console.WriteLine("SubCategories: " + actualSearchTitle);
        }
         public static void FilterCategoriesAssert(string filter)
         {
             Thread.Sleep(2000);
             searchcategories.Click();
             Thread.Sleep(2000);
             string actualLocationType = filterCategories.Text;



             Assert.That(actualLocationType, Is.EqualTo(filter));
             Console.WriteLine("FilterCategories: " + actualLocationType);
         }
       


    }
}
