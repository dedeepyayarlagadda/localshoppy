using demo.Resources.Styles;
using Microsoft.Maui.Platform;

namespace demo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();
        }

        public void ToggleTheme(bool isDarkMode)
        {
            Resources.MergedDictionaries.Clear();

            if (isDarkMode)
            {
                Resources.MergedDictionaries.Add(new LightTheme());
            }
            else
            {
                Resources.MergedDictionaries.Add(new LightTheme());
            }
        }
    }

}