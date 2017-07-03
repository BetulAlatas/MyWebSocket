using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Web.WebSockets;
using System.Net.WebSockets;

namespace MyWebSocket
{
    /// <summary>
    /// Summary description for WebSocket
    /// </summary>
    public class WebSocket : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {

            if (context.IsWebSocketRequest)
            {
                context.AcceptWebSocketRequest(new MicrosoftWebSockets());
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}