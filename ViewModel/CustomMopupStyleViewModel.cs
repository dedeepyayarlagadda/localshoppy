using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static demo.MauiProgram;

namespace demo.ViewModel
{
    public class CustomMopupStyleViewModel: INotifyPropertyChanged
    {
        Color color;
        Color buttonColor;
        string name;

        public event PropertyChangedEventHandler PropertyChanged;
        
       

    }

}
