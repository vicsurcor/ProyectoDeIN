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

namespace ProyectoDeIN
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BotonSocial_Click(object sender, RoutedEventArgs e)
        {
            VentanaSocial window1 = new VentanaSocial();
            Point point = BotonSocial.PointToScreen(new Point(0, 0));
            Point point2 = BackgroundGrid.PointToScreen(new Point(0, 0));
            window1.Left = point.X - 5;
            window1.Top = point2.Y;
            window1.Show();
        }

        private void BotonUsuario_Click(object sender, RoutedEventArgs e)
        {
            OpcionesUsuario opciones = new OpcionesUsuario();
            Point point = BotonUsuario.PointToScreen(new Point(0, 0));
            opciones.Left = point.X - 80;
            opciones.Top = point.Y - 60;
            opciones.Show();
        }
    }
}
