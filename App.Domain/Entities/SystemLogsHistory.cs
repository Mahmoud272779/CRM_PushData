using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Entities
{
    public class SystemLogsHistory
    {
        public int Id { get; set; }
        public int EmployeesId { get; set; }
        public byte[]? OldFile { get; set; }
        public byte[]? NewFile { get; set; }
        public int actionId { get; set; }
        public int companyId { get; set; }
        public int screenId { get; set; }
        public int? reportId { get; set; }
        public string Note { get; set; }
        public DateTime date { get; set; }
        public Employees Employees { get; set; }
    }
}
