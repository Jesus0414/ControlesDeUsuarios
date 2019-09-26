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
			lblResultado.Text = "0.0";

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
				case 5://Trapecio
					grdParametrosFigura.Children.Add(new ParametrosTrapecio());
					break;
				case 6://Pentagono
					grdParametrosFigura.Children.Add(new ParametrosPentago());
					break;
				default:
                    break;
            }
        }

		private void BtnCalcular_Click(object sender, RoutedEventArgs e)
		{
			double area = 0.0;
			switch (CbFigura.SelectedIndex)
			{
				case 0:
					break;
				case 1://Circulo
					double radio = double.Parse(
					((ParametrosCirculo)
						(grdParametrosFigura.Children[0])).txtRadio.Text);
					area = Math.PI * radio * radio;
					break;
				case 2://Triángulo
					double baseTriangulo = double.Parse(((ParametrosTriangulo)(grdParametrosFigura.Children[0])).txtBaseTriangulo.Text);
					double alturaTriangulo = double.Parse(((ParametrosTriangulo)(grdParametrosFigura.Children[0])).txtAlturaTriangulo.Text);
					area = (baseTriangulo * alturaTriangulo) / 2;
					break;
				case 3://Rectángulo
					double baseRectangulo = double.Parse(((ParametrosRectangulo)(grdParametrosFigura.Children[0])).txtBaseRectangulo.Text);
					double alturaRectangulo = double.Parse(((ParametrosRectangulo)(grdParametrosFigura.Children[0])).txtAlturaRectangulo.Text);
					area = baseRectangulo * alturaRectangulo;
					break;
				case 4://Cuadrado
					double ladoCuadrado = double.Parse(((ParametrosCuadrado)(grdParametrosFigura.Children[0])).txtLadoCuadrado.Text);
					area = ladoCuadrado * ladoCuadrado;
					break;
				case 5://Trapecio
					double baseMayorTrapecio = double.Parse(((ParametrosTrapecio)(grdParametrosFigura.Children[0])).txtBaseMayorTrapecio.Text);
					double baseMenorTrapecio = double.Parse(((ParametrosTrapecio)(grdParametrosFigura.Children[0])).txtBaseMenorTrapecio.Text);
					double alturaTrapecio = double.Parse(((ParametrosTrapecio)(grdParametrosFigura.Children[0])).txtAlturaTrapecio.Text);
					area = alturaTrapecio * (baseMayorTrapecio + baseMenorTrapecio) / 2;
					break;
				case 6://Pentagono
					double ladoPentagono = double.Parse(((ParametrosPentago)(grdParametrosFigura.Children[0])).txtLadoPentagono.Text);
					double apotemaPentagono = double.Parse(((ParametrosPentago)(grdParametrosFigura.Children[0])).txtApotemaPentagono.Text);
					area = ((ladoPentagono * 5) * apotemaPentagono) / 2;
					break;
				default:
					break;
			}
			lblResultado.Text = area.ToString();
		}
	}
}
