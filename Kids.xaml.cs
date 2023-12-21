using DocumentFormat.OpenXml.Drawing.Charts;

namespace demo;

using demo.Model;
using demo.ViewModel;
using DocumentFormat.OpenXml.Spreadsheet;
using Microcharts;
using Microcharts.Maui;
using SkiaSharp;
using System.Linq;
using demo.Util;

public partial class Kids : ContentPage
{
    
    /*ChartEntry[] entries = new[]
        {
            new ChartEntry(212)
            {
                Label = "Windows",
                ValueLabel = "112",
                Color = SKColor.Parse("#2c3e50"),
                OtherColor = SKColor.Parse("#77d065")
            },
            new ChartEntry(248)
            {
                Label = "Android",
                ValueLabel = "648",
                Color = SKColor.Parse("#77d065")
            },
            new ChartEntry(128)
            {
                Label = "iOS",
                ValueLabel = "428",
                Color = SKColor.Parse("#b455b6")
            },
            new ChartEntry(514)
            {
                Label = ".NET MAUI",
                ValueLabel = "214",
                Color = SKColor.Parse("#3498db")
            }
        };*/
    
    
    public Kids()
    {
        InitializeComponent();
        ChartEntry[] chartEntries = GraphUtil.GetGraphData();

        //ChartEntry[] chartEntries = new ChartEntry[dataViewModel.ChartData.Count];
        //for (int i=0; i < dataViewModel.ChartData.Count; i++)
        //{
        //    chartEntries[i] = new ChartEntry(dataViewModel.ChartData[i].UnitsOfSale)
        //    {
        //        Label = dataViewModel.ChartData[i].Name,
        //        ValueLabel = dataViewModel.ChartData[i].UnitsOfSale.ToString(),
        //        Color = SKColor.Parse("#3498db")

        //    };
        //}

        lineChart.Chart = new LineChart
        {
            Entries = chartEntries,
            ShowYAxisLines = true,
            YAxisMaxTicks = 13,
            MinValue = -20,
            MaxValue = 100,
            LabelTextSize = 10,
            ShowYAxisText = true,
            LabelOrientation = Orientation.Default, 
            PointSize = 18,
            Margin = 30,
            PointMode = PointMode.Circle,           
            PointAreaAlpha = 0,
            YAxisPosition= Position.Left,
            LineMode=LineMode.Straight,
            LineSize= 1,
            LineAreaAlpha= 0,
            
        };
    }
}
