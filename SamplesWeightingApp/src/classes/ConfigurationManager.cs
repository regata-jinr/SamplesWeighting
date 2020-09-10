/***************************************************************************
 *                                                                         *
 *                                                                         *
 * Copyright(c) 2017-2020, REGATA Experiment at FLNP|JINR                  *
 * Author: [Boris Rumyantsev](mailto:bdrum@jinr.ru)                        *
 * All rights reserved                                                     *
 *                                                                         *
 *                                                                         *
 ***************************************************************************/

using Microsoft.Extensions.Configuration;
using System;

namespace SamplesWeighting
{
    internal static  class ConfigurationManager
    {
        public static readonly IConfiguration config;

        static ConfigurationManager()
        {
            config = new ConfigurationBuilder().
                           SetBasePath(AppContext.BaseDirectory).
                           AddJsonFile("labels.json").
                           Build();
            ComPort = config["COM"];
#if DEBUG
            ConnectionString = @"Data Source=RUMLAB\REGATALOCAL;Initial Catalog=NAA_DB_TEST;Integrated Security=True;User ID=bdrum";
            config["ConnectionString"] = ConnectionString;
#else
            ConnectionString = config["ConnectionString"];
#endif
        }

        public static readonly string ConnectionString;

        public static readonly string ComPort;

    }
}

