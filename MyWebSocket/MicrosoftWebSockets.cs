using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Web.WebSockets;

namespace MyWebSocket
{
    public class MicrosoftWebSockets : WebSocketHandler
    {

        private static readonly WebSocketCollection WebSocketCollection = new WebSocketCollection();
        private string Name;


        public override void OnOpen()
        {
            Name = this.WebSocketContext.QueryString["chatName"];
            WebSocketCollection.Add(this);
            WebSocketCollection.Broadcast(Name + " sohbete katıldı");
        }

        public override void OnMessage(string message)
        {
            WebSocketCollection.Broadcast($"{Name} diyor ki : {message} ");
        }

        public override void OnClose()
        {
            WebSocketCollection.Remove(this);
        }
    }
}