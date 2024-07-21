using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Models
{
    public class RequestParams
    {
        const int maxPageSize = 50;
        public int PagerNumber { get; set; } = 1;  // default page number ataması 1

        private int _pageSize = 10;

        public int PageSize 
        {
            get 
            { 
              return _pageSize;
            }
            set
            {
                _pageSize = (value>maxPageSize) ? maxPageSize : value;
            }
        }
    }
}
