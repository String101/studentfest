namespace studentfest.Interface
{
    public interface IUnitOfWork
    {
        IProduct Product { get; }
        IVendor Vendor { get; }
        IUser User { get; }
        IContactDetails ContactDetails { get; }
        IResidentialAddress ResidentialAddress { get; }
        void Save();
    }
}
