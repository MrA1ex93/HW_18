using HW_18.Factories;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace HW_18.Pages
{
    internal class DropdownList
    {
        public static void OpenPage()
        {
            Driver.GetDriver().Navigate().GoToUrl("https://the-internet.herokuapp.com/dropdown");
        }

        private static IWebElement dropdown = Driver.GetWait(10).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id ='dropdown']")));
        private static IWebElement option1 = Driver.GetWait(10).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id ='dropdown']/option[2]")));
        private static IWebElement option2 = Driver.GetWait(10).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id ='dropdown']/option[3]")));

        public void ClickDropdown() => dropdown.Click();
        public void ChooseOption1() => option1.Click();
        public void ChooseOption2() => option2.Click();

        public string GetAttributeOption1() => option1.GetAttribute("value");
        public string GetAttributeOption2() => option2.GetAttribute("value");
    }
}