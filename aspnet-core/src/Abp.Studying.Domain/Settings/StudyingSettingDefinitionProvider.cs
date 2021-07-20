using Volo.Abp.Settings;

namespace Abp.Studying.Settings
{
    public class StudyingSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(StudyingSettings.MySetting1));
        }
    }
}
