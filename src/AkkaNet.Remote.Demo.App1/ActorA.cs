using System;
using Akka.Actor;

namespace AkkaNet.Remote.Demo.App1
{
    public class ActorA: ReceiveActor
    {
        public ActorA()
        {
            Receive<string>(message=>
            {
                var actorSystem = Context.ActorSelection("akka.tcp://RemoteSystemA@localhost:9000/user/actorB");
                actorSystem.Tell(message);
            });
        }
    }
}