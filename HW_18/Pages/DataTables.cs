using HW_18.Factories;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace HW_18.Pages
{
    internal class DataTables
    {
        public static void OpenPage()
        {
            Driver.GetDriver().Navigate().GoToUrl("https://the-internet.herokuapp.com/tables");
        }

        private const string _element1 = "Smith";
        private const string _element2 = "Frank";
        private const string _element3 = "jdoe@hotmail.com";
        private const string _element4 = "$50.00";
        private const string _element5 = "http://www.frank.com";
        private const string _element6 = "edit delete";

        public string Element1() => Driver.GetWait(5).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id ='table1']//tr[1]//td[1]"))).Text;
        public string Element2() => Driver.GetWait(5).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id ='table1']//tr[2]//td[2]"))).Text;
        public string Element3() => Driver.GetWait(5).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id ='table2']//tr[3]//td[3]"))).Text;
        public string Element4() => Driver.GetWait(5).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id ='table2']//tr[4]//td[4]"))).Text;
        public string Element5() => Driver.GetWait(5).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id ='table2']//tr[2]//td[5]"))).Text;
        public string Element6() => Driver.GetWait(5).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id ='table2']//tr[1]//td[6]"))).Text;

        public bool CompareElement(int a)
        {
            switch (a)
            {
                case 1:
                    return Element1().Equals(_element1);
                case 2:
                    return Element2().Equals(_element2);
                case 3:
                    return Element3().Equals(_element3);
                case 4:
                    return Element4().Equals(_element4);
                case 5:
                    return Element5().Equals(_element5);
                case 6:
                    return Element6().Equals(_element6);
                default:
                    return false;
            }
        }
    }
}