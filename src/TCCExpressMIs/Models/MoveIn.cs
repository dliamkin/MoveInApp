using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCCExpressMIs.Models
{
    public class MoveIn
    {
        public int MoveInId { get; set; }
        public string PropertyCode { get; set; }
        public string CustomerCode { get; set; }
        public string UnitCode { get; set; }
        public string UnitTypeCode { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? MoveInDate { get; set; }
        public DateTime? SetMoveInDay { get; set; }
        public int SetMoveInTime { get; set; }
    }
}
