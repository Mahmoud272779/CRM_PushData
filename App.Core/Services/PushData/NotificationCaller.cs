using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Core.Handler;
using App.Core.Helper;
using App.Domain.Models.Shared;
using App.Infrastructure.DefultData;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace App.Core.Services
{
	public class NotificationCaller
	{
		public static async Task call(IRestfulAPIService restfulAPIService,List<PushDataSchema> data,IConfiguration _configuration)
		{

			foreach (var item in data)
			{
				var MachineProfile = profile.companies.FirstOrDefault(c => c.machineSN == item.MachinSN);
				if (MachineProfile == null) continue;
				PushDataNotificationERPAPI fingerPrintData = new PushDataNotificationERPAPI
				{
					employeeCode = item.EmployeeCode,
					name = "",
					transactionDate = item.TransactionDate,
					companyLogin = MachineProfile.companyLogin,
					databaseName = MachineProfile.databaseName,
					MahcineSN =item.MachinSN,
					SecKey = defultData.userManagmentApplicationSecurityKey
					
				};
				await restfulAPIService.Call(new RestfulAPICallingDTO
				{
					BaseUrl = _configuration["ERPUrls:BackURL"],
					APIPath = "/api/HR/PushDataServices/PushDataAPI",
					Method = HttpMethod.Post,
					Body = JsonConvert.SerializeObject(fingerPrintData)
				});
			}
		}
	}
	public class PushDataNotificationERPAPI
	{
		public string employeeCode { get; set; }
		public string name { get; set; }
		public string transactionDate { get; set; }
		public string MahcineSN { get; set; }
		public string SecKey { get; set; }
		public string databaseName { get; set; }
		public string companyLogin { get; set; }
	}
}
