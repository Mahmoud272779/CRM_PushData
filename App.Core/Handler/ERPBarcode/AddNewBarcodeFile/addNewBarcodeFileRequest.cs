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
    public class addNewBarcodeFileRequest : IRequest<ResponseResult>
    {
        public int companyId { get; set; }
        public IFormFile file { get; set; }
        public string fileNameAr { get; set; }
        public string fileNameEn { get; set; }
    }
}
