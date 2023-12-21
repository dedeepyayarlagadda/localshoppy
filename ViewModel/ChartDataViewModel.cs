using demo.Model;
using Highsoft.Web.Mvc.Charts;
using Highsoft.Web.Mvc.Charts.Rendering;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using demo.Resources;
using ZXing;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using LiveCharts.Helpers;
using Microcharts;
using SkiaSharp;

namespace demo.ViewModel
{
    public class ChartDataViewModel
    {
        public string JsonData { get; set; }
        public ChartEntry[] ChartEntries { get; set; }
        public static SKColor SampleColor = SKColor.Parse("#3498db");
        public ChartDataViewModel()
        {
            Task<string> jsonTask = ReadJsonData();
            jsonTask.Wait();
            this.JsonData = jsonTask.Result;
            this.ChartEntries = GetGraphData(this.JsonData);
            //ChartData = new List<ChartDataModel> { 
            //    new ChartDataModel{ Name="Funskool", UnitsOfSale=50, Price=1500, Timestamp=1700264400, Description="School supplies", Title="Funskool"},
            //    new ChartDataModel{ Name="Hamleys", UnitsOfSale=20, Price=1500, Timestamp=1700265000, Description="School supplies and Fun toys", Title="Hamleys"}
            //};


        }

        private async static Task<string> ReadJsonData()
        {            
            // Read the content of the file, have try-finally with null checks and resourceclosing
            Stream stream = await FileSystem.OpenAppPackageFileAsync("ChartData.txt");
            StreamReader reader = new StreamReader(stream);
            string jsonData = reader.ReadToEnd();
            return jsonData;
        }

        private static ChartEntry[] GetGraphData(String jsonData)
        {
            List<ChartEntry> chartEntries = new List<ChartEntry>();
            try
            {   
                JObject jsonObj = JObject.Parse(jsonData);
                JToken graphData = jsonObj.SelectToken("$.Data.unitGraphValues.objects");
                IEnumerable<JToken> tempReadings = jsonObj.SelectTokens("$.Data.unitGraphValues.objects[*]");                
                foreach (JToken item in tempReadings)
                {
                    JProperty reading = item["readings"].FirstOrDefault() as JProperty;
                    double temparatureReading = reading.Value.Value<double>();
                    string timestamp = item["timestamp"].ToString();
                    ChartEntry chartEntry = new ChartEntry((long)temparatureReading)
                    {
                        Label = timestamp,
                        ValueLabel= temparatureReading.ToString(),
                        Color = SampleColor
                    };
                    chartEntries.Add(chartEntry);
                }
                
            }
            catch (Exception x)
            {
                
            }
            return chartEntries.ToArray();
        }
    }
}
//private static Highcharts PrepareChartData()
//{
//    Highcharts chartObject = new Highcharts
//    {
//        Title = new Title
//        {
//            Text = "Monthly Average Rainfall"
//        },
//        Subtitle = new Subtitle
//        {
//            Text = "Source: WorldClimate.com"
//        },

//        XAxis = new List<XAxis> {
//        new XAxis {
//          Categories = new List <string> {"Jan","Feb","Mar"}
//        }
//      },
//        YAxis = new List<YAxis> {
//        new YAxis {
//          Min = 0,
//            Title = new YAxisTitle {
//              Text = "Rainfall (mm)"
//            }
//        }
//      },
//        Tooltip = new Tooltip
//        {
//            HeaderFormat = "<span style='font-size:10px'>{point.key}</span><table style='font-size:12px'>",
//            PointFormat = "<tr><td style='color:{series.color};padding:0'>{series.name}: </td><td style='padding:0'><b>{point.y:.1f} mm</b></td></tr>",
//            FooterFormat = "</table>",
//            Shared = true,
//            UseHTML = true
//        },
//        PlotOptions = new PlotOptions
//        {
//            Column = new PlotOptionsColumn
//            {
//                PointPadding = 0.2,
//                BorderWidth = 0
//            }
//        },
//        Series = new List<Series> {
//                        new ColumnSeries {
//                          Name = "Tokyo",
//                            Data = new List < ColumnSeriesData >  {
//                                    new ColumnSeriesData {
//                                      Name = "49.9, 71.5, 106.4"
//                                }
//                            }
//                    },
//                    new ColumnSeries {
//                      Name = "New York",
//                        Data = new List< ColumnSeriesData >  {
//                                new ColumnSeriesData {
//                                  Name = "83.6, 78.8, 98.5"
//                            }
//                        }
//                    }
//            }
//    };

//    return chartObject;
//}