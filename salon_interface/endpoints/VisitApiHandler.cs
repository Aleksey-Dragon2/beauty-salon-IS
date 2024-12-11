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

        
        public static async Task<List<Visit>> GetVisitByDateAsync(string date)
        {
            string endpoint = GetAPI()["VisitApi:GetVisitsByDate"];
            string encodedDate = System.Web.HttpUtility.UrlEncode(date);
            endpoint += $"?date={encodedDate}";
            return await _apiService.GetDataAsync<List<Visit>>(endpoint);
        }
        public static async Task<List<VisitInfo>> GetVisitById(int id)
        {
            string endpoint = GetAPI()["VisitApi:GetVisitInfoById"];
            endpoint += $"{id}";
            return await _apiService.GetDataAsync<List<VisitInfo>>(endpoint);
        }

        public static async Task<MemoryStream> GetChequeFileAsync(int visitId)
        {
            string endpoint = $"{GetAPI()["VisitApi:GetCheque"]}?visit_id={visitId}";
            return await _apiService.GetFileAsync(endpoint);
        }


        public static async Task<Visit> CreateVisitAsync(string client_name, string date, string status, List<string> services)
        {
            string endpoint = GetAPI()["VisitApi:CreateVisit"];
            return await _apiService.CreateVisitAsync(endpoint, client_name, date, status, services);
        }

        public static async Task<Visit> UpdateVisitAsync(int id, string status)
        {
            string endpoint = GetAPI()["VisitApi:UpdateVisit"];
            return await _apiService.UpdateVisitAsync(endpoint, id, status);
        }
    }
}