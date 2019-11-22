using System;
using System.IO;
using Akka.Actor;
using Akka.Configuration;

namespace AkkaNet.Remote.Demo.App3
{
    class Program
    {
        static void Main(string[] args)
        {
            var conf = ConfigurationFactory.ParseString(File.ReadAllText("hocon.conf"));
            var system = ActorSystem.Create("RemoteSystemB",conf);
            system.ActorOf<ActorC>("actorC");
            Console.ReadLine();
        }
    }
}
