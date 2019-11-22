using System;
using System.IO;
using Akka.Actor;
using Akka.Configuration;

namespace AkkaNet.Remote.Demo.App2
{
    class Program
    {
        static void Main(string[] args)
        {
            var conf = ConfigurationFactory.ParseString(File.ReadAllText("hocon.conf"));
            var system = ActorSystem.Create("RemoteSystemA",conf);
            system.ActorOf<ActorB>("actorB");
            Console.ReadLine();
        }
    }
}
