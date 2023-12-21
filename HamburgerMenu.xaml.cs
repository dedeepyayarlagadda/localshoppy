namespace demo;

public partial class HamburgerMenu : ContentPage
{
	public HamburgerMenu()
	{
		InitializeComponent();
	}

	private async void OnNavigateClicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("AboutPage");
	}
}