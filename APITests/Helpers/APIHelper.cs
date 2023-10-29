using Newtonsoft.Json;
using RestSharp;
using SouthernCrossAssessment.DTO;
using System.Text.RegularExpressions;

namespace SouthernCrossAssessment.Helper
{
    public class APIHelper
    {

        public string ExecutePostAPIRequest(string requestBody)
        {
            var restClient = new RestClient("https://k51qryqov3.execute-api.ap-southeast-2.amazonaws.com");
            var request = new RestRequest("prod/users", Method.Post);
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", requestBody, ParameterType.RequestBody);
            request.RequestFormat = DataFormat.Json;

            RestResponse response = restClient.Execute(request);
            APIResponseBodyDTO responseBodyDTO = JsonConvert.DeserializeObject<APIResponseBodyDTO>(response.Content);
            string responseBody = RemoveLineBreaksFromJsonResponse(responseBodyDTO.Message);

            return responseBody;
        }

        private string RemoveLineBreaksFromJsonResponse(string jsonResponse) { 
        
            string response = Regex.Replace(jsonResponse, @"\n-", " -");
            response = Regex.Replace(response, @"\n", "");

            return response;
        }


    }
}
