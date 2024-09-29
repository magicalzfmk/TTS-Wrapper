using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Text;
using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using System.Security.Cryptography.X509Certificates;

namespace this_one_should_work.Pages
{
    /*
     Links: https://git.ecker.tech/mrq/ai-voice-cloning
     notebook: notebook_collab (ATTACHED)
     Youtube: https://www.youtube.com/watch?v=6sTsqSQYIzs

    Note:   Try not to include the above program in a project due to licencing issues.
            Instead, Use either the original tortoise or another fork.
            Make sure their licence dont have "GNU" in them.
    */
    public class APIModel : PageModel
    {
        public bool hasData = false, unknownError=false;
        
        public int Status=0;
        public string voiceOutput = "didnt work", voiceModel= "auto", prevVoice="random";
        public string URL = "https://9bbadf06c3275f5245.gradio.live"; //REPLACE THIS WITH YOUR SERVER MAIN ADDRESS
        public void OnGet()
        {
            
        }
        
        public async Task OnPost(string API, string promptText, string voice)
        {
            unknownError = false;
            URL = API;
            if (voice != prevVoice)
            {
                var voiceChoice = new HttpClient();
                var voiceChangeRequest = new HttpRequestMessage(HttpMethod.Post, API + "/run/set_autoregressive_model");


                switch (voice) //Changes Autoregressor based on voices
                {
                    case "Farhan":
                        voiceModel = "./training/Farhan/finetune/models/201_gpt.pth";
                        break;
                    case "ayushman":
                        voiceModel = "./training/ayushman/finetune/models/201_gpt.pth";
                        break;
                    case "Mitansh":
                        voiceModel = "./training/Mitansh/finetune/models/201_gpt.pth";
                        break;
                    case "Akshay":
                        voiceModel = "./training/Akshay/finetune/models/201_gpt.pth";
                        break;
                    case "AkshayHin":
                        voiceModel = "./training/AkshayHin/finetune/models/201_gpt.pth";
                        break;
                    // ADD MORE OPTIONS AS NEEDED
                    default:
                        Console.WriteLine("Error While voiceChange");
                        return;
                }
                var voiceChangeContent = new StringContent("{\r\n\"data\": [\r\n\"" + voiceModel + "\"\r\n]\r\n}", null, "application/json");
                voiceChangeRequest.Content = voiceChangeContent;
                var voiceChangeResponse = await voiceChoice.SendAsync(voiceChangeRequest);

                //voiceChangeResponse.EnsureSuccessStatusCode();//PROBLEMATIC

                Console.WriteLine(await voiceChangeResponse.Content.ReadAsStringAsync()); //DEBUG
                prevVoice = voice; //for next iteration
            }


            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Post, API+"/run/generate");
            var content = new StringContent("{\r\n    \"data\": [\r\n        \"" + promptText + "\", \n        \"\\n\", \n        \"None\", \n        \"\", \n        \"" + voice + "\", \n        {\r\n            \"name\": \"audio.wav\",\r\n            \"data\": \"data:audio/wav;base64,UklGRiQAAABXQVZFZm10IBAAAAABAAEARKwAAIhYAQACABAAZGF0YQAAAAA=\"\r\n        }, \n        0, \n        1, \n        0, \n        2, \n        50, \n        0.8, \n        \"P\", \n        8, \n        0, \n        0.8, \n        1, \n        8, \n        6, \n        2, \n        [\r\n            \"Conditioning-Free\"\r\n        ], \n        false, \n        false \n    ]\r\n}", null, "application/json");

            request.Content = content;
            var response = await client.SendAsync(request);
            //response.EnsureSuccessStatusCode();
            Status = (int)response.StatusCode; //Status Code
            string message = await response.Content.ReadAsStringAsync(); //Message returned from server (Location of Sound Output)
            switch (Status) //To handle Server Responses
            {
                case 200: //success
                    JObject outputs = JObject.Parse(message); //Parses Response
                    voiceOutput = (string)outputs["data"][0]["name"]; //Gets specific File Location from JSON Response from server
                    Console.WriteLine(voiceOutput); //DEBUG
                    hasData = true; //For Displaying a new division in HTML
                    break;

                case 504://Timeout
                    return;

                default:
                    hasData = false; unknownError = true;
                    Console.WriteLine("Error on server side");
                    return;

            }

            /*if (response.IsSuccessStatusCode) //Use If response.EnsureSuccessStatusCode() is used
            {
                JObject outputs = JObject.Parse(message); //Parses Response
                voiceOutput = (string)outputs["data"][0]["name"]; //Gets specific File Location from JSON Response from server
                *//*Console.WriteLine(voiceOutput); //DEBUG*//*
                hasData = true; //For Displaying a new division in HTML
            }*/

            /*message = await response.Content.ReadAsStringAsync();
            Console.WriteLine(message);*/

        }
    }
}
