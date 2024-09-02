using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrubaTimer
{
    class FormatoTiempo
    {
        /* para la imprecion del tiempo */
        public string FormTiempo(int IncTiempo)
        {
            if (IncTiempo < 10)
                return "0" + IncTiempo.ToString();
            else
                return IncTiempo.ToString();
        }
    }
}
