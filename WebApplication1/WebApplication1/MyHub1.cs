using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace WebApplication1
{
    public class myHub1 : Hub
    {
        public void Hello(string name, string msg)
        {
            Clients.All.hello(name,msg);
        }
    }
}