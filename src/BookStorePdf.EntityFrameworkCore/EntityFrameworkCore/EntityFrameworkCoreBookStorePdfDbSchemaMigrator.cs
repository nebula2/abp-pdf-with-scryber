using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BookStorePdf.Data;
using Volo.Abp.DependencyInjection;

namespace BookStorePdf.EntityFrameworkCore;

public class EntityFrameworkCoreBookStorePdfDbSchemaMigrator
    : IBookStorePdfDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreBookStorePdfDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the BookStorePdfDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<BookStorePdfDbContext>()
            .Database
            .MigrateAsync();
    }
}
