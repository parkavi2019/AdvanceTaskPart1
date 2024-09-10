using AdvanceTaskNunit.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTaskNunit.Components
{
    public class NotificationComponent : CommonDriver
    {
#pragma warning disable
        ProfileTabComponent profileTabComponentObj;
        private static IWebElement selectArrow;
        private static IWebElement unselecticon;
        private static IWebElement markselectionasRead;
        private static IWebElement loadMore;
        private  static IWebElement showLess;
        private static IWebElement deleteicon;
        private static IWebElement checkBox;
      
        private IWebElement messageBox;
        private string Message = "";
        public NotificationComponent()
        {
            profileTabComponentObj = new ProfileTabComponent();
        }

       

        public void renderSelectNotification()
         {
             try
             {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                selectArrow = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[1]/div[1]")));
            

             
                 

             }
             catch (Exception ex)
             {
                 Console.WriteLine(ex);
             }
         }
        public void SelectAll()
        {
            renderSelectNotification();


            selectArrow.Click();
          


        }

          public void renderUnselect()
          {
              try
              {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                unselecticon = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[1]/div[2]")));
                        
              }
              catch (Exception ex)
              {
                  Console.WriteLine(ex);
              }
          }
          public void Unselect()
          {

            renderSelectNotification();

          
            selectArrow.Click();

            renderUnselect();
           
            unselecticon.Click();
            
          }
        public void renderMarkselect()
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                markselectionasRead = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[1]/div[4]")));
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void MarkselectionasRead()
        {
            renderCheckbox();

            checkBox.Click();

            
            renderMarkselect();


             
            markselectionasRead.Click();
        }
        public void renderLoadMore()
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                loadMore = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[2]/span/span/div/div[6]/div/center/a")));
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void LoadMore()
        {
            renderLoadMore();


            Thread.Sleep(1000);
            loadMore.Click();
            
        }
        public void renderShowLess()
        {
            try
            {
                showLess = driver.FindElement(By.XPath("//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[2]/span/span/div/div[8]/div[1]/center/a"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void ShowLess()
        {
            renderLoadMore();
            
            loadMore.Click();
            renderShowLess();
            
            showLess.Click();
        }
        public void renderCheckbox()
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                checkBox = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[2]/span/span/div/div[1]/div/div/div[3]/input")));


                
            }
            catch(Exception ex)
            {

            Console.WriteLine(ex); 
            }
        }
        public void CheckBox()
        {
            checkBox.Click();
        }
        public void renderDeleteNotification()
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                deleteicon = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[1]/div[3]")));
                

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void DeleteNotification()
        {
            renderCheckbox();

           
           
            
            checkBox.Click();
            renderDeleteNotification();
            
            deleteicon.Click();

            Thread.Sleep(3000);
        }
    }
}
