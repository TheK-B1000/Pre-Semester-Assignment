using Volunteer_Management_System.Models;

namespace Volunteer_Management_System.Models
{
    
    public class EFVolunteerRepository
    {
        private AppDbContext context;
        public EFVolunteerRepository(AppDbContext ctx)
        {
            context = ctx;
        }
        public IEnumerable<Volunteer> Volunteers => context.Volunteers;


    }
}
