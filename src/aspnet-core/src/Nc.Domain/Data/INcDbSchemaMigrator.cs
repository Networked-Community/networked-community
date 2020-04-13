using System.Threading.Tasks;

namespace Nc.Data
{
    public interface INcDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
