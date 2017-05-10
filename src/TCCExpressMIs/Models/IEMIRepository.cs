using System.Collections.Generic;

namespace TCCExpressMIs.Models
{
    public interface IEMIRepository
    {
        IEnumerable<MoveIn> GetAllMoveIns();
        IEnumerable<Property> GetAllProperties();
        IEnumerable<Property> CheckIfPropertyExists(string prop);
    }
}