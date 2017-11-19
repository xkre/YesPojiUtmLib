using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YesPojiUtmLib.Enums;
using YesPojiUtmLib.Models;

namespace YesPojiUtmLib.Services
{
    public interface IYesLoginService
    {
        Task<LoginStatus> LoginAsync(string username, string password);
        Task<LoginStatus> LoginAsync(YesAccount a);

        Task<bool> LogoutAsync();

        Task<String> GetLoginKey();
    }
}
