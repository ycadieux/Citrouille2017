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

        public void Reset()
        {
            Clients.All.reset();
        }

        public void Continuer()
        {
            Clients.All.continuer();
        }

        public void VolDown()
        {
            Clients.All.volDown();
        }

        public void VolUp()
        {
            Clients.All.volUp();
        }
    }
}