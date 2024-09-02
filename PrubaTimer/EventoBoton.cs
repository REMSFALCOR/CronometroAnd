using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Threading;

namespace PrubaTimer
{
    class EventoBoton 
    {
        // empezar a marcar el tiempo con el conometro
        public void start(DispatcherTimer Dpt)
        {
            Dpt.Start();
        }
        // pausar el timpo marcado por el conometro
        public void pause(DispatcherTimer Dpt)
        {
            Dpt.IsEnabled = false;
        }
        // para el marcado de 
        public void stop(DispatcherTimer Dpt)
        {
            Dpt.Stop();
        }
    }
}
