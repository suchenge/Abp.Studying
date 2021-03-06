using Abp.Studying.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Abp.Studying.Permissions
{
    public class StudyingPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(StudyingPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(StudyingPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<StudyingResource>(name);
        }
    }
}
