using Nc.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Nc.Permissions
{
    public class NcPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(NcPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(NcPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<NcResource>(name);
        }
    }
}
