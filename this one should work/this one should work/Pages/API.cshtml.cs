using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace this_one_should_work.Pages
{
    public class APIModel : PageModel
    {
        public bool hasData = false;
        public string message = "didnt work";
        public void OnGet()
        {
            
        }
        public async Task OnPost()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, "https://restcountries.com/v3/all");
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            message = await response.Content.ReadAsStringAsync();
            Console.WriteLine(message);
            hasData = true;
        }
    }
}
