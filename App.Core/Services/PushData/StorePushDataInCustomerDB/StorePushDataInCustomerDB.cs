using System.Data.SqlClient;
using System.Text;
using App.Core.Handler;
using App.Core.Helper;
using App.Domain.Models.Shared;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace App.Core.Services.NewFolder
{
	public class StorePushDataInCustomerDB
	{

		
		public static async Task<bool> Store(List<PushDataSchema> pushData, SqlConnection con, IConfiguration _configuration)
		{
			var pushDataGroupedByMachineSN = pushData.GroupBy(c => c.MachinSN).Select(g => new { machineSN = g.Key, items = g.ToList() });
			if (con.State == System.Data.ConnectionState.Open)
				con.Close();


			

            con.Close();
            foreach (var pushDataRow in pushDataGroupedByMachineSN)
			{
				try
				{
					var databaseName = profile.companies.FirstOrDefault(c=> c.machineSN == pushDataRow.machineSN)?.databaseName ?? null;
					if (string.IsNullOrEmpty(databaseName)) continue;

					con.ConnectionString = ConnectionString.Builder(_configuration, databaseName);
					con.Open();

					StringBuilder AddQuery = new StringBuilder();
					AddQuery.AppendLine("begin transaction;");
					foreach (var item in pushDataRow.items)
					{
						AddQuery.AppendLine($@"INSERT INTO {databaseName}.dbo.MachineTransactions 
										(EmployeeCode, TransactionDate, EditedTransactionDate, machineId, IsMoved, isAuto, IsEdited, PushTime)
										SELECT
											{item.EmployeeCode},
											'{item.TransactionDate}',
											GETDATE(),
											(SELECT TOP(1) Id FROM {databaseName}.dbo.Machines WHERE MachineSN = '{pushDataRow.machineSN}'),
											0,
											1,
											0,
											GETDATE())");
										//WHERE NOT EXISTS (
										//	SELECT 1 
										//	FROM {databaseName}.dbo.MachineTransactions 
										//	WHERE EmployeeCode = {item.EmployeeCode} 
										//	  AND TransactionDate = '{item.TransactionDate}' 
										//);");
					}
					AddQuery.AppendLine("commit;");
					var TransactionQuery = AddQuery.ToString();
					var IsAdded = con.Execute(TransactionQuery) > 0 ? true : false;
					con.Close();
			 
					//return true;
					if (!IsAdded)
					{
						throw new Exception();
					}
					AddQuery = null;
					if (!IsAdded) return IsAdded;
				}
				catch (Exception ex)
				{
					return false;
				}
				finally
				{
					con.Close();
					GC.Collect();
					GC.WaitForFullGCApproach();
				}

			}
			return true;

		}
	}


}
