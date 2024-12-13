using Newtonsoft.Json;
using System;
using System.Windows.Forms;

namespace salon_interface.Models
{
    public class Coefficient
    {
        [JsonProperty("application_date")]
        public DateTime Application_Date { get; set; }
        public string Value { get; set; }
    }
}