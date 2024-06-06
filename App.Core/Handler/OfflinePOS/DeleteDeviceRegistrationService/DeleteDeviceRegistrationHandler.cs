using App.Domain.Models.Shared;
using App.Infrastructure.ERPContext;
using App.Infrastructure.UserManagementDB;
using MediatR;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Handler.OfflinePOS.DeleteDeviceRegistrationService
{
    public class DeleteDeviceRegistrationHandler : IRequestHandler<DeleteDeviceRegistrationRequest, ResponseResult>
    {
        private readonly IConfiguration _configuration;
        public DeleteDeviceRegistrationHandler(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<ResponseResult> Handle(DeleteDeviceRegistrationRequest request, CancellationToken cancellationToken)
        {
            ErpUsersManagerContext manager_Context = new ErpUsersManagerContext(_configuration);
            var dbName = manager_Context.UserApplications.AsNoTracking().FirstOrDefault(c => c.CompanyLogin == request.companyLogin)?.DatabaseName ?? string.Empty;
            if (dbName == string.Empty)
                return new ResponseResult
                {
                    Result = Domain.Enums.Enums.Result.Failed,
                    ErrorMessageAr = "هذه الشركة غير موجودة",
                    ErrorMessageEn = "This company is not exist"
                };
            ApexERPContext erp_Context = new ApexERPContext(_configuration, dbName);
            //check the device 
            var device = erp_Context.PosOfflineDevices.AsNoTracking().FirstOrDefault(c => c.DeviceSerial == request.deviceSerial);
            if (device == null)
                return new ResponseResult
                {
                    Result = Domain.Enums.Enums.Result.Failed,
                    ErrorMessageAr = "هذا الجهاز غير موجود",
                    ErrorMessageEn = "This device is not exist"
                };
            device.DeleteWaiting = true;
            erp_Context.PosOfflineDevices.Update(device);
            var saved = erp_Context.SaveChanges() > 0;
            return new ResponseResult
            {
                Result = saved ? Domain.Enums.Enums.Result.Success : Domain.Enums.Enums.Result.Failed,
                ErrorMessageAr = saved ? "": "حدث خطأ أثناء الحفظ",
                ErrorMessageEn = saved ? "":"Error while saving"
            };

        }
    }
}
