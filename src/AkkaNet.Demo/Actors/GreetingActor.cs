using System;
using Akka.Actor;
using AkkaNet.Demo.Models;

namespace AkkaNet.Demo.Actors
{
    public class GreetingActor: ReceiveActor
    {
        public GreetingActor()
        {
            Receive<Greet>(greet=> Console.WriteLine(greet.Message.ToUpper()));
        }
    }
}