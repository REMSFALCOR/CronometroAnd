using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrubaTimer
{
    class Control
    {

        /* Controla el aumento de los segundos, minutos, horas  y no pase de 60*/
        public int ControlTiempo(int InTime)
        {
            if (InTime >= 59)
                return 1;
            else return 0;
        }
        /* Controla si se va a incremetar un minuto o una hora, dependera que arroje ControlTiempo() */
        public int ControlIncrement(int incre, int contTimp)
        {
            if (contTimp == 0)
                incre++;
            else
                incre = 0;
            return incre;
        }
    }
}
