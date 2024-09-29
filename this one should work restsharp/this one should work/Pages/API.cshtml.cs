using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RestSharp;

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
            var options = new RestClientOptions("https://restcountries.com")
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest("/v3/all", Method.Get);
            RestResponse response = await client.ExecuteAsync(request);
            if(response.Content != null)
            {
                message = response.Content;
                Console.WriteLine(message);
            }
            else
            {
                message = "nothing returned (ERROR: NULL value)";
            }
            hasData = true;
        }
    }
}
