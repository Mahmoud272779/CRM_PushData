using App.Domain.Models.Shared;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Handler.ERPBarcode
{
    public class ReplaceBarcodeFileRequest : IRequest<ResponseResult>
    {
        public int companyId { get; set; }
        public int fileId { get; set; }
        public IFormFile file { get; set; }
    }
}
