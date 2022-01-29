using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using RestSharp;

namespace Comar
{
    public static class ComarMessageHalper
    {
        public static string ServiceURL { get; set; }
        public static string SlackBotToken { get; set; }
        public static string Authentication { get; set; }

        public static bool Ping(SendMessageResource sendMessageResource)
        {
            var client = new RestClient($"{ServiceURL}/api/ping");
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authentication", Authentication);

            if (SlackBotToken is not null)
                request.AddHeader("SlackBotToken", SlackBotToken);

            var body = JsonSerializer.Serialize(sendMessageResource);
            request.AddParameter("application/json", body,  ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            if (!response.IsSuccessful)
                return false;

            return true;
        }
    }

    public class SendMessageResource
    {
        public string Channel { get; set; }
        public string Message { get; set; }
        public string BlockquoteColor { get; set;}
        public List<string> AdditionalTexts { get; set; }

    }
    
}
