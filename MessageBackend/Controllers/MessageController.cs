using MessageBackend.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Models;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MessageBackend.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        IHubContext<SignalRHub> hub;

        private static List<Message> messages = new List<Message>();

        public MessageController(IHubContext<SignalRHub> hub)
        {
            this.hub = hub;
        }
    }
}
