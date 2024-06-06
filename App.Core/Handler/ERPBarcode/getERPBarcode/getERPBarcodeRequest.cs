using App.Domain.Models.Shared;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Handler.ERPBarcode
{
    public class getERPBarcodeRequest : IRequest<ResponseResult>
    {
        public int companyId { get; set; }
    }
}
