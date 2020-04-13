using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace Nc.EntityFrameworkCore
{
    public static class NcDbContextModelCreatingExtensions
    {
        public static void ConfigureNc(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(NcConsts.DbTablePrefix + "YourEntities", NcConsts.DbSchema);

            //    //...
            //});
        }
    }
}