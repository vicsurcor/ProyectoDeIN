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

        private void CambioEstado_Click(object sender, RoutedEventArgs e)
        {
            
            
        }

        private void Window_MouseLeave(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
