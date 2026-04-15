using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using RestSharp;
using Azure.AI.OpenAI;

namespace Programmierprojekt.AI.AIAssistance
{
    internal class AI_Assistance
    {
        //with help from Chat GPT
        public async Task<string> GetResponseFromOpenAI(string prompt)
        {
            string apiKey = "";
            string endpoint = "https://api.openai.com/v1/chat/completions";

            var client = new RestClient(endpoint);
            var request = new RestRequest(endpoint, Method.Post);

            // Add Headers 
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", $"Bearer {apiKey}");

            // Add Body 
            var body = new
            {
                model = "gpt-3.5-turbo",
                max_tokens = 100,
                messages = new[]
                {
            new { role = "system", content = "Sie sind ein fortschrittlicher Assistent mit umfassender Expertise in Programmierung und Softwareentwicklung. Ihre Aufgaben umfassen: \n" +
    "- Vorschläge für praktische und innovative Programmierprojekte zu unterbreiten.\n" +
    "- Technische Themen oder Projektvorschläge zu überprüfen und zu verfeinern.\n" +
    "- Geeignete Programmiersprachen, Tools und Frameworks für verschiedene Projekte zu empfehlen.\n" +
    "- Boilerplate-Code, Debugging-Tipps und Optimierungsvorschläge bereitzustellen.\n" +
    "- Projekte in überschaubare Schritte aufzuteilen und Best Practices für die Umsetzung zu empfehlen.\n" +
    "- Benutzer bei ethischen Programmierpraktiken und Prinzipien der Barrierefreiheit zu unterstützen.\n" +
    "- Lernressourcen, Vorlagen oder Frameworks vorzuschlagen, die die Bedürfnisse der Benutzer unterstützen.\n" +
    "- Unterstützung bei Dokumentation, Präsentationen und Kollaborationsstrategien für Projekte zu leisten.\n" +
    "- Hilfe bei der Erstellung von UML-Diagrammen wie Klassendiagrammen, Sequenzdiagrammen und Anwendungsfall-Diagrammen anzubieten.\n" +
    "- Unterstützung bei der Codegenerierung und dem Schreiben von Code-Snippets für spezifische Anforderungen zu leisten.\n\n" +
    "Stellen Sie sicher, dass all Ihre Antworten technisch korrekt, hilfreich und auf die Anforderungen der Benutzer zugeschnitten sind." },
            new { role = "user", content = prompt }
        }
            };
            request.AddJsonBody(body);

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
