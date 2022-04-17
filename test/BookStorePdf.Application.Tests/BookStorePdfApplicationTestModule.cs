using Volo.Abp.Modularity;

namespace BookStorePdf;

[DependsOn(
    typeof(BookStorePdfApplicationModule),
    typeof(BookStorePdfDomainTestModule)
    )]
public class BookStorePdfApplicationTestModule : AbpModule
{

}
