using Erudyte.CMS.Data.Interfaces;
using Erudyte.CMS.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Erudyte.CMS.Data.Repositories
{


    public class MockCategoryTypeRepository : ICategoryTypeRepository
    {
        private List<CategoryType> _categoryTypes;

        public MockCategoryTypeRepository()
        {
            if (_categoryTypes == null)
            {
                InitializeCatagoryTypes();
            }
        }

        private void InitializeCatagoryTypes()
        {
            _categoryTypes = new List<CategoryType>()
            {
                new CategoryType() {Id=1,Type = "Endocrinology",IsActive=true},
                new CategoryType() {Id=2,Type = "Neurology",IsActive=true },
                new CategoryType() {Id=3,Type = "Sleep Medicine",IsActive=true},
                new CategoryType() {Id=4,Type = "Test Category",IsActive=true}
            };
        }

        public CategoryType GetById(int id)
        {
            return _categoryTypes.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<CategoryType> GetAll()
        {
            return _categoryTypes;
        }

        public Task<CategoryType> GetByIdAsync(int id)
        {
            return (Task<CategoryType>)_categoryTypes.Where(x => x.Id == id);
        }
    }
}
