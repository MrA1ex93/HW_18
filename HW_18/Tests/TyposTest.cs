using HW_18.Factories;
using HW_18.Pages;

namespace HW_18.Tests
{
    internal class TyposTest
    {

        [SetUp]
        public void Setup() => Typos.OpenPage();

        [Test]
        public void TyposTest1()
        {
            var typosPage = new Typos();

            var result1 = typosPage.CompareText(typosPage.StringOne());
            Assert.That(result1, Is.True);

            var result2 = typosPage.CompareText(typosPage.StringTwo());
            Assert.That(result2, Is.True);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.QuitDriver();
        }
    }
}