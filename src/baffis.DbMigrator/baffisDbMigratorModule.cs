using baffis.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace baffis.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(baffisEntityFrameworkCoreModule),
    typeof(baffisApplicationContractsModule)
    )]
public class baffisDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
