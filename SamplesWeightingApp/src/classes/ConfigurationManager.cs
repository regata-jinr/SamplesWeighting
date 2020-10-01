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
                           AddJsonFile("settings.json").
                           AddJsonFile("labels.json").
                           Build();

            var cm = SecretsManager.GetCredential("WeightingApp");

            ComPort  = config["COM"];

            ushort parsed_value = 0;
            ushort.TryParse(config["accuracy_weight"], out parsed_value);

            if (parsed_value != 0) AccuracyWeight = parsed_value;

            parsed_value = 0;
            ushort.TryParse(config["accuracy_diff"], out parsed_value);
            if (parsed_value != 0) AccuracyDiff = parsed_value;
#if DEBUG
            ConnectionString = @"Data Source=RUMLAB\REGATALOCAL;Initial Catalog=NAA_DB_TEST;Integrated Security=True;User ID=bdrum";
#else
            ConnectionString = cm.Secret;
#endif
        }

        public static readonly string ConnectionString;
        public static readonly string ComPort;
        public static readonly ushort AccuracyWeight = 4;
        public static readonly ushort AccuracyDiff = 1;
    }
}

