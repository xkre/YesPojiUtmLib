﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YesPojiUtmLib.Exceptions
{
    public class YesNotConnectedException : Exception
    {
        public YesNotConnectedException(string message) : base(message)
        {
        }
    }
}
