namespace demo;

public partial class LoadingPage : ContentPage
{
	public LoadingPage()
	{
		InitializeComponent();
	}

    protected override async void OnNavigatedTo(NavigatedToEventArgs navigationEventArgs)
    {
        if (await IsAuthenticated())
        {
            await Shell.Current.GoToAsync("///Baby");
        }
        else
        {
            await Shell.Current.GoToAsync("//login");
        }
        base.OnNavigatedTo(navigationEventArgs);
    }

    async Task<bool> IsAuthenticated()
    {
        await Task.Delay(2000);
        var hasAuth = await SecureStorage.GetAsync("hasAuth");
        return !(hasAuth == null);
    }
}