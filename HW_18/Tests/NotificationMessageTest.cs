using HW_18.Factories;
using HW_18.Pages;
using OpenQA.Selenium.Interactions;

namespace HW_18.Tests
{
    internal class NotificationMessageTest
    {
        [SetUp]
        public void Setup() => NotificationMessage.OpenPage();
        Actions action = new Actions(Driver.GetDriver());

        [Test]
        public void NotificationsTest1()
        {
            var notificationsPage = new NotificationMessage();

            notificationsPage.ClickLink();
            Assert.That(notificationsPage.NotificationExists(), Is.True);

            var result3 = notificationsPage.CompareTheText(notificationsPage.GetNotificationText());
            Assert.That(result3, Is.True);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.QuitDriver();
        }
    }
}