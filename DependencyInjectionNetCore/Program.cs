using Microsoft.Extensions.DependencyInjection;
using System;

namespace DependencyInjectionNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton<IFirstService, FirstService>();
            serviceCollection.AddScoped<ISecondService, SecondService>(x => new SecondService());
            serviceCollection.AddTransient<IThirdService, ThirdService>(x => new ThirdService());
            var serviceProvider = serviceCollection.BuildServiceProvider();
            serviceProvider.GetService<IFirstService>().FirstMethod();

            Console.ReadKey();
        }
    }
}
