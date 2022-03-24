using baffis.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace baffis;

[DependsOn(
    typeof(baffisEntityFrameworkCoreTestModule)
    )]
public class baffisDomainTestModule : AbpModule
{

}
