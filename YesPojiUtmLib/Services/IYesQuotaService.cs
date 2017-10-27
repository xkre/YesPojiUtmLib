using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YesPojiUtmLib.Models;

namespace YesPojiUtmLib.Services
{
    interface IYesQuotaService
    {
        Task<double> GetQuotaAsync(string username);
        Task<double> GetQuotaAsync(Account a);

        double GetMaxQuota(string Username);
    }
}
