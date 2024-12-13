using Microsoft.Extensions.Configuration;
using ProjectName.Services;
using salon_interface.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;



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
        public static async Task<List<MasterStats>> GetMasterStats(int id)
        {
            string endpoint = GetAPI()["MasterApi:GetMasterStats"];
            endpoint += $"{id}";
            return await _apiService.GetDataAsync<List<MasterStats>>(endpoint);
        }

        public static async Task<List<string>> GetSpecizlizationAsync()
        {
            string endpoint = GetAPI()["MasterApi:GeSpecialization"];
            return await _apiService.GetDataAsync<List<string>>(endpoint);
        }    
        public static async Task<List<Master>> GetMastersBySpecializationAsync(string specialization)
        {
            string endpoint = GetAPI()[$"MasterApi:GetMastersBySpecialization"];
            string encodedSpecialization = System.Web.HttpUtility.UrlEncode(specialization);
            endpoint += $"?specialization={encodedSpecialization}";
            return await _apiService.GetDataAsync<List<Master>>(endpoint);
        }

        public static async Task<Master> CreateMasterAsync(string name, string surname, string specialization, List<string> services)
        {
            string endpoint = GetAPI()["MasterApi:CreateMaster"];
            return await _apiService.CreateMasterAsync(endpoint, name, surname, specialization, services);
        }

        public static async Task<Master> UpdateMasterAsync(int id, string name, string surname, string specialization)
        {
            string endpoint = GetAPI()["MasterApi:ApiUpdateService"]; ;
            return await _apiService.UpdateMasterAsync(endpoint, id, name, surname, specialization);
        }
        public static async Task DeleteMasterAsync(int id)
        {
            string endpoint = $"{GetAPI()["MasterApi:DeleteMaster"]}{id}";
            await _apiService.DeleteDateAsync(endpoint);
        }
    }
}
