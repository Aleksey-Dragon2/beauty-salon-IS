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
            return await _apiService.GetDataAsync<List<Master>>(endpoint);
        }

        public static async Task<Master> CreateMasterAsync(string name, string surname, string specialization)
        {
            string endpoint = GetAPI()["ApiMaster:CreateMaster"];
            return await _apiService.CreateMasterAsync(endpoint, name, surname, specialization);
        }

        public static async Task<Master> UpdateMasterAsync(int id, string name, string surname, string specialization)
        {
            string endpoint = GetAPI()["ApiUrls:ApiUpdateService"]; ;
            return await _apiService.UpdateMasterAsync(endpoint, id, name, surname, specialization);
        }
        public static async Task DeleteMasterAsync(int id)
        {
            string endpoint = $"{GetAPI()["ApiUrls:DeleteMaster"]}{id}";
            await _apiService.DeleteDateAsync(endpoint);
        }
    }
}
