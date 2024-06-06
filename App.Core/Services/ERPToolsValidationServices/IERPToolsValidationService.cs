using App.Domain.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Services.ERPToolsValidationServices
{
    public interface IERPToolsValidationService
    {
        public Task<bool> ERPToolsValidation(ERPToolsValidationProps request);
        public Task<string> ERPLogin(string companyName, string username,string password);
    }
}
