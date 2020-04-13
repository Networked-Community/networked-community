using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Nc.Data
{
    /* This is used if database provider does't define
     * INcDbSchemaMigrator implementation.
     */
    public class NullNcDbSchemaMigrator : INcDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}