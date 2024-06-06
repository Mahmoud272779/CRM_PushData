using App.Domain.Models.Request.PermissionList;
using App.Domain.Models.Shared;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Handler.PermissionLists.EditPermission
{
    public class EditPermissionRequest : EditPermissionRequestDTO, IRequest<ResponseResult>
    {
    }
}
