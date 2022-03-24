using Volo.Abp.Modularity;

namespace baffis;

[DependsOn(
    typeof(baffisApplicationModule),
    typeof(baffisDomainTestModule)
    )]
public class baffisApplicationTestModule : AbpModule
{

}
