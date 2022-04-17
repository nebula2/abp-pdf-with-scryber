using System;
using System.Collections.Generic;
using System.Text;
using BookStorePdf.Localization;
using Volo.Abp.Application.Services;

namespace BookStorePdf;

/* Inherit your application services from this class.
 */
public abstract class BookStorePdfAppService : ApplicationService
{
    protected BookStorePdfAppService()
    {
        LocalizationResource = typeof(BookStorePdfResource);
    }
}
