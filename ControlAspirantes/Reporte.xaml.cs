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

namespace ControlAspirantes
{
	/// <summary>
	/// Lógica de interacción para Reporte.xaml
	/// </summary>
	public partial class Reporte : Window
	{
		public Reporte()
		{
			InitializeComponent();
		}

		private void bRegresar_Click(object sender, RoutedEventArgs e)
		{
			MainWindow w = new MainWindow();
			this.Hide();
			w.Show();

		}

		private void bGenerar_Click(object sender, RoutedEventArgs e)
		{
			Alumno a = new Alumno((string)cbProgramas.SelectedItem);
			dGReporte.ItemsSource = a.buscarAlumno((string)cbProgramas.SelectedItem); 
		}

		private void cbProgramas_Loaded(object sender, RoutedEventArgs e)
		{
			cbProgramas.Items.Add("Compu");
			cbProgramas.Items.Add("Datos");
			cbProgramas.Items.Add("Mate");
			cbProgramas.Items.Add("Negocios");
			cbProgramas.Items.Add("RI");
			cbProgramas.Items.Add("Eco");
		}
	}
}
