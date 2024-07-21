using HW_18.Factories;
using HW_18.Pages;

namespace HW_18.Tests
{
    internal class DataTablesTest
    {
        [SetUp]
        public void Setup() => DataTables.OpenPage();

        [Test]
        public void SortTableTest1()
        {
            var sortTablePage = new DataTables();

            var result1 = sortTablePage.CompareElement(1);
            Assert.That(result1, Is.True);

            var result2 = sortTablePage.CompareElement(2);
            Assert.That(result2, Is.True);

            var result3 = sortTablePage.CompareElement(3);
            Assert.That(result3, Is.True);

            var result4 = sortTablePage.CompareElement(4);
            Assert.That(result4, Is.True);

            var result5 = sortTablePage.CompareElement(5);
            Assert.That(result5, Is.True);

            var result6 = sortTablePage.CompareElement(6);
            Assert.That(result6, Is.True);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.QuitDriver();
        }
    }
}