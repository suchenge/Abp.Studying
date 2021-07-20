using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace Abp.Studying.EntityFrameworkCore
{
    public static class StudyingDbContextModelCreatingExtensions
    {
        public static void ConfigureStudying(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(StudyingConsts.DbTablePrefix + "YourEntities", StudyingConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}