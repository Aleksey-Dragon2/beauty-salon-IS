using Microsoft.Extensions.Configuration;
using salon_interface.Models;
using ProjectName.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace ProjectName.api
{
    public class VisitApiHandler
    {
        private static ApiService _apiService = new ApiService();
        private static IConfigurationRoot GetAPI()
        {
            var configuration = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(AppContext.BaseDirectory, @"..\..\endpoints"))  // Full path or Relative path
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .Build();

            return configuration;
        }
        public static async Task<List<Visit>> GetVisitAsync()
        {
            string endpoint = GetAPI()["VisitApi:GetVisits"];
            return await _apiService.GetDataAsync<List<Visit>>(endpoint);
        }

        public static async Task<Master> CreateVisitAsync(string client_name, string date, string status)
        {
            string endpoint = GetAPI()["VisitApi:CreateVisit"];
            return await _apiService.CreateVisitAsync(endpoint, client_name, date, status);
        }
    }
}