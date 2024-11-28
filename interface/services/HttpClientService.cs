using System;
using System.Net.Http;
using MyWindowsFormsApp.Models;

namespace MyWindowsFormsApp.Services
{
    public class HttpClientService
    {
        private readonly HttpClient _httpClient;

        public HttpClientService()
        {
            _httpClient = new HttpClient
            {
                Timeout = TimeSpan.FromSeconds(30),  // Устанавливаем тайм-аут для запросов
                BaseAddress = new Uri("http://localhost:8000")  // Базовый адрес вашего FastAPI сервера
            };
        }

        public HttpResponseMessage Get(string endpoint)
        {
            try
            {
                return _httpClient.GetAsync(endpoint).Result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                throw;
            }
        }
    }
}
