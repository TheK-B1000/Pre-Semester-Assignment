using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Volunteer_Management_System.Models
{

    public class EFAdminRepository : IAdminRepository
    {
        private AppDbContext _context;
        public EFAdminRepository(AppDbContext ctx)
        {
            _context = ctx;
        }
        public IEnumerable<Admin> Admins => _context.Admins;
    }

}