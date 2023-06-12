using System.Threading.Tasks;

namespace PublicApiCollection.Core.Data;

public interface ICoreDbSchemaMigrator
{
    Task MigrateAsync();
}
