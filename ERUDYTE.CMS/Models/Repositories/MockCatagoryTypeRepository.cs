using Erudyte.CMS.Models.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Erudyte.CMS.Models.Repositories
{


    public class MockCatagoryTypeRepository : ICategoryTypeRepository
    {
        private List<CatagoryType> _catagoryTypes;

        public MockCatagoryTypeRepository()
        {
            if (_catagoryTypes == null)
            {
                InitializeCatagoryTypes();
            }
        }

        private void InitializeCatagoryTypes()
        {
            _catagoryTypes = new List<CatagoryType>()
            {
                new CatagoryType() {Id=1,Type = "Endocrinology",IsActive=true},
                new CatagoryType() {Id=2,Type = "Neurology",IsActive=true },
                new CatagoryType() {Id=3,Type = "Sleep Medicine",IsActive=true},
                new CatagoryType() {Id=4,Type = "Test Category",IsActive=true}
            };
        }

        public CatagoryType GetById(int id)
        {
            return _catagoryTypes.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<CatagoryType> GetAll()
        {
            return _catagoryTypes;
        }

        public Task<CatagoryType> GetByIdAsync(int id)
        {
            return (Task<CatagoryType>)_catagoryTypes.Where(x => x.Id == id);
        }
    }
}
