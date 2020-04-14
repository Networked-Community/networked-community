using Volo.Abp.Settings;

namespace Nc.Settings
{
    public class NcSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(NcSettings.MySetting1));
        }
    }
}
