using Newtonsoft.Json;
using Search.lib.net.Models;
using Search.lib.net.Models.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Search.lib.net
{
    public class SearchProvider
    {
        public SearchResultsModel<CompanieModel> companies(string token, string urlApiSearch, SearchCriteriaModel model)
        {
            string urlApiDocument = urlApiSearch + "/api/companies";
            SearchResultsModel<CompanieModel> result = new SearchResultsModel<CompanieModel>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(urlApiDocument);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = client.PostAsJsonAsync("search", model).Result;

                if (response.IsSuccessStatusCode)
                {
                    var responseString = response.Content.ReadAsStringAsync().Result;
                    result = JsonConvert.DeserializeObject<SearchResultsModel<CompanieModel>>(responseString);
                    //result.items = representations;
                    //result.totalSize = representations.Count;
                }
            }
            return result;
        }
    }
}
