using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlAspirantes
{
	class Conexion
	{
		public static SqlConnection conectarBD()
		{
			SqlConnection cnn;
			try
			{
				cnn = new SqlConnection("Data Source=CC101-23\\SQLADMIN;Initial Catalog=dbAspirantes;User ID=sa;Password=sqladmin21");
				cnn.Open();
				//MessageBox.Show("conectado");
			}
			catch (Exception ex)
			{
				cnn = null;
			}
			return cnn;
		}
	}
}
