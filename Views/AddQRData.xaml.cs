using demo.Modal;
using demo.ViewModel;
using Mopups.Services;
using Newtonsoft.Json;
using System.Text.Json.Nodes;
using ZXing;
using static demo.MauiProgram;

namespace demo.Views;


public partial class AddQRData : ContentPage
{
    private static string boyTextFormat = @"Name: {0}\nImage: {1}\nDesc: {2}\nPrice: {3}";
    private Boy boy = null;
    public AddQRData()
	{
		InitializeComponent();
        //barcodeResult.Text = QRScanner.scannedText;
        //BindingContext = new MenViewModel();
        boy = ConvertJSONToObject(QRScanner.scannedText);
        boy.Title = resourceManager.GetString(boy.Name);
        name.Text = $"Name: {boy.Name}";
        image.Text = $"Image: {boy.ImageName}";
        desc.Text = $"Desc: {boy.Description}";
        price.Text = $"Price: {boy.Price}";
        //barcodeResult.Text = String.Format(boyTextFormat,boy.Name,boy.ImageName,boy.Description,boy.Price);

    }

    //protected override void OnAppearing()
    //{
    //    base.OnAppearing();
    //    var navigationState = Shell.Current.CurrentState;


    //    if (navigationState?.Location?.QueryParameters.TryGetValue("Text", out var scannedText))
    //    {
    //        scannedText = (string)Navigation.Parameters["Text"];
    //    }
    //}
    public async void AddToBoy(object sender, EventArgs e)
    {
        Console.WriteLine("Add to Boy _____________________________");        
        
        if(await DisplayAlert(resourceManager.GetString("are_you_sure"),resourceManager.GetString("you_want_to_add"),
                resourceManager.GetString("ok"),resourceManager.GetString("cancel"))){            
            MenViewModel.BoysX.Add(boy);
            MenViewModel.BoysX.Add(boy);
            Console.WriteLine("Men item length-add qr: " + MenViewModel.BoysX.Count);            
        }
        QRScanner.scannedText = "";
        RemovePage();
        await Shell.Current.Navigation.PopToRootAsync(true);
        //await Shell.Current.Navigation.PopAsync();
        //if (await DisplayAlert("Are you sure ?", "You want to Add", "Yes", "No"))
        //{
        //    //Boy boy = new Boy { Name = QRScanner.scannedText, ImageName = "babyhome.png" };
        //    Boy boy = ConvertJSONToObject(QRScanner.scannedText);
        //    boy.ImageName = "boy.png";
        //    Console.WriteLine("Boy$$$$$$"+boy);
        //    Console.WriteLine("Men item length-add qr: " + MenViewModel.BoysX.Count);
        //    MenViewModel.BoysX.Add(boy);
        //    Console.WriteLine("Men item length-add qr: " + MenViewModel.BoysX.Count);            
        //    Routing.UnRegisterRoute(nameof(AddQRData));
        //    //var qrPage = await Navigation.PopAsync();
        //    //qrPage = await Navigation.PopAsync();
        //    RemovePage();
        //    await Shell.Current.GoToAsync($"///{nameof(Baby)}");
        //}

    }

    private static Boy ConvertJSONToObject(string json)
    {
        var boy = JsonConvert.DeserializeObject<Boy>(json);
        return boy;
    }
    protected void OnContentPageUnloaded(Object sender, EventArgs e)
    {
        Console.WriteLine("Unloaded ADDQRData -------------------------------------: " );
        RemovePage();
        //Shell.Current.Navigation.PopToRootAsync();
    }
    public static void RemovePage()
    {
        var myExistingPageList = Shell.Current.Navigation.NavigationStack.ToList();
        foreach (var item in myExistingPageList)
        {
            if (item != null)
            {
                Console.WriteLine("Item ========******************" + item);
                if (item.GetType().Equals(typeof(Men))){
                    Shell.Current.Navigation.RemovePage(item);
                }
                //if (item.GetType().Equals(typeof(AddQRData)) || item.GetType().Equals(typeof(QRScanner)))

                //{
                //    Shell.Current.Navigation.RemovePage(item);
                //}
            }
        }
    }
}