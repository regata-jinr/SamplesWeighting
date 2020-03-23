using Microsoft.Extensions.Configuration;
using System;

namespace SamplesWeighting
{
    internal class ConfigurationManager
    {
        public static readonly IConfiguration config;

        static ConfigurationManager()
        {
            config = new ConfigurationBuilder().
                           SetBasePath(AppContext.BaseDirectory).
                           AddJsonFile("labels.json").
                           AddUserSecrets<ConfigurationManager>().
                           Build();

#if DEBUG
            ConnectionString = @"Data Source=RUMLAB\REGATALOCAL;Initial Catalog=NAA_DB_TEST;Integrated Security=True;User ID=bdrum";
            config["ConnectionString"] = ConnectionString;
#else
            ConnectionString = config["ConnectionString"];
#endif
        }

        public static readonly string ConnectionString;

    }
}

