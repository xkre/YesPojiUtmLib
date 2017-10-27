using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YesPojiUtmLib.Enums;

namespace YesPojiUtmLib.Services
{
    interface IYesNetworkService
    {
        Task<NetworkCondition> GetNetworkConditionAsync();
        Task<bool> IsConnectedToYesAsync();
    }
}
