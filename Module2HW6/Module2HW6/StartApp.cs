using System;
using Microsoft.Extensions.DependencyInjection;

namespace Module2HW6
{
    public class StartApp
    {
        public void Run()
        {
            var serviceProvider = new ServiceCollection()
                 .BuildServiceProvider();
        }
    }
}