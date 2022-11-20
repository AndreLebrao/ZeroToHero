using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace ZeroToHero.Localization
{
    public static class ZeroToHeroLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(ZeroToHeroConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(ZeroToHeroLocalizationConfigurer).GetAssembly(),
                        "ZeroToHero.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
