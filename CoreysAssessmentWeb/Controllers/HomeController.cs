using CoreysAssessmentWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Threading.Tasks;
using CoreysAssessmentWeb.Services;

namespace CoreysAssessmentWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApiService _apiService;

        public HomeController(ApiService apiService)
        {
            _apiService = apiService;
        }

        public async Task<IActionResult> Index()
        {
            var review = await _apiService.GetRandomReviewAsync();
            return View("Index", review);

        }

    }
}
