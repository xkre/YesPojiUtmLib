using System;
using System.Collections.Generic;
using System.Text;

namespace YesPojiUtmLib.Models
{
    public interface IAccount
    {
        int AccountId { get; set; }
        string Username { get; set; }
        string Password { get; set; }

    }
}
