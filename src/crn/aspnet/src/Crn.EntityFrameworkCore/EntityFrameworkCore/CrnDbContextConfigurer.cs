using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Crn.EntityFrameworkCore
{
    public static class CrnDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<CrnDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<CrnDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
