using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTheater
{
    class Program
    {
        static void Main(string[] args)
        {
            HomeTheaterFacade hometheater = new HomeTheaterFacade(new Projector(), new DvdPlayer(), new CdPlayer());
            hometheater.WatchMovie();

            hometheater.EndMovie();

            Console.Read();
        }
    }
}
