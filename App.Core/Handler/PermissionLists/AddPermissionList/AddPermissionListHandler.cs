using App.Core.Handler.PermissionLists.AddPermissionList;
using App.Domain.Entities;
using App.Domain.Models.Shared;
using App.Infrastructure.DefultData;
using App.Infrastructure.Interfaces.Repository;
using MediatR;
using static App.Domain.Enums.Enums;

namespace App.Core.Handler.PermissionLists
{
    public class AddPermissionListHandler : IRequestHandler<AddPermissionListRequest, ResponseResult>
    { 
        private readonly IRepositoryCommand<PermissionList> _PermissionListCommand;
        private readonly IRepositoryQuery<PermissionList> _PermissionListQuery;

        public AddPermissionListHandler(IRepositoryCommand<PermissionList> permissionListCommand, IRepositoryQuery<PermissionList> permissionListQuery)
        {
            _PermissionListCommand = permissionListCommand;
            _PermissionListQuery = permissionListQuery;
        }

        public async Task<ResponseResult> Handle(AddPermissionListRequest request, CancellationToken cancellationToken)
        {
            var checkIsArabicNameExist = _PermissionListQuery.TableNoTracking.Where(x => x.arabicName == request.arabicName);
            if (checkIsArabicNameExist.Any())
                return new ResponseResult
                {
                    ErrorMessageAr = ErrorMessagesAr.PermissionListIsExist,
                    ErrorMessageEn = ErrorMessagesEN.PermissionListIsExist,
                    Result = Result.Failed
                };
            var tableRow = new PermissionList()
            {
                arabicName = request.arabicName,
                latinName = request.latinName,
                 note = request.note
            };
            var Added = await _PermissionListCommand.AddAsync(tableRow);
            return new ResponseResult
            {
                Result = Added ? Result.Success : Result.Failed
            };
        }
    }
}
