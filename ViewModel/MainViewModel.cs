using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.ViewModel
{
    public partial class MainViewModel: ObservableObject
    {
        //public RelayCommand<string> TapCommand1 { get; }

        [ObservableProperty]
        string text;

        [ObservableProperty]
        ObservableCollection<string> items;
        public MainViewModel()
        {
            Items = new ObservableCollection<string>();
        }

        [RelayCommand]
        async Task Tap(string text){            
            await Shell.Current.GoToAsync($"{nameof(BabyDetailPage)}");
        }

        [RelayCommand]
        async Task SignUpButton_Clicked()
        {
            await Shell.Current.GoToAsync($"Register");
        }

    }

}
