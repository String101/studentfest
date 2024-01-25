using studentfest.Data;
using studentfest.Interface;
using studentfest.Models;

namespace studentfest.Repositories
{
    public class ContactDetailsRepo : Repository<ContactDetails>, IContactDetails
    {
        public ContactDetailsRepo(SqlContext context) : base(context)
        {
        }
    }
}
