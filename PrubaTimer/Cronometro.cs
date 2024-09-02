using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Threading;

namespace PrubaTimer
{

    class Cronometro : DispatcherTimer// Timer
    {
        Control Ctrl;
        readonly int HorEnSeg = 3600;
        readonly int MinEnSeg = 60;

        public int increSeg = 0;
        public int increMin = 0;
        public int increHor = 0;

        public Cronometro() {
            Ctrl = new Control();
        }

        public void Incrementar()
        {
            increMin += Ctrl.ControlTiempo(increSeg);
            increSeg = Ctrl.ControlIncrement(increSeg, Ctrl.ControlTiempo(increSeg));
            increHor += Ctrl.ControlTiempo(increMin);
            if (Ctrl.ControlIncrement(increMin, Ctrl.ControlTiempo(increMin)) == 0)
                increMin = Ctrl.ControlIncrement(increMin, Ctrl.ControlTiempo(increMin));
        }

        public void ActualizaInicio(){
            increSeg = 0;
            increMin = 0;
            increHor = 0;
        }

        public int CalHoras(int ts)
        {
            if (ts > HorEnSeg)
                return ts / HorEnSeg;            
            return 0;
        }

        public int CalMinutos(int ts)
        {
            int th;
            if (ts > HorEnSeg)
                th = ts / HorEnSeg;
            else
                th = 0;
            if (ts >= 60)
                return (ts - HorEnSeg * th) / 60;
            else
                return 0;
        }

        public int CalSegundos(int ts)
        {
            int th,tm;
            if (ts > HorEnSeg)
            {   th = ts / HorEnSeg;
                ts = ts - HorEnSeg * th;
            }
            if (ts >= MinEnSeg)
            {
                tm = ts / MinEnSeg;
                ts = ts - MinEnSeg * tm;
            }           
            return ts;
        }
    }
}
