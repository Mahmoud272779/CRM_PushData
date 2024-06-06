using App.Domain.Entities;
using App.Domain.Models.Shared;
using App.Infrastructure.DefultData;
using App.Infrastructure.Interfaces.Repository;
using MediatR;
using static App.Domain.Enums.Enums;

namespace App.Core.Handler.PermissionLists.EditPermission
{
    public class EditPermissionHandler : IRequestHandler<EditPermissionRequest, ResponseResult>
    {
        private readonly IRepositoryCommand<PermissionList> _PermissionListCommand;
        private readonly IRepositoryQuery<PermissionList> _PermissionListQuery;

        public EditPermissionHandler(IRepositoryCommand<PermissionList> permissionListCommand, IRepositoryQuery<PermissionList> permissionListQuery)
        {
            _PermissionListCommand = permissionListCommand;
            _PermissionListQuery = permissionListQuery;
        }

        public async Task<ResponseResult> Handle(EditPermissionRequest request, CancellationToken cancellationToken)
        {
            var checkIsArabicNameExist = _PermissionListQuery.TableNoTracking;
            if (checkIsArabicNameExist.Where(x => x.arabicName == request.arabicName && x.Id != request.Id).Any())
                return new ResponseResult
                {
                    ErrorMessageAr = ErrorMessagesAr.PermissionListIsExist,
                    ErrorMessageEn = ErrorMessagesEN.PermissionListIsExist,
                    Result = Result.Failed
                };
            var permissionList = checkIsArabicNameExist.Where(x => x.Id == request.Id).FirstOrDefault();
            permissionList.arabicName = request.arabicName;
            permissionList.latinName = request.latinName;
            var edited = await _PermissionListCommand.UpdateAsyn(permissionList);
            return new ResponseResult
            {
                Result = edited ? Result.Success : Result.Failed,
            };
        }
    }
}
