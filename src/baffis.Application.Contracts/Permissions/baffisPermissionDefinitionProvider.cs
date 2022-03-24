using baffis.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace baffis.Permissions;

public class baffisPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(baffisPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(baffisPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<baffisResource>(name);
    }
}
