using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace PrubaTimer.Vista
{
    class ConfViewTextBox : IConfObj
    {
        TextBlock TB;
        public ConfViewTextBox(TextBlock tb) {
            this.TB = tb;
        }

        public object ConfObjeto()
        {            
            TB.Foreground = new SolidColorBrush(Colors.Snow);
            TB.Foreground = new SolidColorBrush(Colors.BlanchedAlmond);
            //TB.BorderBrush = new SolidColorBrush(Colors.Transparent);
            return TB;
        }
    }
}
