using App.Core.Helper;
using App.Domain.Models.Shared;
using App.Infrastructure.DefultData;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace App.Core.Services
{
	public class UpdateFingerPrints
	{
		public static bool Update(IRestfulAPIService _restfulAPIService, IConfiguration configuration)
		{
			try
			{
				var header = new (string key, string value)[]
				{
					new ("key", defultData.userManagmentApplicationSecurityKey)
				};
				var data = _restfulAPIService.Call(new RestfulAPICallingDTO
				{
					Method = HttpMethod.Put,
					BaseUrl = configuration["PushDataConfiguration:BaseURL"],
					APIPath = "api/FingerPrintHandler/UpdateFingerPrints",
					Headers = header
				}).Result;
				var response =  JsonConvert.DeserializeObject<PushdataResponse>(data);
				if (response.result == 1) return true;
				else return false;
			}
			catch (Exception)
			{
				return false;
			}
			finally
			{
				GC.Collect();
				GC.WaitForFullGCApproach();
			}

		}
	}
}
