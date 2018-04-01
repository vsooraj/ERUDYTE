using Erudyte.CMS.Models.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Erudyte.CMS.Models.Repositories
{
    public class CatagoryTypeRepository : ICategoryTypeRepository
    {
        public CatagoryType GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<CatagoryType> GetByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<CatagoryType> GetAllAsync()
        {
            throw new System.NotImplementedException();
        }

        IEnumerable<CatagoryType> GetAll()
        {
            throw new System.NotImplementedException();
        }

        IEnumerable<CatagoryType> ICategoryTypeRepository.GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}
