using studentfest.Data;
using studentfest.Interface;
using studentfest.Models;

namespace studentfest.Repositories
{
    public class VendorRepo : Repository<Vendor>, IVendor
    {
        public VendorRepo(SqlContext context) : base(context)
        {
        }
    }
}
