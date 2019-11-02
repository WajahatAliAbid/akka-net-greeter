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
            await Task.Delay(random.Next(500,3000));
            greeter.Tell(new Greet{Message="Hello Boys"});
            await Task.Delay(random.Next(500,3000));
            greeter.Tell(new Greet{Message="Hello Girls "});
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
    }
}
