using HW_18.Factories;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace HW_18.Pages
{
    internal class Checkboxes
    {
        public static void OpenPage()
        {
            Driver.GetDriver().Navigate().GoToUrl("http://the-internet.herokuapp.com/checkboxes");
        }
        public IWebElement firstCheckbox = Driver.GetWait(10).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[text()=' checkbox 1']//input[1]")));
        public IWebElement secondCheckbox = Driver.GetWait(10).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[text()=' checkbox 1']//input[2]")));

        public void ClickCheckBox1() => firstCheckbox.Click();
        public void ClickCheckBox2() => secondCheckbox.Click();

        public bool IsChecked(string Attribute)
        {
            if (Attribute == "null")
            {
                return false;
            }
            else if (Attribute == "true")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string CheckedOne() => firstCheckbox.GetAttribute("checked");
        public string CheckedTwo() => secondCheckbox.GetAttribute("checked");
    }
}