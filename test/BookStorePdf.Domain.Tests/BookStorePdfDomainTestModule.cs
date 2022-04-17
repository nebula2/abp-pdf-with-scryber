using BookStorePdf.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace BookStorePdf;

[DependsOn(
    typeof(BookStorePdfEntityFrameworkCoreTestModule)
    )]
public class BookStorePdfDomainTestModule : AbpModule
{

}
