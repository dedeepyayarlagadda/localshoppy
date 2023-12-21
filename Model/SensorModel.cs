using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.Model
{
    public class SensorModel
    {
        public int Alarm_delay_max { get; set; }
        public int Alarm_delay_min { get; set; }
        public int Alarm_recovery_period_max { get; set; }
        public int Alarm_recovery_period_min { get; set; }
        public bool Auto_clear { get; set; }
        public bool Enabled { get; set; }
        public int Id { get; set; }
        public string Key { get; set; }
        public string Max_temp { get; set; }
        public string Min_temp { get; set; }
        public string Offset { get; set; }
        public int Report_interval { get; set; }
        public string Resource_uri { get; set; }
        public string Sensor_description { get; set; }
        public int Staleness_period { get; set; }
        public string Unit_id { get; set; }
        public UnitOfMeasurementModel Unit_of_measurement { get; set; }
        public bool Visible { get; set; }
        public string Warning_delay_max { get; set; }
        public string Warning_delay_min { get; set; }
    }
}
