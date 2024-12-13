using Newtonsoft.Json;
using System;

namespace salon_interface.Models
{
    public class MasterStats
    {
        public string Master_Name { get; set; }
        public string Specialization { get; set; }
        public int Total_Services { get; set; }
        public string Popular_Service { get; set; }
        public float Avg_Service_Price { get; set; }
    }
}