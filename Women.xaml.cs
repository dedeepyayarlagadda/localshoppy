using Mopups.Services;
using demo.Views;
using Mopups.Animations;
using Mopups.Pages;
using Mopups.PreBaked.PopupPages.SingleResponse;
using Microsoft.Maui.Platform;
using Mopups.PreBaked.PopupPages.DualResponse;
using Mopups.PreBaked.Services;
using Mopups.PreBaked.PopupPages.EntryInput;
using Mopups.PreBaked.PopupPages.Login;
using Mopups.PreBaked.PopupPages.TextInput;
using System.Collections;
using static demo.MauiProgram;
using demo.Model;

namespace demo;

public partial class Women : ContentPage
{
	public Women()
	{
		InitializeComponent();
	}

    public async void OnCounterClicked(object sender, System.EventArgs e)
    {
        string mopupTitle = resourceManager.GetString("are_you_sure");
        string mopupDescription = resourceManager.GetString("about_app_desc");
        ConfirmationData confirmationData = new ConfirmationData();
        confirmationData.Title = mopupTitle;
        confirmationData.Message = mopupDescription;
        await TestConfirmationMopup(confirmationData);
        Console.WriteLine("Output after2 ========:" + confirmationData.Result);
        //SingleResponseViewModel.AutoGenerateBasicPopup(Colors.HotPink, Colors.Black, "I Accept", Colors.Gray, "Good Job, enjoy this single response example", "toys.png");
        //PreBakedMopupService.GetInstance().WrapTaskInLoader(Task.Delay(10000), Colors.Blue, Colors.White, new List<string> { "test","Only" }, Colors.Black);
        //DualResponseViewModel.AutoGenerateBasicPopup(Colors.WhiteSmoke, Colors.Red, "Okay", Colors.WhiteSmoke, Colors.Green, "Looks Good!", Colors.DimGray, "This is an example of a dual response popup page", "Title", 50, 50);
        //Task<string> outputText = TextInputViewModel.AutoGenerateBasicPopup(Colors.WhiteSmoke, Colors.Red, "Cancel", Colors.WhiteSmoke, Colors.Green, "Submit", Colors.DimGray, "Text input Example", "placeholder text", 25,25);
        //Console.WriteLine("Output Text ++++++++++:"+outputText.Result);
        //EntryInputViewModel.AutoGenerateBasicPopup(Colors.WhiteSmoke, Colors.Red, "Cancel", Colors.WhiteSmoke, Colors.Green, "Submit", Colors.DimGray, "Text input Example", "Placeholder text");
        //Test();
    }

    public async void OnInfoClicked(object sender, System.EventArgs e)
    {
        await MopupService.Instance.PushAsync(new InfoMopup());
    }

    public async void Test()
    {
        string s1 = await TextInputViewModel.AutoGenerateBasicPopup(Colors.WhiteSmoke, Colors.Red, "Cancel", Colors.WhiteSmoke, Colors.Green, "Submit", Colors.DimGray, "Text input Example", "placeholder text", 25, 25);
        Console.WriteLine("Output text__________________: "+s1);
    }

    public async Task<ConfirmationData> TestConfirmationMopup(ConfirmationData confirmationData)
    {
        Console.WriteLine("Output before mopupservice  ========:" + confirmationData.Result);
        //await Shell.Current.GoToAsync(nameof(ConfirmationMopup));
        await MopupService.Instance.PushAsync(new ConfirmationMopup(confirmationData));
        Console.WriteLine("Output after1 ========:" + confirmationData.Result);
        return confirmationData;
    }

    public void OnEntryInputClicked(object sender, System.EventArgs e)
    {
        string userEnteredText = e.ToString();
    }


}