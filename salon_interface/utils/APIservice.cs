using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using salon_interface.Models;
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

        public async Task<T> GetDataAsync<T>(string endpoint)
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
                    if (response.StatusCode.ToString() == "NotAcceptable")
                    {
                        throw new Exception($"Такая услуга уже существует");
                    }
                    throw new Exception($"Ошибка при добавлении услуги: {response.StatusCode}, {response.Content}");
                }
            }
            catch (Exception ex)
            {
                throw ex;
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

        public async Task DeleteDateAsync(string endpoint)
        {
          await _httpClientService.DeleteAsync(endpoint);
        }

        public async Task<Master> CreateMasterAsync(string endpoint, string name, string surname, string specialization, List<string> services)
        {
            try
            {
                string encodedName = System.Web.HttpUtility.UrlEncode(name);
                string encodedSurname = System.Web.HttpUtility.UrlEncode(surname);
                string encodedSpecialization = System.Web.HttpUtility.UrlEncode(specialization);
                string encodedServices= System.Web.HttpUtility.UrlEncode(string.Join(",", services));


                var builder = new UriBuilder(endpoint)
                {
                    Query = $"name={encodedName}&surname={encodedSurname}&specialization={encodedSpecialization}&service={encodedServices}"
                };

                var response = await _httpClientService.PostAsync(builder.ToString(), null);

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();

                    var addedMaster = JsonConvert.DeserializeObject<Master>(responseBody);
                    return addedMaster;
                }
                else
                {
                    if (response.StatusCode.ToString() == "NotAcceptable")
                    {
                        throw new Exception($"Такой мастер уже существует");
                    }
                    throw new Exception($"Ошибка при добавлении мастера: {response.StatusCode}, {response.Content}");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Master> UpdateMasterAsync(string endpoint, int id, string name, string surname, string specialization)
        {
            try
            {
                string encodeId = id.ToString(CultureInfo.InvariantCulture);
                string encodedName = System.Web.HttpUtility.UrlEncode(name);
                string encodedSurname = System.Web.HttpUtility.UrlEncode(surname);
                string encodedSpecialization = System.Web.HttpUtility.UrlEncode(specialization);

                var builder = new UriBuilder(endpoint)
                {
                    Query = $"id={encodeId}&name={encodedName}&surname={encodedSurname}&specialization={specialization}"
                };

                var response = await _httpClientService.PostAsync(builder.ToString(), null);

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();

                    var updateMaster = JsonConvert.DeserializeObject<Master>(responseBody);
                    return updateMaster;
                }
                else
                {
                    string errorResponse = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Ошибка при изменении мастера: {response.StatusCode}, {errorResponse}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при изменнеии мастера: {ex.Message}");
                throw;
            }
        }

        public async Task<Visit> CreateVisitAsync(string endpoint, string client_name, string date, string status, List<string> services)
        {
            try
            {
                string encodedName = System.Web.HttpUtility.UrlEncode(client_name);
                string encodedDate = System.Web.HttpUtility.UrlEncode(date);
                string encodedStatus = System.Web.HttpUtility.UrlEncode(status);
                string encodedServices = System.Web.HttpUtility.UrlEncode(string.Join(",", services));

                var builder = new UriBuilder(endpoint)
                {
                    Query = $"client_name={encodedName}&visits_date={encodedDate}&status={encodedStatus}&services={encodedServices}"
                };

                var response = await _httpClientService.PostAsync(builder.ToString(), null);

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();

                    var addedMaster = JsonConvert.DeserializeObject<Visit>(responseBody);
                    return addedMaster;
                }
                else
                {
                    if (response.StatusCode.ToString() == "NotAcceptable")
                    {
                        throw new Exception($"Такой визит уже существует");
                    }
                    throw new Exception($"Ошибка при добавлении визита: {response.StatusCode}, {response.Content}");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<Visit> UpdateVisitAsync(string endpoint, int id, string status)
        {
            try
            {
                string encodeId = id.ToString(CultureInfo.InvariantCulture);
                string encodedStatus = System.Web.HttpUtility.UrlEncode(status);

                var builder = new UriBuilder(endpoint)
                {
                    Query = $"id={encodeId}&status={encodedStatus}"
                };

                var response = await _httpClientService.PostAsync(builder.ToString(), null);

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();

                    var updateVisit = JsonConvert.DeserializeObject<Visit>(responseBody);
                    return updateVisit;
                }
                else
                {
                    string errorResponse = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Ошибка при изменении визита: {response.StatusCode}, {errorResponse}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при изменнеии визита: {ex.Message}");
                throw;
            }
        }
    }
}
