using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Crn.Authorization.Roles;
using Crn.Authorization.Users;
using Crn.MultiTenancy;

namespace Crn.EntityFrameworkCore
{
    public class CrnDbContext : AbpZeroDbContext<Tenant, Role, User, CrnDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public CrnDbContext(DbContextOptions<CrnDbContext> options)
            : base(options)
        {
        }
    }
}
