using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Core.Helper;
using App.Core.Services.NewFolder;
using App.Core.Services.PushData;
using Microsoft.Extensions.Configuration;

namespace App.Core.Services.PushDataChain
{
	public class PushDataChain : IPushDataChain
	{
		private readonly IRestfulAPIService _restfulAPIService;
		private readonly IConfiguration _configuration;

		public PushDataChain(IRestfulAPIService restfulAPIService, IConfiguration configuration)
		{
			_restfulAPIService = restfulAPIService;
			_configuration = configuration;
		}

		public async Task IPush()
		{
			SqlConnection con = new SqlConnection();
			var data = GettingFingerPrints.Get(_restfulAPIService, _configuration);
			await FillingProfile.fillProfile(data.Select(x => x.MachinSN).ToArray(), con, _configuration);
			var storeData = await StorePushDataInCustomerDB.Store(data, con, _configuration);
            await StorePushDataForCompaniesNotExist.Store(data,con,_configuration);
            if (storeData)
			{
				UpdateFingerPrints.Update(_restfulAPIService, _configuration);
				await NotificationCaller.call(_restfulAPIService, data.ToList(),_configuration);
			}
		}
	}
}
