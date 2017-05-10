using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCCExpressMIs.Models
{
    public class Property
    {
        public int ID { get; set; }
        public string CommunityCode { get; set; }
        public string CommunityName { get; set; }
        public string AddressLine1 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public string WebSite { get; set; }
        public string URLExt { get; set; }
    }
}
