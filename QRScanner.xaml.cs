using demo.ViewModel;
using ZXing.Net.Maui;
using demo.Views;
using ZXing.QrCode.Internal;
using ZXing;

namespace demo;
public partial class QRScanner : ContentPage
{
	public static string scannedText;
    public QRScanner()
	{
		InitializeComponent();
		barcodeReader.IsDetecting = true;
        BarcodeReaderOptions barcodeReaderOptions = new ZXing.Net.Maui.BarcodeReaderOptions()
		{
			AutoRotate = true,
			Formats = BarcodeFormats.All
		};
	}

	private void CameraBarcodeReaderView_BarcodesDetected(Object sender, ZXing.Net.Maui.BarcodeDetectionEventArgs barcodeDetectionEventArgs)
	{
		Dispatcher.Dispatch((Action)(() =>
		{
			barcodeReader.IsDetecting = false;
            scannedText = barcodeDetectionEventArgs.Results[0].Value;            
			if (!string.IsNullOrEmpty(scannedText))
			{
                scannedText = scannedText.Replace("http://", "");
                Shell.Current.GoToAsync(nameof(AddQRData));
			}
		}));      
    }

	protected void OnContentPageUnloaded(Object sender, EventArgs e)
	{
        barcodeReader?.Handler?.DisconnectHandler();
		Shell.Current.Navigation.PopToRootAsync();
    }
}