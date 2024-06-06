using App.Core.Handler;
using App.Domain.Models.Shared;
using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Text;

namespace App.Core.Services.PushData
{
    public class StorePushDataForCompaniesNotExist
    {
        public static async Task Store(List<PushDataSchema> pushData, SqlConnection con, IConfiguration _configuration)
        {
            // store companies not exist 
            var dataForCompaniesNotExist = pushData.Where(c => profile.companiesNotExist.Select(x => x.machineSN).Contains(c.MachinSN));
            StringBuilder companiesNotExistSB = new StringBuilder();
            companiesNotExistSB.AppendLine("begin transaction;");

            foreach (var item in dataForCompaniesNotExist)
            {
                companiesNotExistSB.AppendLine($"INSERT INTO [dbo].[tempMachineMoves] " +
                    $"([EmployeeCode] " +
                    $",[machineSN] " +
                    $",[TransactionDate] " +
                    $",[PushTime] " +
                    $",[isMoved]) " +
                    $"VALUES " +
                    $"({item.EmployeeCode}" +
                    $",'{item.MachinSN}'" +
                    $",'{item.TransactionDate}'" +
                    $",GetDate()" +
                    $",0);");

            }
            companiesNotExistSB.AppendLine("commit;");
            con.ConnectionString = _configuration["ConnectionStrings:UserManagerQLConnection"];
            con.Open();
            await con.ExecuteAsync(companiesNotExistSB.ToString());
        }
    }
}
