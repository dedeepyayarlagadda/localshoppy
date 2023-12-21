using demo.Modal;
using demo.Views;
using static demo.MauiProgram;
namespace demo
{
    public partial class AppShell : Shell
    {
        private List<Boy> MenList = new List<Boy> ();
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(BabyDetailPage), typeof(BabyDetailPage));
            Routing.RegisterRoute(nameof(LoadingPage), typeof(LoadingPage));
            Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
            Routing.RegisterRoute(nameof(AboutPage), typeof(AboutPage));
            Routing.RegisterRoute(nameof(QRScanner), typeof(QRScanner));
            Routing.RegisterRoute(nameof(AddQRData), typeof(AddQRData));
            Routing.RegisterRoute(nameof(ConfirmationMopup), typeof(ConfirmationMopup));
        }

        private void OnSearchBarFocused(object sender, EventArgs e)
        {
            
            SearchBar searchBar = (SearchBar)sender;
        }

        //private void OnTextChanged(object sender, TextChangedEventArgs e)
        //{
        //    string searchText = e.NewTextValue?.ToLower();
        //    if(string.IsNullOrEmpty(searchText) )
        //    {
        //        searchResults.ItemsSource = items;
        //    }
        //    else
        //    {
        //        var filteredItems = items.Where(item => item.OriginalTitle.ToLower().Contains(searchText).ToList());
        //        searchResults.ItemsSource = filteredItems;
        //    }
        //    SearchBar searchBar = (SearchBar)sender;

        //}

        public void OnSearchClick(object sender, EventArgs e)
        {
            {
                //if (string.IsNullOrEmpty())
                //{
                //    // If the search query is empty, reset the list or do something else
                //    //Shell.ToolbarItems.Clear();
                //}
                //else
                //{
                //    // Filter MenList based on the search query
                //    //var filteredItemsSource = MenList.Where(item => item.Description.ToLower().Contains(searchBar.Text.ToLower())).ToList();

                //}
            }
        }

        protected override async void OnNavigatedTo(NavigatedToEventArgs navigationEventArgs)
        {
            if (await IsAuthenticated())
            {
                await Shell.Current.GoToAsync("///Baby");
            }
            else
            {
                await Shell.Current.GoToAsync("login");
            }
            base.OnNavigatedTo(navigationEventArgs);
        }

        async Task<bool> IsAuthenticated()
        {
            await Task.Delay(2000);
            var hasAuth = await SecureStorage.GetAsync("hasAuth");
            return !(hasAuth == null);
        }

        protected override bool OnBackButtonPressed()
        {   
            Application.Current.Quit();
            return base.OnBackButtonPressed();
        }

        async void HamMenuClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("///HamburgerMenu");
        }
        public async void LogoutButton_Clicked(object sender, EventArgs e)
        {
            if (await DisplayAlert("Are you sure?", "You want to log out.", "Yes", "No"))
            {
                SecureStorage.RemoveAll();
                await Shell.Current.GoToAsync("///login");
            }
        }


        public async void OnClickOfSettings(object sender, EventArgs e)
        {
            string action = await DisplayActionSheet(resourceManager.GetString("settings"), resourceManager.GetString("cancel"), null, resourceManager.GetString("theme_dark"), resourceManager.GetString("theme_light"));
            switch (action)
            {
                case "Dark Mode":
                    // Implement Dark Mode logic
                    ((App)App.Current).ToggleTheme(true);
                    break;

                case "Light Mode":
                    // Implement Light Mode logic
                    ((App)App.Current).ToggleTheme(false);
                    break;

                // Handle other cases if needed

                default:
                    // Handle cancel or other default action
                    break;
            }
        }

        async void AddProduct(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("QRScanner");
        }
    }
}