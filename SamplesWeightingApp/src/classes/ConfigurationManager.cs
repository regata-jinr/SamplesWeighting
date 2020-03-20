using Microsoft.Extensions.Configuration;

namespace SamplesWeighting
{
    internal class ConfigurationManager
    {
        private static IConfiguration _iconfig;

        static ConfigurationManager()
        {
            _iconfig = new ConfigurationBuilder().
                           AddUserSecrets<ConfigurationManager>().
                           Build();

#if DEBUG
            ConnectionString = @"Data Source=RUMLAB\REGATALOCAL;Initial Catalog=NAA_DB_TEST;Integrated Security=True;User ID=bdrum";
#else
            ConnectionString = _iconfig["ConnectionString"];
#endif
        }

        public static readonly string ConnectionString;

    }
}

