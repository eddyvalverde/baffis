using System.Threading.Tasks;

namespace baffis.Data;

public interface IbaffisDbSchemaMigrator
{
    Task MigrateAsync();
}
