

using System.Text;
using Microsoft.Extensions.Configuration;

namespace App.Core.Helper
{
	public class ConnectionString
	{
		public static string Builder(IConfiguration _configuration,string databaseName)
		{
			StringBuilder sb = new StringBuilder();
			sb.Append($"Data Source={_configuration["ApplicationSettings:Server"]};");
			sb.Append($"Initial Catalog={databaseName};");
			sb.Append($"user id=sa;password={_configuration["ApplicationSettings:Password"]};");
			sb.Append($"MultipleActiveResultSets=true;TrustServerCertificate=True;");
			return sb.ToString();
		}
	}
}
