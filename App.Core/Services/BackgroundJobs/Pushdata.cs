using App.Core.Helper;
using App.Core.Services.PushDataChain;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace App.Core.BackgroundJobs
{
	public class Pushdata : BackgroundService
	{
		private readonly IRestfulAPIService _restfulAPIService;
		private readonly IConfiguration _configuration;

		public Pushdata(IRestfulAPIService restfulAPIService, IConfiguration configuration)
		{
			_restfulAPIService = restfulAPIService;
			_configuration = configuration;
		}

		protected override async Task ExecuteAsync(CancellationToken stoppingToken)
		{
			await DoWork(stoppingToken);
		}
		private async Task DoWork(CancellationToken stoppingToken)
		{
			if (_configuration["RunDoWork:Run"] == "1")
			{
				await Task.Delay((int)TimeSpan.FromSeconds(10).TotalMilliseconds, stoppingToken);
				IPushDataChain chain = new PushDataChain(_restfulAPIService, _configuration);
				try
				{
					await chain.IPush();

				}
				catch (Exception)
				{

				}
				finally
				{
					chain = null;
					GC.Collect();
					GC.WaitForFullGCApproach();
				}
				DoWork(stoppingToken);
			}

		}
	}
}
