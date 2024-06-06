using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Entities
{
    public class PermissionList
    {
        public int Id { get; set; }
        public string arabicName { get; set; }
        public string latinName { get; set; }
        public string? note { get; set; }
        public ICollection<Rules> rules { get; set; }
        public ICollection<Users> users { get; set; }
    }
}
