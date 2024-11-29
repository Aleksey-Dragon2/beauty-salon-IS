using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ProjectName.Services
{
    public class HttpClientService
    {
        private readonly HttpClient _httpClient;

        public HttpClientService()
        {
            _httpClient = new HttpClient();
        }

        // Метод для отправки GET-запроса и получения данных
        public async Task<HttpResponseMessage> GetAsync(string url)
        {
            try
            {
                // Отправляем запрос
                HttpResponseMessage response = await _httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();
                return response;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка HTTP-запроса: {ex.Message}");
                throw;
            }
        }
    }
}
