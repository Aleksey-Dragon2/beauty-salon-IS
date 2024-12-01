using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Text;
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

        public async Task<Service> GetServicesByIdAsync(string endpoint)
        {
            try
            {
                // Отправляем GET-запрос и получаем ответ
                var response = await _httpClientService.GetAsync(endpoint);
                string responseBody = await response.Content.ReadAsStringAsync();

                // Десериализуем ответ в список объектов Service
                var services = JsonConvert.DeserializeObject<Service>(responseBody);
                return services;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при получении услуг: {ex.Message}");
                throw;
            }
        }
        public async Task<Service> AddServiceAsync(string endpoint, string name, float price)
        {
            try
            {
                // Кодируем параметры
                string encodedName = System.Web.HttpUtility.UrlEncode(name);
                string encodedPrice = price.ToString(CultureInfo.InvariantCulture); // Используем InvariantCulture для корректной обработки чисел

                // Формируем URL с query-параметрами
                var builder = new UriBuilder(endpoint)
                {
                    Query = $"name={encodedName}&price={encodedPrice}"
                };

                // Отправка POST-запроса с query-параметрами
                var response = await _httpClientService.PostAsync(builder.ToString(), null);

                // Проверка успешности запроса
                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Десериализация ответа в объект Service
                    var addedService = JsonConvert.DeserializeObject<Service>(responseBody);
                    return addedService;
                }
                else
                {
                    // Обработка ошибок
                    string errorResponse = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Ошибка при добавлении услуги: {response.StatusCode}, {errorResponse}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при добавлении услуги: {ex.Message}");
                throw;
            }
        }




    }
}
