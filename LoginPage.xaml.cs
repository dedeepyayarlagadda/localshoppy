namespace demo;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    protected override bool OnBackButtonPressed()
    {
        Application.Current.Quit();
        return true;
    }

    private async void LoginButton_Clicked(object sender, EventArgs e)
    {
        if(IsUserValid(Username.Text, Password.Text))
        {
            await SecureStorage.SetAsync("hasAuth", "true");
            await Shell.Current.GoToAsync("///Baby");
        } else
        {
            await DisplayAlert("Login Failed", "Username or password invalid", "Try again");
        }
    }

    private async void signUpButton_Clicked(object sender, EventArgs e)
    {
            await Shell.Current.GoToAsync("///Register");
    }

    private bool IsUserValid(string username, string password)
    {
        return username.Equals("admin") && password.Equals("admin");
    }
}