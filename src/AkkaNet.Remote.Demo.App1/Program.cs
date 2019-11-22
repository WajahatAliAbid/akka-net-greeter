using System;
using System.IO;
using Akka.Actor;
using Akka.Configuration;

namespace AkkaNet.Remote.Demo.App1
{
    class Program
    {
        static void Main(string[] args)
        {
            var conf = ConfigurationFactory.ParseString(File.ReadAllText("hocon.conf"));
            var system = ActorSystem.Create("ClientSystem",conf);
            var actor = system.ActorOf<ActorA>("actorA");
            actor.Tell("Hello World");
            Console.ReadLine();
        }
    }
}
