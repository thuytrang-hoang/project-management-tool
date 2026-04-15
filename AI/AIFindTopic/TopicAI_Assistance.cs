using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Azure.AI.OpenAI;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace Programmierprojekt.AI.AIFindTopic
{
    //with help from Chat GPT
    class TopicAI_Assistance
    {
        public async Task<string> GetResponseFromOpenAI(string prompt)
        {
            string apiKey = "";
            string endpoint = "https://api.openai.com/v1/chat/completions";

            var client = new RestClient(endpoint);
            var request = new RestRequest(endpoint, Method.Post);

            // Add headers
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", $"Bearer {apiKey}");

            // Add body
            var body = new
            {
                model = "gpt-3.5-turbo",
                max_tokens = 100,
                messages = new[]
                {
            new { role = "system", content = "Sie sind ein hilfreicher Assistent, spezialisiert auf die Unterstützung bei Themen. Geben Sie den Benutzern genaue und relevante Vorschläge für Programmier-Themen, um sicherzustellen, dass die Themen nützlich für ihre Projekte sind, und verbessern Sie die Themen, wenn nötig." },
            new { role = "user", content = prompt }
        }
            };
            request.AddJsonBody(body);

            // Execute request
            var response = await client.ExecuteAsync(request);
            if (response.IsSuccessful)
            {
                var jsonResponse = JObject.Parse(response.Content);
                return jsonResponse["choices"]?[0]?["message"]?["content"]?.ToString().Trim() ?? "Keine Antwort von der KI.";
            }
            else
            {
                return $"Fehler: {response.StatusCode} - {response.Content}";
            }
        }
    }
}
