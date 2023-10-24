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
	/// Lógica de interacción para Modificacion.xaml
	/// </summary>
	public partial class Modificacion : Window
	{
		public Modificacion()
		{
			InitializeComponent();
			Conexion c = new Conexion();
			c.llenarCombo(cbAspirantes); 

		}

		private void bAceptar_Click(object sender, RoutedEventArgs e)
		{
			Alumno a = new Alumno((string)cbAspirantes.SelectedItem, (string)cbProgramas.SelectedItem);
           try
            {
				int resp= a.modificar(a);
                if (resp == 0)
                {
					MessageBox.Show("Ya esta en esa carrera"); 
                }
                else
                {
					MessageBox.Show("Modificacion exitosa");
				}


            }
			catch (Exception ex)
			{
				MessageBox.Show("no jala" + ex);

			}
			
		}

		private void bRegresar_Click(object sender, RoutedEventArgs e)
		{
			MainWindow w= new MainWindow();
			this.Hide(); 
			w.Show();
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
