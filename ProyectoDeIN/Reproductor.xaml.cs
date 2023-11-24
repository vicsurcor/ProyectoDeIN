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
    /// Lógica de interacción para Reproductor.xaml
    /// </summary>
    public partial class Reproductor : Window
    {
        public Brush brush1;
        public Reproductor()
        {
            InitializeComponent();
            Color color = Color.FromRgb(49, 248, 45);
            Brush brush = new SolidColorBrush(color);
            brush1 = brush;
            Estado.Background = brush;
            EstadoTexto.Text = "Conectado";
        }

        private void VolverMenuPrincipal_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
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

        private void CambioEstado_Click(object sender, RoutedEventArgs e)
        {
            Brush color = Estado.Background;
            if (color == brush1)
            {
                Estado.Background = Brushes.Yellow;
                EstadoTexto.Text = "Ausente";
            }
            else if (color == Brushes.Yellow)
            {
                Estado.Background = Brushes.Red;
                EstadoTexto.FontSize = 9.5;
                EstadoTexto.Margin = new Thickness(10, 5, 0, 0);
                EstadoTexto.Text = "Apareciendo Desconectado";
            }
            else
            {
                Estado.Background = brush1;
                EstadoTexto.FontSize = 12;
                EstadoTexto.Margin = new Thickness(10, 0, 0, 0);
                EstadoTexto.Text = "Conectado";
            }
        }
    }
}
