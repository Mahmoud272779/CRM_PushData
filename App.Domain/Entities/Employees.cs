using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Entities
{
    public class Employees
    {
        public int Id { get; set; }
        public string arabicName { get; set; }
        public string latinName { get; set; }
        public string? Note { get; set; }
        public ICollection<Users> users { get; set; }
        public ICollection<SystemLogsHistory> SystemLogsHistory { get; set; }

    }
}
