using App.Domain.Models.Shared;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace App.Core.Handler.users
{
    public class GetAllUsersRequest : PaginiationDTO,IRequest<ResponseResult>
    {
        public string SearchCriteria { get; set; }
    }
    public class imageToBase64
    {
        public IFormFile file { get; set; }
    }
}
