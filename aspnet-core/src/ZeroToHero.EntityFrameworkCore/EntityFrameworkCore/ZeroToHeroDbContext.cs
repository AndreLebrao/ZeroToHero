using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ZeroToHero.Authorization.Roles;
using ZeroToHero.Authorization.Users;
using ZeroToHero.MultiTenancy;

namespace ZeroToHero.EntityFrameworkCore
{
    public class ZeroToHeroDbContext : AbpZeroDbContext<Tenant, Role, User, ZeroToHeroDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ZeroToHeroDbContext(DbContextOptions<ZeroToHeroDbContext> options)
            : base(options)
        {
        }
    }
}
