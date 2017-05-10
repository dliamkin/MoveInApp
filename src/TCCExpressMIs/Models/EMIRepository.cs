using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCCExpressMIs.Models
{
    public class EMIRepository : IEMIRepository
    {
        private EMIContext _context;

        public EMIRepository(EMIContext context)
        {
            _context = context;
        }

        public IEnumerable<MoveIn> GetAllMoveIns()
        {
            return _context.MoveIns.ToList();
        }

        public IEnumerable<Property> GetAllProperties()
        {
            return _context.Properties.ToList();
        }

        public IEnumerable<Property> CheckIfPropertyExists(string prop)
        {
            return _context.Properties.Where(a => a.CommunityCode.Equals(prop));
        }
    }
}
