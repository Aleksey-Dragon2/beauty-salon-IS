using System;
using System.Windows.Forms;
using MyWindowsFormsApp.Models;
using Newtonsoft.Json;

namespace MyWindowsFormsApp.Services
{
    public class ApiService
    {
        private readonly HttpClientService _httpClientService;

        public ApiService(HttpClientService httpClientService)
        {
            _httpClientService = httpClientService;
        }

        public Service GetService()
        {
            var response = _httpClientService.Get($"/services/get/");

            if (response.IsSuccessStatusCode)
            {
                // Читаем содержимое ответа и десериализуем его в объект Service
                string json = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<Service>(json);
            }
            else
            {
                throw new Exception($"Ошибка при получении данных: {response.ReasonPhrase}");
            }
        }
    }
}
