using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace baffis.Web;

[Dependency(ReplaceServices = true)]
public class baffisBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "baffis";
}
