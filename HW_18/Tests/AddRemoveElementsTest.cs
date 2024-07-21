using HW_18.Factories;
using HW_18.Pages;
using OpenQA.Selenium;

namespace HW_18.Tests
{
    internal class AddRemoveElementsTest
    {
        [SetUp]
        public void Setup() => AddRemoveElements.OpenPage();

        [Test]
        public void AddRemoveTest1()
        {
            var addRemovePage = new AddRemoveElements();
            addRemovePage.AddElement();
            addRemovePage.AddElement();
            addRemovePage.DeleteElement();
            var visible1 = addRemovePage.IsFirstElementVisible();
            Assert.That(visible1, Is.True);

            var visible2 = false;
            try
            {
                visible2 = addRemovePage.IsSecondElementVisible();
            }
            catch (WebDriverTimeoutException)
            {
                visible2 = false;
            }
            Assert.That(visible2, Is.False);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.QuitDriver();
        }
    }
}