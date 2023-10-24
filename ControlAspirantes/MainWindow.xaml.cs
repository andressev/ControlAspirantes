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

namespace ControlAspirantes
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

		private void bModificacion_Click(object sender, RoutedEventArgs e)
		{

		}

		private void bAlta_Click(object sender, RoutedEventArgs e)
		{
			int resp;
			Alumno a = new Alumno(tbNombre.Text+" "+tbApellidoPaterno.Text+" "+tbApellidoMaterno.Text, tbSexo.Text, tbFechaDeNacimiento.Text, tbCorreo.Text, (int) cbGrado.SelectedItem, (string) cbPrograma.SelectedItem);
			resp = a.altaAlumno(a);
			if (resp > 0)//mayor a 0 si se pudo dar de alta
			{
				MessageBox.Show("Alta exitosa");
			}
			else
				MessageBox.Show("No se pudo");
			this.Hide();
			MainWindow w = new MainWindow();
			w.Show();
		}

		private void bReporte_Click(object sender, RoutedEventArgs e)
		{
			Reporte r = new Reporte();
			this.Hide(); 
			r.Show(); 
		}

		private void button_Click(object sender, RoutedEventArgs e)
		{

		}

		private void cbGrado_Loaded(object sender, RoutedEventArgs e)
		{
			cbGrado.Items.Add(4);
			cbGrado.Items.Add(5);
			cbGrado.Items.Add(6); 
		}

		private void cbPrograma_Loaded(object sender, RoutedEventArgs e)
		{
			cbPrograma.Items.Add("Compu");
			cbPrograma.Items.Add("Datos");
			cbPrograma.Items.Add("Mate");
			cbPrograma.Items.Add("Negocios");
			cbPrograma.Items.Add("RI");
			cbPrograma.Items.Add("Eco");

		}
	}

	

		
	
}
