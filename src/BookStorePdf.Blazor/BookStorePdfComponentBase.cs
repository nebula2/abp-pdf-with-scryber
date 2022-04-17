using BookStorePdf.Localization;
using Volo.Abp.AspNetCore.Components;

namespace BookStorePdf.Blazor;

public abstract class BookStorePdfComponentBase : AbpComponentBase
{
    protected BookStorePdfComponentBase()
    {
        LocalizationResource = typeof(BookStorePdfResource);
    }
}
