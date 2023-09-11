using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Opera.Authorization.Roles;
using Opera.Authorization.Users;
using Opera.MultiTenancy;

namespace Opera.EntityFrameworkCore
{
    public class OperaDbContext : AbpZeroDbContext<Tenant, Role, User, OperaDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public OperaDbContext(DbContextOptions<OperaDbContext> options)
            : base(options)
        {
        }
    }
}
