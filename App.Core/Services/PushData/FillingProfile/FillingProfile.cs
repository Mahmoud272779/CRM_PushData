using System.Data.SqlClient;
using App.Core.Handler;
using App.Domain.Models.Shared;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace App.Core.Services
{
    public class FillingProfile
    {
        public static async Task fillProfile(string[] machineSNs, SqlConnection con, IConfiguration _configuration)
        {
            var companiesSNs = machineSNs.Where(c => !profile.companies.Select(x => x.machineSN).Contains(c)).ToArray();
            if (!companiesSNs.Any())
                return;
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();

            con.ConnectionString = _configuration["ConnectionStrings:UserManagerQLConnection"];
            con.Open();
            var formattedCompaniesSNs = string.Join(",", companiesSNs.Select(c => "'" + c + "'"));


            try
            {
                var query = $@"
							SELECT 
							    t1.machineSN, 
							    t2.databaseName, 
							    t2.companyLogin 
							FROM 
							    ERP_UsersManager3.dbo.AttendanceLeavingMachines t1 
							JOIN 
							    ERP_UsersManager3.dbo.UserApplication t2 
							ON  
							    t1.userApplicationId = t2.id 
							WHERE 
							    t1.machineSN IN ({formattedCompaniesSNs})";
                var companies = con.Query<AttendanceMachineCompanies>(query).ToList();
                profile.companies.AddRange(companies);
                var compamiesNotExist = machineSNs.Where(c => !profile.companies.Select(x => x.machineSN).Contains(c)).GroupBy(c => c).Select(c => new AttendanceMachineCompanies { machineSN = c.FirstOrDefault() });
                if (compamiesNotExist.Any())
                {
                    profile.companiesNotExist.AddRange(compamiesNotExist);
                }


            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
                GC.Collect();
                GC.WaitForFullGCApproach();
            }


        }
    }
}
