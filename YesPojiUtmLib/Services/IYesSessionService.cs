using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YesPojiUtmLib.Models;

namespace YesPojiUtmLib.Services
{
    public interface IYesSessionService
    {
        Task<YesSessionData> GetSessionDataAsync();
        Task<string> GetRawSessionDataAsync();

        YesSessionData ParseSession(string rawHtml);
    }
}
