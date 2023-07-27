using Volunteer_Management_System.Models;

namespace Volunteer_Management_System.Models
{
    
     public class EFPersonRepository : IPersonRepository
      {
          private AppDbContext context;
          public EFPersonRepository(AppDbContext ctx)
          {
              context = ctx;
          }
        public IEnumerable<Person> People => context.People;
       }
    
}
