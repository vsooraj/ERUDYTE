using Erudyte.CMS.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Erudyte.CMS.Data.Interfaces
{
    public interface ICategoryTypeRepository
    {
        CategoryType GetById(int id);

        Task<CategoryType> GetByIdAsync(int id);

        IEnumerable<CategoryType> GetAll();

    }
}
