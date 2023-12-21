namespace demo;

public partial class Register : ContentPage
{
	public Register()
	{
		InitializeComponent();
	}
    protected override bool OnBackButtonPressed()
    {
        Application.Current.Quit();
        return true;
    }

    private async void RegisterButton_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("Login");
    }


}