using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ZeroToHero.EntityFrameworkCore
{
    public static class ZeroToHeroDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ZeroToHeroDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ZeroToHeroDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
