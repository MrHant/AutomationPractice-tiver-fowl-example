namespace AutomationPractice.Views
{
    using Tiver.Fowl.ViewBase;

    public class WebsiteHeaderMenu : View
    {
        public static readonly Element SignInLink = new Element("//a[@class='login']", "Sign In Link");
    }
}
