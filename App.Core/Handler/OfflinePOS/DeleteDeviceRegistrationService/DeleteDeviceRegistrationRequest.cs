using App.Domain.Models.Shared;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Handler.OfflinePOS.DeleteDeviceRegistrationService
{
    public class DeleteDeviceRegistrationRequest : IRequest<ResponseResult>
    {
        public string companyLogin { get; set; }
        public string deviceSerial { get; set; }
    }
}
