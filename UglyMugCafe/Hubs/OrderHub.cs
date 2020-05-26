using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UglyMugCafe.Models;

namespace UglyMugCafe.Hubs
{
    public class OrderHub : Hub
    {
        public async Task NewOrder(OrderContent order)
        {
            await Clients.All.SendAsync("OrderReceived", order);
        }

    }
}
