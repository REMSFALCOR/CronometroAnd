using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Timers;
using System.Windows.Threading;
using PrubaTimer.Vista;

namespace PrubaTimer
{

    //class FormatoBoton

    public partial class MainWindow : Window
    {
        DispatcherTimer DpT = new DispatcherTimer();
        Cronometro Crtr;
        EventoBoton EvB;
        FormatoTiempo ImPt;
        IConfObj ICO;// Interfac para las vistas
        ConfObj CO;

        public MainWindow()
        {
            InitializeComponent();
            PropAtrib();
            Crtr = new Cronometro();
            EvB = new EventoBoton();
            ImPt = new FormatoTiempo();            
        }

        private void PropAtrib() {
            Titulo.Background = new SolidColorBrush(Colors.Transparent);
            Titulo.BorderBrush = new SolidColorBrush(Colors.Transparent);
            Titulo.Foreground = new SolidColorBrush(Colors.Aqua);

            Segundos = (TextBox)ProTbTime(Segundos);
            Minutos = (TextBox)ProTbTime(Minutos);
            Hora = (TextBox)ProTbTime(Hora);

            SepHorMin = PutosSeparacio(SepHorMin);
            SepMinSeg = PutosSeparacio(SepMinSeg);

            //Pause = ProBT(Pause);
            //Stop = ProBT(Stop);
           

            ICO = new ConfViewBoton(Pause);
            CO = new ConfObj(ICO);
            Pause = (Button)CO.ConfObjeto();

            ICO = new ConfViewBoton(Stop);
            CO = new ConfObj(ICO);
            Stop = (Button)CO.ConfObjeto();

            OP1 = (RadioButton)SelecOpc(OP1);
            OP2 = (RadioButton)SelecOpc(OP2);

            //IntTimStap.Foreground = new SolidColorBrush(Colors.Snow);
        }

        public Object SelecOpc(RadioButton rb)
        {
            rb.BorderBrush = new SolidColorBrush(Colors.Transparent);
            rb.Foreground = new SolidColorBrush(Colors.Snow);
            return rb;
        }

        public Object ProTbTime(TextBox tb)
        {            
            tb.BorderBrush = new SolidColorBrush(Colors.Transparent);           
            tb.Foreground = new SolidColorBrush(Colors.Snow);
            return tb;
        }
        public TextBox PutosSeparacio(TextBox tb)
        {
            tb.BorderBrush = new SolidColorBrush(Colors.Transparent);
            tb.Foreground = new SolidColorBrush(Colors.YellowGreen);
            return tb;
        }
                
        private void Bt_Iniciar(object sender, RoutedEventArgs e)
        {
            OP1.IsEnabled = false;
            OP2.IsEnabled = false;
            //IntTimStap.IsEnabled = false;
            EvB.start(DpT);
        }

        private void Bt_Pause(object sender, RoutedEventArgs e)
        {
            EvB.pause(DpT);
        }

        private void Bt_Stop(object sender, RoutedEventArgs e)
        {
            OP1.IsEnabled = true;
            OP2.IsEnabled = true;
            //IntTimStap.IsEnabled = true;
            increSeg = 0;
            Crtr.ActualizaInicio();
            MostraEnPantalla();
            EvB.stop(DpT);
        }        

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //if(IntTimStap.IsChecked == true)
            DpT.Interval = TimeSpan.FromSeconds(1);// para que realize intervalos de 1s en 1s
            DpT.Tick += Incrementa;                                
        }

        private void Incrementa(object sender, EventArgs e)
        {
            Crtr.Incrementar();
            // Mostrar en pantalla
            MostraEnPantalla();
            increSeg++;
        }
        public int increSeg = 0;

        private void MostraEnPantalla() {
            // Este primer algoridmo, trabaja direstamente calculando 
            // los segundo para obtener los minuto y horas
            if (numF == 1){ 
                Segundos.Text = ImPt.FormTiempo(Crtr.CalSegundos(increSeg));// Segundos
                Minutos.Text = ImPt.FormTiempo(Crtr.CalMinutos(increSeg));// Minutos
                Hora.Text = ImPt.FormTiempo(Crtr.CalHoras(increSeg));// Segundos
            }
            // trabaja con el segundo algoridmo
            if (numF == 2)
            {
                Segundos.Text = ImPt.FormTiempo(Crtr.increSeg); //Mostrar en pantalla
                Minutos.Text = ImPt.FormTiempo(Crtr.increMin); //Mostrar en pantalla
                Hora.Text = ImPt.FormTiempo(Crtr.increHor); //Mostrar en pantalla
                //Titulo.Text = ImPt.FormTiempo(Crtr.increHor) + ":" + ImPt.FormTiempo(Crtr.increMin) + ":" + ImPt.FormTiempo(Crtr.increSeg);
            }           
    }

        int numF = 1;   
        //Primer Algorirmo
        private void OP1_Checked(object sender, RoutedEventArgs e)
        {
            numF = 1;
        }
        //Segundo Algorirmo
        private void OP2_Checked(object sender, RoutedEventArgs e)
        {
            numF = 2;           
        }

        /*
        bool SinInte=true;
        private void IntTimStap_Checked(object sender, RoutedEventArgs e)
        {
            //IntTimStap.AutoCheck = false;            
            if (!IntTimStap.IsSealed)
                IntTimStap.IsChecked = true;
            else
                IntTimStap.IsChecked = false;
        }
                    <CheckBox Name = "IntTimStap" IsEnabled="false" Content="Quitar Interval de TimeSpan" Canvas.Left="211" Canvas.Top="75" Width="165" Checked="IntTimStap_Checked"/>
        */
    }
}
//https://github.com/REMSFALCOR/Cronometro.git
