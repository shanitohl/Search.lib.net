using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search.lib.net.Models.Search
{
    public class SearchCriteriaModel
    {
        public String filterText { get; set; }
        public IList<SearchCriteriaFilterModel> filters { get; set; }
        public IList<OrderByModel> orders { get; set; }
        public PagingModel paging { get; set; }
        public SearchCriteriaModel()
        {
            filters = new List<SearchCriteriaFilterModel>();
            orders = new List<OrderByModel>();
            paging = new PagingModel();
        }
    }
}
