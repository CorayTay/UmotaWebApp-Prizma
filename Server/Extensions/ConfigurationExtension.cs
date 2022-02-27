﻿using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UmotaWebApp.Server.Extensions
{
    public static class ConfigurationExtension
    {
        public static string GetUmotaConnectionString(this IConfiguration configuration, string firmaId = null)
        {
            var dbname = configuration["masterDbName"];
            var dbUser = configuration["masterDbUser"];
            var dbPassword = configuration["masterDbPassword"];
            var dbServer = configuration["masterServer"];

            if (!string.IsNullOrEmpty(firmaId))
                dbname = dbname + "_00" + firmaId;

            return string.Format("Server={0};Database={1};user={2};password={3};",
                dbServer, dbname, dbUser, dbPassword);
        }

        public static string GetUmotaObjectName(this IConfiguration configuration,string objectName, string firmaId = null)
        {
            var dbname = configuration["masterDbName"];
            
            if (!string.IsNullOrEmpty(firmaId))
                dbname = dbname + "_00" + firmaId;

            return string.Format("[{0}].[dbo].[{1}]", dbname, objectName);
        }
    }
}