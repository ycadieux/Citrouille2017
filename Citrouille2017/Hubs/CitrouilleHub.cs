using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace Citrouille2017.Hubs
{
    public class CitrouilleHub : Hub
    {
        public void Start()
        {
            Clients.All.start();
        }
    }
}