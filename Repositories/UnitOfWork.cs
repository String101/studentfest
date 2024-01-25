using studentfest.Data;
using studentfest.Interface;

namespace studentfest.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public readonly SqlContext _sqlContext;
        public IProduct Product { get; private set; }

        public IVendor Vendor { get; private set; }

        public IUser User { get; private set; }

        public IContactDetails ContactDetails { get; private set; }

        public IResidentialAddress ResidentialAddress { get; private set; }

        public UnitOfWork(SqlContext sqlContext)
        {
            _sqlContext = sqlContext;
            Product = new ProductRepo(_sqlContext);
            Vendor = new VendorRepo(_sqlContext);
            User = new UserRepo(_sqlContext);
            ResidentialAddress= new ResidentialAddressRepo(_sqlContext);
            ContactDetails = new ContactDetailsRepo(_sqlContext);
        }
        public void Save()
        {
            _sqlContext.SaveChanges();
        }
    }
}
