using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTheater
{
    class HomeTheaterFacade
    {
        Projector projector;
        DvdPlayer dvdplayer;
        CdPlayer cdplayer;

        public HomeTheaterFacade(Projector projector, DvdPlayer dvdplayer, CdPlayer cdplayer)
        {
            this.projector = projector;
            this.dvdplayer = dvdplayer;
            this.cdplayer = cdplayer;
        }

        public void WatchMovie()
        {
            projector.On();
            projector.WidescreenMode();
            dvdplayer.On();
            cdplayer.On();
            cdplayer.Play();
        }

        public void EndMovie()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Shutting down");
            projector.Off();
            projector.TvMode();
            dvdplayer.Off();
            cdplayer.Pause();
            cdplayer.Off();
        }
    }
}
