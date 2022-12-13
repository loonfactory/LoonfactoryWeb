using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LoonfactoryPage.Data
{
    public class LoonfactoryDbContext : IdentityDbContext
    {
        public LoonfactoryDbContext(DbContextOptions<LoonfactoryDbContext> options)
            : base(options)
        {
        }
    }
}