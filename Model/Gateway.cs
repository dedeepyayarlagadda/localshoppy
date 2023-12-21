using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace demo.Model
{
    public class Gateway
    {
        public string City { get; set; }
        public string Country_name { get; set; }
        public bool Estimate { get; set; }
        public string Gateway_id { get; set; }
        public string Ip { get; set; }
        public string Region_name { get; set; }
        public PremisesModel Premises { get; set; }

        public class PremisesModel
        {
            public int Id { get; set; }
            public int Company { get; set; }
            public string Extended_Address { get; set; }
            public string Locality { get; set; }
            public string Name { get; set; }
            public string Street_address { get; set; }
            public string Resource_uri { get; set; }
            public string Slug { get; set; }
            public Region Region { get; set; }
        }
    }
}
