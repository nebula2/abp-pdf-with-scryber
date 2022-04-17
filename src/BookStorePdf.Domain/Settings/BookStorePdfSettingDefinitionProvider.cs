using Volo.Abp.Settings;

namespace BookStorePdf.Settings;

public class BookStorePdfSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(BookStorePdfSettings.MySetting1));
    }
}
