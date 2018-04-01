using Erudyte.ApplicationCore.Entities;
using Erudyte.ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Erudyte.Infrastructure.Data
{

    public class CategoryTypeRepository : EfRepository<CatagoryType>, ICategoryTypeRepository
    {

        public CategoryTypeRepository(ErudyteContext dbContext) : base(dbContext)
        {

        }

        public CatagoryType GetByItemId(int id)
        {
            return _dbContext.CatagoryTypes
                .FirstOrDefault();
        }
        public Task<CatagoryType> GetByItemIdAsync(int id)
        {
            return _dbContext.CatagoryTypes
                .FirstOrDefaultAsync();
        }

    }
}
