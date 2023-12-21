using demo.ViewModel;

namespace demo;


public partial class Baby : ContentPage
{	
	
	public Baby()
	{
		InitializeComponent();
		BindingContext = new MainViewModel();
		Routing.RegisterRoute(nameof(BabyDetailPage), typeof(BabyDetailPage));

	}

}