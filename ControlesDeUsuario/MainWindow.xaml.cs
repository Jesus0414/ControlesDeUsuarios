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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ControlesDeUsuario
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

        private void CbFigura_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            grdParametrosFigura.Children.Clear();
            switch (CbFigura.SelectedIndex)
            {
				case 0:
					break;
                case 1://Circulo
                    grdParametrosFigura.Children.Add(new ParametrosCirculo());
                    break;
				case 2://Triángulo
					grdParametrosFigura.Children.Add(new ParametrosTriangulo());
					break;
				case 3://Rectángulo
					grdParametrosFigura.Children.Add(new ParametrosRectangulo());
					break;
				case 4://Cuadrado
					grdParametrosFigura.Children.Add(new ParametrosCuadrado());
					break;
				case 5:
					grdParametrosFigura.Children.Add(new ParametrosTrapecio());
					break;
                default:
                    break;
            }
        }
    }
}
