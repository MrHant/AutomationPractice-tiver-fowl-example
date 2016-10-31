namespace AutomationPractice.Elements.UserManagement
{
    using System.Collections.Generic;
    using System.Linq;
    using OpenQA.Selenium;
    using Tiver.Fowl.Logging;
    using Tiver.Fowl.ViewBase;

    public class FormErrors : ILoggableElement
    {
        /// <param name="locator">Locator of div with classes "alert alert-danger"</param>
        public FormErrors(string locator)
        {
            Locator = locator;
            Name = "Unnamed";
        }

        /// <param name="locator">Locator of div with classes "alert alert-danger"</param>
        public FormErrors(string locator, string name)
        {
            Locator = locator;
            Name = name;
        }

        public IEnumerable<string> GetErrorMessages()
        {
            this.LogAction("Get Error messages");
            var list = new Element($"{Locator}/ol");
            return list.Process(el => el.FindElements(By.XPath("./li")).Select(e => e.Text));
        }

        public string GetTitle()
        {
            this.LogAction("Get Error messages title");
            return new Element($"{Locator}/p").Process(el => el.Text);
        }

        private string Locator
        {
            get;
        }

        public string Name
        {
            get;
        }
    }
}
