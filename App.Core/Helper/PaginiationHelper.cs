using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Helper
{
    public static class PaginiationHelper
    {
        public static string ReturnEndOfDataNote(int pageNumber,int pageSize,int itemsCount)
        {
            double MaxPageNumber = itemsCount / Convert.ToDouble(pageSize);
            var countofFilter = Math.Ceiling(MaxPageNumber);
            return countofFilter == pageNumber ? "End Of Data" : "";
        }
    }
}
