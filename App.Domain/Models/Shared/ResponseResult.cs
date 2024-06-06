using System;
using static App.Domain.Enums.Enums;

namespace App.Domain.Models.Shared
{
    public class ResponseResult
    {
        public Result Result { get; set; }
#nullable enable
        public object? DataCount { get; set; }
        public object? Data { get; set; }
        public int? Id { get; set; }
        public int? Code { get; set; }
        public string? Note { get; set; } // notes for front
        public int TotalCount { get; set; } // Count in Table
        public string ErrorMessageAr { get; set; }
        public string ErrorMessageEn { get; set; }
        public double Total { get; set; }
        public string dateTimeNow { get; set; } = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
    }
}
