using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using baffis.Data;
using Volo.Abp.DependencyInjection;

namespace baffis.EntityFrameworkCore;

public class EntityFrameworkCorebaffisDbSchemaMigrator
    : IbaffisDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCorebaffisDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the baffisDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<baffisDbContext>()
            .Database
            .MigrateAsync();
    }
}
