using System.Reflection;
using System.Resources;

namespace demo;

public partial class AboutPage : ContentPage
{
    public string app_version = "1.0.0";
    public string year = "2023";
    public AboutPage()
	{
		InitializeComponent();
        ResourceManager resourceManager = new ResourceManager("demo.Resources.Strings", Assembly.GetExecutingAssembly());
        Console.WriteLine("Test from RSs file: " + resourceManager.GetString("about"));
        AppVersion.Text = resourceManager.GetString("about_version") + " "+ app_version;
        CopyRight.Text = year + " " + resourceManager.GetString("about_copyright");
        Console.WriteLine("App version: "+ AppVersion);
        

    }

    private async void LearnMore_Clicked(object sender, EventArgs e)
    {
        await Launcher.Default.OpenAsync("https://www.pixtel.us/");
    }
}
