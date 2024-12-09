using Newtonsoft.Json;
using System;
using System.Windows.Forms;

namespace salon_interface.Models
{
    public class Visit
    {
        public int Id { get; set; }
        public string Client_Name { get; set; }
        [JsonProperty("visits_date")]
        public DateTime VisitDate { get; set; }
        public string Status { get; set; }
    }
}
