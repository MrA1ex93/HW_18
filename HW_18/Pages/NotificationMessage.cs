using HW_18.Factories;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace HW_18.Pages
{
    internal class NotificationMessage
    {
        public static void OpenPage()
        {
            Driver.GetDriver().Navigate().GoToUrl("https://the-internet.herokuapp.com/notification_message_rendered");
        }

        private const string _actionSuccess = "Action successful\r\n×";
        private const string _actionNotSuccess = "\r\n            Action unsuccesful, please try again\r\n            ";

        public void ClickLink() => Driver.GetWait(5).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[text()='Click here']"))).Click();
        public bool NotificationExists() => Driver.GetWait(10).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='flash']"))).Displayed;
        public string GetNotificationText() => Driver.GetWait(5).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='flash']"))).Text;

        public bool CompareTheText(string a)
        {
            var result1 = a.Equals(_actionSuccess);
            var result2 = a.Equals(_actionNotSuccess);

            if (result1 == true)
            {
                return true;
            }
            else if (result2 == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}