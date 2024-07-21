using HW_18.Factories;
using HW_18.Pages;

namespace HW_18.Tests
{
    internal class DropdownListTest
    {
        [SetUp]
        public void Setup() => DropdownList.OpenPage();

        [Test]
        public void DropdownTest1()
        {
            var dropdownList = new DropdownList();

            dropdownList.ClickDropdown();
            dropdownList.ChooseOption1();

            var result = dropdownList.GetAttributeOption1().Equals("1");
            Assert.That(result, Is.True);

            dropdownList.ClickDropdown();
            dropdownList.ChooseOption2();

            var result1 = dropdownList.GetAttributeOption2().Equals("2");
            Assert.That(result1, Is.True);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.QuitDriver();
        }
    }
}