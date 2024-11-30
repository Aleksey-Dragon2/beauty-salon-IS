using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MyWindowsFormsApp.Models;
using Newtonsoft.Json;
using ProjectName.Services;  // Подключаем HttpClientService

namespace ProjectName.Services
{
    public class ApiService
    {
        private readonly HttpClientService _httpClientService;

        public ApiService()
        {
            _httpClientService = new HttpClientService();  // Используем HttpClientService
        }

        // Метод для получения списка услуг с API
        public async Task<List<Service>> GetServicesAsync(string endpoint)
        {
            try
            {
                // Отправляем GET-запрос и получаем ответ
                var response = await _httpClientService.GetAsync(endpoint);
                string responseBody = await response.Content.ReadAsStringAsync();

                // Десериализуем ответ в список объектов Service
                var services = JsonConvert.DeserializeObject<List<Service>>(responseBody);
                return services;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при получении услуг: {ex.Message}");
                throw;
            }
        }
    }
}
