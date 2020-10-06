using Newtonsoft.Json;
using RestSharp;
using static AgileProject.Response;

namespace AgileProject
{
    class RecipesFinder
    {
        public RootObject ExecuteRequest(string recipe)
        {
            var client = new RestClient("https://api.edamam.com/search?q=" + recipe + "&app_id=91759b35&app_key=36b1b9791528ff8390095037abcae913&from=0&to=100");

            RestRequest request = new RestRequest();
            IRestResponse response = client.Execute(request);

            RootObject obj = new RootObject();
            obj = JsonConvert.DeserializeObject<RootObject>(response.Content);

            return obj;
        }
    }
}
