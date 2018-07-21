using Search.lib.net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search.lib.net
{
    public class SearchProvider
    {
        public List<CompanieModel> invoices(string token, string urlApiSearch, SearchCriteriaModel model)
        {
            string urlApiDocument = urlApiSunat + "/documents/";
            SearchResultsModel<DocumentResponseRepresentation> result = new SearchResultsModel<DocumentResponseRepresentation>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(urlApiDocument);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = client.PostAsJsonAsync("search", model).Result;

                if (response.IsSuccessStatusCode)
                {
                    var responseString = response.Content.ReadAsStringAsync().Result;
                    result = JsonConvert.DeserializeObject<SearchResultsModel<DocumentResponseRepresentation>>(responseString);
                    //result.items = representations;
                    //result.totalSize = representations.Count;
                }
            }
            return result;
        }
    }
}
