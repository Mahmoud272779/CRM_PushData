using App.Domain.Models.Shared;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Handler.ERPTool.DeleteData
{
    public class DeleteDataRequest : ERPToolsValidationProps, IRequest<ResponseResult>
    {
        public DeleteDataType type { get; set; }
    }
    public enum DeleteDataType
    {
        MainData = 0,
        Doc = 1
    }
}
