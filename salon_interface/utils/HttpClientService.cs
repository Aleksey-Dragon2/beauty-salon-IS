using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            return await ExecuteRequestAsync(() => _httpClient.GetAsync(url));
        }
        public async Task<HttpResponseMessage> PostAsync(string url, HttpContent content)
        {
            return await _httpClient.PostAsync(url, content);
        }
        public async Task<HttpResponseMessage> DeleteAsync(string url)
        {
            return await _httpClient.DeleteAsync(url);
        }
        private async Task<HttpResponseMessage> ExecuteRequestAsync(Func<Task<HttpResponseMessage>> httpRequest)
        {
            try
            {
                var response = await httpRequest();
                response.EnsureSuccessStatusCode();
                return response;
            }
            catch (HttpRequestException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
