using HW_18.Factories;
using HW_18.Pages;

namespace HW_18.Tests
{
    internal class InputsTest
    {
        [SetUp]
        public void Setup() => Inputs.OpenPage();

        [Test]
        public void InputsTest1()
        {
            var inputsPage = new Inputs();

            inputsPage.ClickArrowUp();
            inputsPage.ClickArrowUp();
            var result1 = inputsPage.GetFieldValue().Equals("2");
            Assert.That(result1, Is.True);

            inputsPage.ClickArrowDown();
            inputsPage.ClickArrowDown();
            inputsPage.ClickArrowDown();
            var result2 = inputsPage.GetFieldValue().Equals("-1");
            Assert.That(result2, Is.True);

            inputsPage.ClearField();
            inputsPage.EnterIntoTheField("666");
            var result4 = inputsPage.GetFieldValue().Equals("666");
            Assert.That(result4, Is.True);

            inputsPage.ClearField();
            inputsPage.EnterIntoTheField("a");
            var result5 = inputsPage.GetFieldValue().Equals("");
            Assert.That(result5, Is.True);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.QuitDriver();
        }
    }
}