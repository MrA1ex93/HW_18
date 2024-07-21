using HW_18.Factories;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace HW_18.Pages
{
    internal class Hovers
    {
        public static void OpenPage()
        {
            Driver.GetDriver().Navigate().GoToUrl("https://the-internet.herokuapp.com/hovers");
        }

        Actions action = new Actions(Driver.GetDriver());

        private const string _nameOfProfileOne = "name: user1";
        private const string _nameOfProfileTwo = "name: user2";
        private const string _nameOfProfileThree = "name: user3";

        public IWebElement profileOne = Driver.GetWait(5).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class ='example']//div[1]//img")));
        public IWebElement profileTwo = Driver.GetWait(5).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class ='example']//div[2]//img")));
        public IWebElement profileThree = Driver.GetWait(5).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class ='example']//div[3]//img")));

        public void HoverOnProfile(int a)
        {
            if (a == 1)
            {
                action.MoveToElement(profileOne).Perform();
            }
            else if (a == 2)
            {
                action.MoveToElement(profileTwo).Perform();
            }
            else if (a == 3)
            {
                action.MoveToElement(profileThree).Perform();
            }
        }

        public string GetUsername(int a)
        {
            switch (a)
            {
                case 1:
                    return Driver.GetWait(5).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class='example']//div[1]//div[1]//h5"))).Text;
                    break;
                case 2:
                    return Driver.GetWait(5).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class='example']//div[2]//div[1]//h5"))).Text;
                    break;
                case 3:
                    return Driver.GetWait(5).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class='example']//div[3]//div[1]//h5"))).Text;
                    break;
                default:
                    return "";
                    break;
            }
        }

        public bool CompareTheUsername(string username)
        {
            if (username.Equals(_nameOfProfileOne))
            {
                return true;
            }
            else if (username.Equals(_nameOfProfileTwo))
            {
                return true;
            }
            else if (username.Equals(_nameOfProfileThree))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ClickLink(int a)
        {
            if (a == 1)
            {
                Driver.GetWait(5).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class ='example']//div[1]//div//a"))).Click();
            }
            else if (a == 2)
            {
                Driver.GetWait(5).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class ='example']//div[2]//div//a"))).Click();
            }
            else if (a == 3)
            {
                Driver.GetWait(5).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class ='example']//div[3]//div//a"))).Click();
            }
        }

        public bool ErrorExists() => Driver.GetWait(5).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[text()='Not Found']"))).Displayed;
    }
}