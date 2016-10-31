namespace AutomationPractice.Views.UserManagement
{
    using Elements;
    using Elements.UserManagement;
    using Tiver.Fowl.ViewBase;

    public class SignInPage : View
    {
        public static readonly ValidateableTextbox EmailField = new ValidateableTextbox("//input[@id='email_create']", "'Email address' Field");
        public static readonly Button CreateAnAccountButton = new Button("//button[@id='SubmitCreate']", "'Create an account' Button");
        public static readonly FormErrors CreateAnAccountErrorMessages = new FormErrors("//div[@id='create_account_error']", "'Create an account' Form error messages");
    }
}
