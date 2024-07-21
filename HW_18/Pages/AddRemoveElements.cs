using HW_18.Factories;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace HW_18.Pages
{
    internal class AddRemoveElements
    {
        public static void OpenPage()
        {
            Driver.GetDriver().Navigate().GoToUrl("http://the-internet.herokuapp.com/add_remove_elements/");
        }

        public void AddElement() => Driver.GetWait(10).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[text()='Add Element']"))).Click();
        public void DeleteElement() => Driver.GetWait(10).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[text()='Delete']"))).Click();
        public bool IsFirstElementVisible() => Driver.GetWait(5).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='elements']/button[1]"))).Displayed;
        public bool IsSecondElementVisible() => Driver.GetWait(5).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='elements']/button[2]"))).Displayed;
    }
}