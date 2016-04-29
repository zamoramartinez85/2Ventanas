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

namespace _2Ventanas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private Ventana2 segunda;
        private int contador;
        private Controlador control;
       
        public MainWindow()
        {
            InitializeComponent();
            control = new Controlador();
            generarSegundaVentana();
            
            contador = 0;
        }

        private void generarSegundaVentana()
        {
            segunda = new Ventana2();
            segunda.Show();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int numero = control.sumar();

            etiContador1.Content = numero;
            if(segunda != null)
                segunda.etiContador2.Content = numero;
        }

       
    }
}
