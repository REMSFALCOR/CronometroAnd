using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace PrubaTimer.Vista
{
    class ConfViewBoton : IConfObj
    {
        Button BT;
        public ConfViewBoton(Button bt) {
            this.BT = bt;
        }

        // Registramos las propiedades de los botones 
        public object ConfObjeto()
        {
            BT.Background = new SolidColorBrush(Colors.Transparent);
            BT.Foreground = new SolidColorBrush(Colors.BlanchedAlmond);
            BT.FontFamily = new FontFamily("Comic Sans MS");
            BT.BorderBrush = new SolidColorBrush(Colors.Transparent);
            return BT;         
        }
    }
}
