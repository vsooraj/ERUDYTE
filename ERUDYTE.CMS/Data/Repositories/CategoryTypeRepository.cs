using Erudyte.CMS.Data.Interfaces;
using Erudyte.CMS.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Erudyte.CMS.Data.Repositories
{
    public class CategoryTypeRepository : ICategoryTypeRepository
    {
        private readonly ErudyteContext _dbContext;

        public CategoryTypeRepository(ErudyteContext dbContext)
        {
            _dbContext = dbContext;
        }

        public CategoryType GetByItemId(int id)
        {
            return _dbContext.CategoryTypes
                .FirstOrDefault();
        }
        public Task<CategoryType> GetByItemIdAsync(int id)
        {
            return _dbContext.CategoryTypes
                .FirstOrDefaultAsync();
        }
        public CategoryType GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<CategoryType> GetByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<CategoryType> GetAllAsync()
        {
            throw new System.NotImplementedException();
        }

        IEnumerable<CategoryType> ICategoryTypeRepository.GetAll()
        {
            return _dbContext.CategoryTypes;
        }
    }
}
