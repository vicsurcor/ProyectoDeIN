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
using System.Windows.Shapes;

namespace ProyectoDeIN
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class VentanaSocial : Window
    {
        public VentanaSocial()
        {
            InitializeComponent();
        }

        private void CambioTexto_Social(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
           
            textBox.Foreground = Brushes.Gray;
            
        }

        private void BotonSocial_Click(object sender, RoutedEventArgs e)
        {
            OpcionesSocial opciones = new OpcionesSocial();
            Point point = BotonSocial.PointToScreen(new Point(0, 0));
            opciones.Left = point.X - 80;
            opciones.Top = point.Y - 60;
            opciones.Show();
        }
    }
}
