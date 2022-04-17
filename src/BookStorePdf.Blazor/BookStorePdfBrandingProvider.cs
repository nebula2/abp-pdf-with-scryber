using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace BookStorePdf.Blazor;

[Dependency(ReplaceServices = true)]
public class BookStorePdfBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "BookStorePdf";
}
