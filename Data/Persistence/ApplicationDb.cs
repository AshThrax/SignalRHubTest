
using Microsoft.EntityFrameworkCore;

namespace SignalRHubTest.Data.Persistence
{
    public class ApplicationDb :DbContext
    {
        public ApplicationDb(DbContextOptions<ApplicationDb> options):base(options) 
        { 
        }
    }
}
