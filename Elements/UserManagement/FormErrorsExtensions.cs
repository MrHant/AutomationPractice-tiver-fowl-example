namespace AutomationPractice.Elements.UserManagement
{
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Tiver.Fowl.Logging;

    public static class FormErrorsExtensions
    {
        public static void AssertErrorMessages(this FormErrors element, IEnumerable<string> expectedErrorMessages)
        {
            element.LogAction("Assert Error messages");
            var errorMessages = element.GetErrorMessages();
            var sortedErrorMessages = errorMessages.ToList();
            sortedErrorMessages.Sort();
            var sortedExpectedErrorMessages = expectedErrorMessages.ToList();
            sortedExpectedErrorMessages.Sort();
            Assert.IsTrue(sortedExpectedErrorMessages.SequenceEqual(sortedErrorMessages));
        }
    }
}
