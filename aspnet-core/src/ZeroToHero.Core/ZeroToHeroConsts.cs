using ZeroToHero.Debugging;

namespace ZeroToHero
{
    public class ZeroToHeroConsts
    {
        public const string LocalizationSourceName = "ZeroToHero";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "f397d87080104ab387b36fdb0ece3690";
    }
}
