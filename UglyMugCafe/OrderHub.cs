using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UglyMugCafe.Models;

namespace UglyMugCafe
{
    public class OrderHub : Hub
    {
        public void SendToAll(Order order)
        {
            Clients.All.SendAsync("sendToAll", order);
        }
    
    }
}
