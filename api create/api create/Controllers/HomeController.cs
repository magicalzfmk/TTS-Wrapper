using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace api_create.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            ViewBag.Title = "Home Page";
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, "https://restcountries.com/v3/all");
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            String answer = await response.Content.ReadAsStringAsync();
            ViewData["ValueToPrint"] = answer;
            return View();
        }
    }
}
