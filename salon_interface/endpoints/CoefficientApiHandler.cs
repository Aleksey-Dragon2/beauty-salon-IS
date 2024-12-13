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
    public class CoefficientApiHandler
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

        public static async Task<List<Coefficient>> GetCoefficientAsync()
        {
            string endpoint = GetAPI()["PriceCoeffAPI:GetCoefficient"];
            return await _apiService.GetDataAsync<List<Coefficient>>(endpoint);
        }
        public static async Task<Coefficient> CreateCoefficientAsync(float value)
        {
            string endpoint = GetAPI()["PriceCoeffAPI:CreateCoefficient"];
            return await _apiService.CreateCoefficientAsync(endpoint, value);
        }

    }
}