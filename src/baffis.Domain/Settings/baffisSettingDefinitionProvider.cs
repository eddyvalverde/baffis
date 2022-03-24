using Volo.Abp.Settings;

namespace baffis.Settings;

public class baffisSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(baffisSettings.MySetting1));
    }
}
