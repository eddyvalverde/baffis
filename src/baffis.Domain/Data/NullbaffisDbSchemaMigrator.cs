using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace baffis.Data;

/* This is used if database provider does't define
 * IbaffisDbSchemaMigrator implementation.
 */
public class NullbaffisDbSchemaMigrator : IbaffisDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
