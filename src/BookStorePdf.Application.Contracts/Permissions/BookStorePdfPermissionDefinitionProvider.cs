using BookStorePdf.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace BookStorePdf.Permissions;

public class BookStorePdfPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(BookStorePdfPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(BookStorePdfPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<BookStorePdfResource>(name);
    }
}
