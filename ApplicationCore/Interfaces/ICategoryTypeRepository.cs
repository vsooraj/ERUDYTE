using Erudyte.ApplicationCore.Entities;
using System.Threading.Tasks;

namespace Erudyte.ApplicationCore.Interfaces
{
    public interface ICategoryTypeRepository : IRepository<CatagoryType>, IAsyncRepository<CatagoryType>

    {
        CatagoryType GetByItemId(int id);

        Task<CatagoryType> GetByItemIdAsync(int id);

    }
}