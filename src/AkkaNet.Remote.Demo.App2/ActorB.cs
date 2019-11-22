using System;
using Akka.Actor;

namespace AkkaNet.Remote.Demo.App2
{
    public class ActorB: ReceiveActor
    {
        public ActorB()
        {
            Receive<string>(message=>{
                Console.WriteLine("Received String message: {0} from {1}", message,Sender);
                var actorSystem = Context.ActorSelection("akka.tcp://RemoteSystemB@localhost:9002/user/actorC");
                foreach (var item in message.Split(' '))
                {
                    actorSystem.Tell(item);
                }
            });
        }
    }
}