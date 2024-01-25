using Microsoft.EntityFrameworkCore;
using studentfest.Data;
using studentfest.Interface;
using studentfest.Models;

namespace studentfest.Repositories
{
    public class ProductRepo:Repository<Product>,IProduct
    {
        private readonly SqlContext _context;
        public ProductRepo(SqlContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IQueryable<Product>> GetAllProductsBySearch(string searchTerm, string category)
        {
            var productFromDb = await _context.Products.Where(u => u.ProductName == searchTerm || u.ProductCategory == category).ToListAsync();

            return productFromDb.AsQueryable();
        }

        public async Task<IEnumerable<Product>> GetProductsByVendorEmail(string vendorId)
        {
            var productByVendor = await _context.Products.Where(u=>u.VendorId == vendorId).ToListAsync();

            return productByVendor;
        }
    }
}
