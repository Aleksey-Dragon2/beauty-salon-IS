using Microsoft.Extensions.Configuration;
using MyWindowsFormsApp.Models;
using ProjectName.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ProjectName.api
{
    public class MasterApiHandler
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
        public static async Task<List<Master>> GetMastersAsync()
        {
            string endpoint = GetAPI()["MasterApi:GetMasters"];
            return await _apiService.GetMastersAsync<List<Master>>(endpoint);
        }

        public static async Task<Service> AddServicAsync(string name, float price, int master_id)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(AppContext.BaseDirectory, @"..\..\endpoints"))  // Full path or Relative path
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();

            string apiUrl = configuration["ApiUrls:ApiAddService"];
            string endpoint = apiUrl;

            return await _apiService.CreateServiceAsync(endpoint, name, price, master_id);
        }

        public static async Task<Service> UpdateServiceAsync(int id, string name, float price)
        {
            string endpoint = GetAPI()["ApiUrls:ApiUpdateService"]; ;
            return await _apiService.UpdateServiceAsync(endpoint, id, name, price);
        }
        public static async Task DeleteServiceAsync(int id)
        {
            string endpoint = $"{GetAPI()["ApiUrls:ApiDeleteService"]}{id}";
            await _apiService.DeleteServiceAsync(endpoint);
        }
    }
}
