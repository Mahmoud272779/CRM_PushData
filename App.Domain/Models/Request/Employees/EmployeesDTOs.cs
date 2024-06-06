using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Models.Request.Employees
{
    public class AddEmployeesDTO
    {
        public string arabicName { get; set; }
        public string latinName { get; set; }
        public string? Note { get; set; }
    }
    public class EditEmployeesDTO : AddEmployeesDTO
    {
        public int Id { get; set; }
    }
}
