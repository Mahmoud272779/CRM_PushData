using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Models.Shared
{
    public class Delete
    {
        public int[] ids { get; set; }
    }
    public class PaginiationDTO
    {
        public int pageNumber { get; set; } = 1;
        public int pageSize { get; set; } = 5;
    }
}
