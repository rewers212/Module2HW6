using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6
{
    public class Starter
    {
        private readonly IHomeService _homeservice;
        private readonly HomeProvider _homeProvider;
        private readonly int _count = 10;
        public Starter(
            IHomeService homeService,
            HomeProvider homeProvider)
        {
            _homeProvider = homeProvider;
            _homeservice = homeService;
        }

        public void Run()
        {
            var rand = new Random();
            for (var i = 0; i < _count; i++)
            {
                var a = rand.Next(_homeProvider.ElectricalAppliance.Length);
                _homeservice.Add(_homeProvider.ElectricalAppliance[a]);
            }

            var fullPower = _homeservice.GetFullPower();
            var findByName = _homeservice.GetAppliances().FindByName("Nord");
            _homeservice.SortByPrice();
        }
    }
}