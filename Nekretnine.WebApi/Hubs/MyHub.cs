using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
namespace Nekretnine.WebApi.Hubs
{
    public class MyHub:Hub
    {
        //public async Task SendMessage(string user, string to, string message)
        //{
        //    await Clients.All.SendAsync("ReceiveMessage", user, to, message);
        //}

    }
}
