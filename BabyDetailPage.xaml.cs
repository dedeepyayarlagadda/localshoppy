using demo.ViewModel;

namespace demo;

public partial class BabyDetailPage : ContentPage
{
	public BabyDetailPage()
	{
		InitializeComponent();
		BindingContext = new BabyDetailViewModel();
		
	}

}