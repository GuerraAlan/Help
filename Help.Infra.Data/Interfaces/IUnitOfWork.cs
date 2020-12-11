using System.Threading.Tasks;

namespace Help.Infra.Data.Interfaces
{
    interface IUnitOfWork
    {
        Task<bool> Commit();
    }
}
