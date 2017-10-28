using System;
using System.Collections.Generic;
using System.Text;
using YesPojiUtmLib.Enums;
using YesPojiUtmLib.Models;

namespace YesPojiUtmLib.Events
{
    public class Events
    {
        public delegate void SessionDataUpdateEvent(YesSessionData data);
        public delegate void LoginFailedEvent(LoginStatus reason);

        public delegate void SimpleEvent();
    }
}
