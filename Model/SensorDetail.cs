using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.Model
{
    public class SensorDetail
    {
        public ReadingsModel Readings { get; set; }
        public string Unit { get; set; }
        public double Offset { get; set; }
        public string Gateway { get; set; }
        public string Id { get; set; }
        public int Gain { get; set; }
        public DateTime Datetime { get; set; }
        public int Timestamp { get; set; }
        public LocalizedReadings Localized_readings { get; set; }

    }
}
