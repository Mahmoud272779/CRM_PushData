using App.Domain.Models.Shared;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static App.Domain.Enums.Enums;

namespace App.Core.Handler.ERPTool.ReCreateJournalEntry
{
    public class ReCreateJournalEntryRequest : ERPToolsValidationProps,IRequest<ResponseResult>
    {
        public ERPTool_CreateJournalEntry type { get; set; }
    }
}
