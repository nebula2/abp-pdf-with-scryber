using System.Threading.Tasks;

namespace BookStorePdf.Data;

public interface IBookStorePdfDbSchemaMigrator
{
    Task MigrateAsync();
}
