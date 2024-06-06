using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Helper
{
    public static class ConHelper
    {
        public static string BuildConnectionString(IConfiguration configuration,string databseName)
        {
            string connectionString = string.Empty;
            var server =   configuration["ApplicationSettings:server"];
            var UserId =   configuration["ApplicationSettings:UserId"];
            var Password = configuration["ApplicationSettings:Password"];
            connectionString = $"Data Source={server};Initial Catalog={databseName};user id={UserId};password={Password};MultipleActiveResultSets=true;TrustServerCertificate=True;";

            return connectionString;
        }
    }
}
