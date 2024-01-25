using studentfest.Models;

namespace studentfest.Interface
{
    public interface IProduct:IRepository<Product>
    {
        Task<IEnumerable<Product>> GetProductsByVendorEmail(string vendorId);
        Task<IQueryable<Product>> GetAllProductsBySearch(string searchTerm, string category);
    }
}
