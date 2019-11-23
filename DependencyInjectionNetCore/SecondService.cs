using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionNetCore
{
    public class SecondService : ISecondService
    {
        private double counter;
        public void SecondMethod()
        {
            counter++;
            Console.WriteLine(counter);
        }
    }
}
