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
    /// Lógica de interacción para PerfilAmigo.xaml
    /// </summary>
    public partial class PerfilAmigo : Window
    {
        
        public PerfilAmigo()
        {
            InitializeComponent();
            
        }

        private void VolverMenuPrincipal_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            this.Close();
            window.Show();
        }

        private void CambioEstadisticas_Click(object sender, RoutedEventArgs e)
        {
            PerfilJuegos.IsEnabled = true;
            PerfilEstadisticas.IsEnabled = false;
        }

        private void CambioJuegos_Click(object sender, RoutedEventArgs e)
        {
            PerfilJuegos.IsEnabled = false;
            PerfilEstadisticas.IsEnabled = true;
        }

        
    }
}
