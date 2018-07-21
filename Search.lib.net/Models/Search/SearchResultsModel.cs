using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search.lib.net.Models.Search
{
   public class SearchResultsModel<T>
    {
        public IList<T> items { get; set; }
        public int totalSize { get; set; }
        public SearchResultsModel()
        {
            items = new List<T>();
        }
    }
}
