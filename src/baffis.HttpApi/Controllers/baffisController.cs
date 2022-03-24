using baffis.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace baffis.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class baffisController : AbpControllerBase
{
    protected baffisController()
    {
        LocalizationResource = typeof(baffisResource);
    }
}
