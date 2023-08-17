using Microsoft.EntityFrameworkCore;

namespace BaseMVC7.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        // Here are all the models
    }
}
