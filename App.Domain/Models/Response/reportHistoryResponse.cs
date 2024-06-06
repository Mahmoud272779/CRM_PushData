using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Models.Response
{
    public class reportHistoryResponse
    {
        public int Id { get; set; }
        public string note { get; set; }
        public byte[] oldFile { get; set; }
        public byte[] newFile { get; set; }
        public DateTime date { get; set; }
        public string employeeArabicName { get; set; }
    }
}
