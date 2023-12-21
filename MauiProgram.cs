using demo.ViewModel;
using demo.Views;
using Microsoft.Extensions.Logging;
using Microsoft.Maui.LifecycleEvents;
using Syncfusion.Maui.Core.Hosting;
using System.Reflection;
using System.Resources;
using ZXing.Net.Maui;
using ZXing.Net.Maui.Controls;
using Mopups.Hosting;
using Highsoft.Web.Mvc.Charts;
using Microcharts.Maui;

namespace demo
{
    public static class MauiProgram
    {
        public static ResourceManager resourceManager = null;
        public static ResourceManager colorRM = null;
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseBarcodeReader()
                .UseMicrocharts()
                
                .ConfigureMopups()                
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                })
                .ConfigureSyncfusionCore()
                .ConfigureMauiHandlers( handler => {
                    handler.AddHandler(typeof(ZXing.Net.Maui.Controls.CameraBarcodeReaderView), typeof(CameraBarcodeReaderViewHandler));
                    handler.AddHandler(typeof(ZXing.Net.Maui.Controls.CameraView), typeof(CameraViewHandler));
                    handler.AddHandler(typeof(ZXing.Net.Maui.Controls.BarcodeGeneratorView), typeof(BarcodeGeneratorViewHandler));
                    
                });
                ;
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<MainViewModel>();
            
            builder.Services.AddTransient<MenViewModel>();
            builder.Services.AddTransient<BabyDetailViewModel>();
            builder.Services.AddTransient<BabyViewModel>();

            builder.Services.AddTransient<QRScanner>();
            builder.Services.AddTransient<AddQRData>();
            builder.Services.AddTransient<BabyDetailPage>();
            builder.Services.AddTransient<Baby>();
            builder.Services.AddTransient<Men>();
            builder.Services.AddTransient<Kids>();
            builder.Services.AddTransient<Women>();
            builder.Services.AddTransient<Electronics>();
            builder.Services.AddTransient<HomeDecor>();               
            
            
            if(resourceManager == null)
            {
                resourceManager = new ResourceManager("demo.Resources.Strings", Assembly.GetExecutingAssembly());
            }            

            return builder.Build();
            
        }
    }
}