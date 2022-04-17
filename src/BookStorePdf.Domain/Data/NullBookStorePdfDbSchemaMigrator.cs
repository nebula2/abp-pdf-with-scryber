using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace BookStorePdf.Data;

/* This is used if database provider does't define
 * IBookStorePdfDbSchemaMigrator implementation.
 */
public class NullBookStorePdfDbSchemaMigrator : IBookStorePdfDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
