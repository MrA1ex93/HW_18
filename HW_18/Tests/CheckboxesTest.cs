using HW_18.Factories;
using HW_18.Pages;

namespace HW_18.Tests
{
    internal class CheckboxesTest
    {
        [SetUp]
        public void Setup() => Checkboxes.OpenPage();

        [Test]
        public void CheckboxesTest1()
        {
            var checkBoxPage = new Checkboxes();

            var result1 = checkBoxPage.IsChecked(checkBoxPage.CheckedOne());
            Assert.That(result1, Is.False);

            checkBoxPage.ClickCheckBox1();

            var result2 = checkBoxPage.IsChecked(checkBoxPage.CheckedOne());
            Assert.That(result2, Is.True);

            var result3 = checkBoxPage.IsChecked(checkBoxPage.CheckedTwo());
            Assert.That(result3, Is.True);

            checkBoxPage.ClickCheckBox2();

            var result4 = checkBoxPage.IsChecked(checkBoxPage.CheckedTwo());
            Assert.That(result4, Is.False);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.QuitDriver();
        }
    }
}