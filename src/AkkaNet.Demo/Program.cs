using System;
using System.Threading.Tasks;
using Akka.Actor;
using AkkaNet.Demo.Actors;
using AkkaNet.Demo.Models;

namespace AkkaNet.Demo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var random = new Random();
            var system = ActorSystem.Create("SampleSystem");
            var greeter = system.ActorOf<GreetingActor>("greeter");
            greeter.Tell(new Greet{Message="Hello World"});
            await Task.Delay(random.Next(2000,5000));
            greeter.Tell(new Greet{Message="Hello World1"});
            await Task.Delay(random.Next(2000,5000));
            greeter.Tell(new Greet{Message="Hello World2"});
            Console.ReadLine();
        }
    }
}
