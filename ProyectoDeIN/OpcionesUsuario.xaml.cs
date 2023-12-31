﻿using System;
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
    /// Lógica de interacción para OpcionesUsuario.xaml
    /// </summary>
    public partial class OpcionesUsuario : Window
    {
        public OpcionesUsuario()
        {
            InitializeComponent();
        }

        

        private void Window_MouseLeave(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void Perfil_Click(object sender, RoutedEventArgs e)
        {

            Perfil_Estadisticas perfil = new Perfil_Estadisticas();
            perfil.Show();
            foreach (Window window in Application.Current.Windows)
            {
                if (window != perfil)
                {
                    window.Close();
                }
                
            }
            

        }

        private void Ajustes_Click(object sender, RoutedEventArgs e)
        {
            Ajustes ajustes = new Ajustes();
            ajustes.Show();
            foreach (Window window in Application.Current.Windows)
            {
                if (window != ajustes)
                {
                    window.Close();
                }
            }
            
        }
    }
}
