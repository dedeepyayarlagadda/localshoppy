using Mopups.Pages;
using Mopups.Services;

namespace demo.Views;

public partial class InfoMopup : PopupPage
{
	public InfoMopup()
	{
		InitializeComponent();
        mopupTitle.Text = "This is Info";
        modalBody.Text = "I am Modal body";

    }

    public void OnOKClick(object sender, EventArgs e)
    {
        MopupService.Instance.PopAsync();
    }
}