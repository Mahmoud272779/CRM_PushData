using App.Domain.Models.Shared;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Handler.ReportsSystem.ReportHistory
{
    public class reporthistoryRequest : IRequest<ResponseResult>
    {
        public int companyId { get; set; }
        public int screenId { get; set; }
    }
}
