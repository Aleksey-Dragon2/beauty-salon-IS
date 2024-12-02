using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyWindowsFormsApp.Models;
using Newtonsoft.Json;
using ProjectName.Services; 

namespace ProjectName.Services
{
    public class ApiService
    {
        private readonly HttpClientService _httpClientService;

        public ApiService()
        {
            _httpClientService = new HttpClientService();
        }

        public async Task<T> GetServicesAsync<T>(string endpoint)
        {
            try
            {
                var response = await _httpClientService.GetAsync(endpoint);
                var responseBody = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(responseBody);
            }
            catch (JsonException ex)
            {
                MessageBox.Show($"Ошибка десериализации: {ex.Message}");
                throw new Exception("Ошибка обработки данных. Пожалуйста, свяжитесь с поддержкой.", ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка на уровне API: {ex.Message}");
                throw;
            }
        }
        public async Task<Service> CreateServiceAsync(string endpoint, string name, float price, int master_id)
        {
            try
            {
                string encodedName = System.Web.HttpUtility.UrlEncode(name);
                string encodedPrice = price.ToString(CultureInfo.InvariantCulture); // InvariantCulture для корректной обработки чисел
                string encodedMasterId= master_id.ToString(CultureInfo.InvariantCulture);

                var builder = new UriBuilder(endpoint)
                {
                    Query = $"name={encodedName}&price={encodedPrice}&master_id={encodedMasterId}"
                };

                var response = await _httpClientService.PostAsync(builder.ToString(), null);

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();

                    var addedService = JsonConvert.DeserializeObject<Service>(responseBody);
                    return addedService;
                }
                else
                {
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


        public async Task<Service> UpdateServiceAsync(string endpoint, int id, string name, float price)
        {
            try
            {
                string encodeId = id.ToString(CultureInfo.InvariantCulture);
                string encodedName = System.Web.HttpUtility.UrlEncode(name);
                string encodedPrice = price.ToString(CultureInfo.InvariantCulture); // InvariantCulture для корректной обработки чисел


                var builder = new UriBuilder(endpoint)
                {
                    Query = $"id={encodeId}&name={encodedName}&price={encodedPrice}"
                };

                var response = await _httpClientService.PostAsync(builder.ToString(), null);

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();

                    var addedService = JsonConvert.DeserializeObject<Service>(responseBody);
                    return addedService;
                }
                else
                {
                    string errorResponse = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Ошибка при изменении услуги: {response.StatusCode}, {errorResponse}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при изменнеии услуги: {ex.Message}");
                throw;
            }
        }

        public async Task DeleteServiceAsync(string endpoint)
        {
          await _httpClientService.DeleteAsync(endpoint);
        }

        public async Task<T> GetMastersAsync<T>(string endpoint)
        {
            try
            {
                var response = await _httpClientService.GetAsync(endpoint);
                var responseBody = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(responseBody);
            }
            catch (JsonException ex)
            {
                MessageBox.Show($"Ошибка десериализации: {ex.Message}");
                throw new Exception("Ошибка обработки данных. Пожалуйста, свяжитесь с поддержкой.", ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка на уровне API: {ex.Message}");
                throw;
            }
        }

    }
}
