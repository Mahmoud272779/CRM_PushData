using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Models.Shared
{
	public class PushDataSchema
	{
		public int id { get; set; }
		public string MachinSN { get; set; }
		public string TransactionDate { get; set; }
		public string EmployeeCode { get; set; }

	}
}
