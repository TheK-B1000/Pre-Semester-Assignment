using System.Collections.Generic;
using Volunteer_Management_System.Models;

namespace Volunteer_Management_System.Models
{

    public class EFAdminRepository : IAdminRepository
    {
        private AppDbContext context;
        public EFAdminRepository(AppDbContext ctx)
        {
            context = ctx;
        }
        public IEnumerable<Adminn> Admin => context.Admin;
    }

}