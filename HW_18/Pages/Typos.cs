using HW_18.Factories;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace HW_18.Pages
{
    internal class Typos
    {
        public static void OpenPage()
        {
            Driver.GetDriver().Navigate().GoToUrl("https://the-internet.herokuapp.com/typos");
        }

        private const string referenceStringOne = "This example demonstrates a typo being introduced. It does it randomly on each page load.";
        private const string referenceStringTwo = "Sometimes you'll see a typo, other times you won't.";

        public string StringOne() => Driver.GetWait(5).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id ='content']//p[1]"))).Text;
        public string StringTwo() => Driver.GetWait(5).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id ='content']//p[2]"))).Text;

        public bool CompareText(string a)
        {
            if (a == StringOne())
            {
                return StringOne().Equals(referenceStringOne);
            }
            else if (a == StringTwo())
            {
                return StringTwo().Equals(referenceStringTwo);
            }
            else
            {
                return false;
            }
        }
    }
}