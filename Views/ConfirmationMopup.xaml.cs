using demo.Model;
using Mopups.Pages;
using Mopups.Services;
using static demo.MauiProgram;

namespace demo.Views;

public partial class ConfirmationMopup: PopupPage
{
    private ConfirmationData confirmationData;
	public ConfirmationMopup(ConfirmationData confirmationData)
	{
		InitializeComponent();
        this.confirmationData = confirmationData;
        mopupTitle.Text = confirmationData.Title;
        modalBody.Text = confirmationData.Message;
    }

    public void OnOKClick(object sender, EventArgs e)
    {
        confirmationData.Result = true;
        Console.WriteLine("OK click==========================: " + confirmationData.Result);
        MopupService.Instance.PopAsync();
    }

    public void OnCancelClick(object sender, EventArgs e)
    {
        confirmationData.Result = false;
        MopupService.Instance.PopAsync();
    }

}