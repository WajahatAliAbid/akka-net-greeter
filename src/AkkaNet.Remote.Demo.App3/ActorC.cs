using System;
using Akka.Actor;

namespace AkkaNet.Remote.Demo.App3
{
    public class ActorC: ReceiveActor
    {
        public ActorC()
        {
            Receive<string>(message=>{
                Console.WriteLine("Received string message: {0} from {1}", message,Sender);
            });
        }
    }
}