using studentfest.Data;
using studentfest.Interface;
using studentfest.Models;

namespace studentfest.Repositories
{
    public class ResidentialAddressRepo : Repository<ResidentalAddress>, IResidentialAddress
    {
        public ResidentialAddressRepo(SqlContext context) : base(context)
        {
        }
    }
}
