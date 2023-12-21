using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.Model
{
    public class GraphDataModel
    {
        public bool Added { get; set; }
        public int Address { get; set; }
        public bool Controllable { get; set; }
        public bool Dashboard_display { get; set; }
        public string Description { get; set; }
        public bool Enabled { get; set; }
        public string Imei { get; set; }
        public string Model { get; set; }
        public string Resource_uri { get; set; }
        public List<SensorModel> Sensors { get; set; }
        public bool Standalone { get; set; }
        public bool Subscribed { get; set; }
        public List<int> Subscribers { get; set; }
        public List<string> Tags { get; set; }
        public int Timeout { get; set; }
        public int Uncleared_alarms { get; set; }
        public string Unit_id { get; set; }
        public bool Unit_offline { get; set; }
        public Gateway Gateway { get; set; }
        public UnitGraphValuesModel UnitGraphValues { get; set; }
    }
}
