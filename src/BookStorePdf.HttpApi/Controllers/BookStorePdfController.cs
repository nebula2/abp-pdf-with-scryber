using BookStorePdf.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace BookStorePdf.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class BookStorePdfController : AbpControllerBase
{
    protected BookStorePdfController()
    {
        LocalizationResource = typeof(BookStorePdfResource);
    }
}
