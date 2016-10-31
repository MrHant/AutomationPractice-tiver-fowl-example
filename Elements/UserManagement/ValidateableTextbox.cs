namespace AutomationPractice.Elements.UserManagement
{
    using Tiver.Fowl.ViewBase;
    using Tiver.Fowl.ViewBase.Behaviors.Extensions;

    public class ValidateableTextbox : Textbox
    {
        public ValidateableTextbox(string locator)
            : base(locator)
        {
        }

        public ValidateableTextbox(string locator, string name)
            : base(locator, name)
        {
        }

        public bool ValidationFailed()
        {
            return Validate("form-error");
        }

        public bool ValidationSucceed()
        {
            return Validate("form-ok");
        }

        private bool Validate(string cssClass)
        {
            var temp = new Element($"{this.Locator}/ancestor::div[contains(@class, '{cssClass}')]");
            return temp.Displayed();
        }
    }
}
