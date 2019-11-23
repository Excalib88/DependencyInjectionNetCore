using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionNetCore
{
    public class FirstService: IFirstService
    {
        private readonly ISecondService _secondService;
        private readonly IThirdService _thirdService;

        public FirstService(ISecondService secondService, IThirdService thirdService)
        {
            _secondService = secondService;
            _secondService.SecondMethod();

            _thirdService = thirdService;
            _thirdService.ThirdMethod();
        }

        public void FirstMethod()
        {
            Console.WriteLine(this.GetType().Name);
        }
    }
}
