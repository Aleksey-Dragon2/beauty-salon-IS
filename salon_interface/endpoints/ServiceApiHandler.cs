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
    public class ServiceApiHandler
    {
        private static ApiService _apiService = new ApiService();

        public static async Task<List<Service>> GetServicesAsync()
        {

            var configuration = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(AppContext.BaseDirectory, @"..\..\endpoints"))  // Full path or Relative path
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();

            string apiUrl = configuration["ApiUrls:ApiGetServices"];
            string endpoint = apiUrl;
            return await _apiService.GetServicesAsync(endpoint);
        }
        public static async Task<Service> GetServiceByIdAsync(int id)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(AppContext.BaseDirectory, @"..\..\endpoints"))  // Убедитесь, что путь правильный
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();

            string apiUrl = configuration["ApiUrls:GetServiceById"];
            string endpoint = $"{apiUrl}{id}"; // Добавляем ID к endpoint

            return await _apiService.GetServicesByIdAsync(endpoint);
        }

        public static async Task<Service> AddServiceAsync(string name, float price)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(AppContext.BaseDirectory, @"..\..\endpoints"))  // Full path or Relative path
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();

            string apiUrl = configuration["ApiUrls:ApiAddService"];
            string endpoint = apiUrl;

            return await _apiService.AddServiceAsync(endpoint, name, price);
        }
    }
}
