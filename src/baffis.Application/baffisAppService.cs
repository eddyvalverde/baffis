using System;
using System.Collections.Generic;
using System.Text;
using baffis.Localization;
using Volo.Abp.Application.Services;

namespace baffis;

/* Inherit your application services from this class.
 */
public abstract class baffisAppService : ApplicationService
{
    protected baffisAppService()
    {
        LocalizationResource = typeof(baffisResource);
    }
}
