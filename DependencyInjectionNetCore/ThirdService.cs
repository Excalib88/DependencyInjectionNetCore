using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionNetCore
{
    public class ThirdService : IThirdService
    {
        private int counter;

        public void ThirdMethod()
        {
            counter++;
            Console.WriteLine(counter);
        }
    }
}
