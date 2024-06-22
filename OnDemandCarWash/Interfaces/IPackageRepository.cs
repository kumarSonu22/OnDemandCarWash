using OnDemandCarWash.Models;

namespace OnDemandCarWash.Interfaces
{
    public interface IPackageRepository
    {
        Task<Package> GetByIdAsync(int id);
        Task<List<Package>> GetAllAsync();
        Task AddAsync(Package package);
        Task UpdateAsync(Package package);
        Task DeleteAsync(int id);
    }
}
