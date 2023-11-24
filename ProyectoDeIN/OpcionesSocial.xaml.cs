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
    /// Lógica de interacción para OpcionesSocial.xaml
    /// </summary>
    public partial class OpcionesSocial : Window
    {
        public OpcionesSocial()
        {
            InitializeComponent();
        }

        private void Chat_Click(object sender, RoutedEventArgs e)
        {
            Window chat = new Chat();
            chat.Show();
            foreach (Window window in Application.Current.Windows)
            {
                if (window != chat)
                {
                    window.Close();
                }
            }
        }

        private void Perfil_Click(object sender, RoutedEventArgs e)
        {
            Window perfilAmigo = new PerfilAmigo();
            perfilAmigo.Show();
            foreach (Window window in Application.Current.Windows)
            {
                if (window != perfilAmigo)
                {
                    window.Close();
                }
            }
        }

        private void Window_MouseLeave(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
