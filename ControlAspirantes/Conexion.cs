using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ControlAspirantes
{
	class Conexion
	{
		public static SqlConnection conectarBD()
		{
			SqlConnection cnn;
			try
			{
				cnn = new SqlConnection("Data Source=1SAL08;Initial Catalog=bdEstudiantes;User ID=sa;Password=Sqladmin2022");
				cnn.Open();
				//MessageBox.Show("conectado");
			}
			catch (Exception ex)
			{
				cnn = null;
			}
			return cnn;
		}
		public void llenarCombo(ComboBox cb)
		{
			
			try
			{
				SqlConnection con;
				con = Conexion.conectarBD();
				SqlCommand cmd = new SqlCommand("select nombre from Estudiante", con);
				SqlDataReader rd = cmd.ExecuteReader();
				while (rd.Read())
				{
					cb.Items.Add(rd["nombre"].ToString());
				}
				//cb.SelectedIndex = 0;
				rd.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("no se pudo llenar el combo" + ex);
			}
		}

	}
}
