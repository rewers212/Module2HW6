using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;

namespace Module2HW6
{
    public class StartApp
    {
        public void Run()
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<IHomeService, HomeService>()
                .AddTransient<HomeProvider>()
                .AddTransient<Starter>().BuildServiceProvider();

            serviceProvider.GetService<Starter>().Run();
        }
    }
}