using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrubaTimer.Vista
{
    class ConfObj
    {
        IConfObj ICO;
        public ConfObj(IConfObj _ico) {
            this.ICO = _ico;
        }
        public Object ConfObjeto() {
            return ICO.ConfObjeto();
        }

    }
}
