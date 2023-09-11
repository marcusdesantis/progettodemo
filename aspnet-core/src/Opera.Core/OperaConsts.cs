using Opera.Debugging;

namespace Opera
{
    public class OperaConsts
    {
        public const string LocalizationSourceName = "Opera";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "5ac77318cb8244cd9ccf1787e956397f";
    }
}
