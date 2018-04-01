using System.Collections.Generic;
using System.Threading.Tasks;

namespace Erudyte.CMS.Models.Interfaces
{
    public interface ICategoryTypeRepository
    {
        CatagoryType GetById(int id);

        Task<CatagoryType> GetByIdAsync(int id);

        IEnumerable<CatagoryType> GetAll();

    }
}
