using Microcharts;
using Newtonsoft.Json.Linq;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace demo.Util
{
    public class GraphUtil
    {
        private static SKColor SampleColor = SKColor.Parse("#3498db");
        private static string ChartDataFileName { get; set; } = "ChartData.txt";
        public static string ReadJsonData(string chartDataFileName)
        {
            // Read the content of the file, have try-finally with null checks and resourceclosing
            Task<Stream> streamTask = FileSystem.OpenAppPackageFileAsync(chartDataFileName);
            streamTask.Wait();         
            StreamReader reader = new StreamReader(streamTask.Result);
            string jsonData = reader.ReadToEnd();
            return jsonData;
        }

        public static ChartEntry[] GetGraphData(String jsonData)
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
                        ValueLabel = temparatureReading.ToString(),
                        Color = SampleColor,                        
                    };
                    chartEntries.Add(chartEntry);
                }

            }
            catch (Exception x)
            {

            }
            return chartEntries.ToArray();
        }
        public static ChartEntry[] GetGraphData()
        {
            string jsonData = ReadJsonData(ChartDataFileName);
            ChartEntry[] chartEntries = GetGraphData(jsonData);
            return chartEntries;
        }
    }   

}
