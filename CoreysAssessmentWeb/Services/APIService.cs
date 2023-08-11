using System.Net.Http;
using System.Threading.Tasks;
using CoreysAssessmentWeb.Models;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace CoreysAssessmentWeb.Services
{
    public class ApiService
    {
        private readonly IConfiguration _configuration;
        private readonly HttpClient _httpClient;
        private readonly string _apiBaseUrl;

        public ApiService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _apiBaseUrl = configuration["ApiBaseUrl"];
        }

        public async Task<CoreysAssessmentWeb.Models.Review> GetRandomReviewAsync()
        {
            var apiUrl = $"{_apiBaseUrl}/API/generate"; 
            var response = await _httpClient.GetStringAsync(apiUrl);
            var reviewData = JsonConvert.DeserializeObject<Review>(response);
            return reviewData;

        }
    }
}
