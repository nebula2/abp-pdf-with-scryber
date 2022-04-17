using BookStorePdf.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace BookStorePdf.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(BookStorePdfEntityFrameworkCoreModule),
    typeof(BookStorePdfApplicationContractsModule)
    )]
public class BookStorePdfDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
