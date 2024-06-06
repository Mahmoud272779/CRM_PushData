using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using App.Core.Helper;
using App.Domain.Models.Shared;
using App.Infrastructure.DefultData;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace App.Core.Services
{
	public class GettingFingerPrints
	{
		public static List<PushDataSchema> Get(IRestfulAPIService _restfulAPIService,IConfiguration configuration)
		{			
			try
			{
				var header = new (string key, string value)[]
				{
					new ("key", defultData.userManagmentApplicationSecurityKey)
				};
				var data = _restfulAPIService.Call(new RestfulAPICallingDTO
				{
					Method = HttpMethod.Get,
					BaseUrl = configuration["PushDataConfiguration:BaseURL"],
					APIPath = "api/FingerPrintHandler/GetFingerPrints",
					Headers = header,
				}).Result;
				var response =  JsonConvert.DeserializeObject<PushdataResponse>(data);
				if (response.result == 1)
					return JsonConvert.DeserializeObject<List<PushDataSchema>>(response.Data.ToString());
				else
					return null;
			}
			catch (Exception)
			{

				throw;
			}
			finally 
			{
				GC.Collect();
				GC.WaitForFullGCApproach();
			}

		}
	}
}
