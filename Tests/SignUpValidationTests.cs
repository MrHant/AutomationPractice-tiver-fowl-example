namespace AutomationPractice.Tests
{
    using Elements.UserManagement;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Tiver.Fowl.Core.Attributes;
    using Tiver.Fowl.ViewBase.Behaviors.Extensions;
    using Views;
    using Views.UserManagement;

    [TestClass]
    [WebDriverTest]
    public class SignUpValidationTests : BaseTestForMsTest
    {
        [TestMethod]
        public void SignInPage_InvalidEmail()
        {
            WebsiteHeaderMenu.SignInLink.Click();
            SignInPage.EmailField.Type("invalid_email");
            SignInPage.CreateAnAccountButton.Click();
            Assert.IsTrue(SignInPage.EmailField.ValidationFailed());
            SignInPage.CreateAnAccountErrorMessages.AssertErrorMessages(new []{"Invalid email address."});
        }
    }
}
