using App.Domain.Models.Shared;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static App.Domain.Enums.Enums;

namespace App.Core.Handler.ERPTool.ReCreateCustomerFA
{
    public class ReCreateCustomerSupplierFARequest : ERPToolsValidationProps,IRequest<ResponseResult>
    {
        public int newParentId { get; set; }
        public int OldAccountId { get; set; }
        public PersonTypes types { get; set; }
    }
}
