using baffis.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace baffis.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class baffisPageModel : AbpPageModel
{
    protected baffisPageModel()
    {
        LocalizationResourceType = typeof(baffisResource);
    }
}
