using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlAspirantes
{
	class Alumno
	{
		public int idAlum { get; set; }  
		public string nombre { get; set; }
		public string sexo { get; set; }
		public string fechaNac { get; set; }
		public string correo { get; set; }
		public int grado { get; set; }
		public string interes { get; set; }

		public static int global = 0; 

		public Alumno(string nombre, string sexo, string fechaNac, string correo, int grado, string interes)
		{
			

			idAlum = global++; 
			this.nombre = nombre;
			this.sexo = sexo;
			this.fechaNac = fechaNac;
			this.correo = correo;
			this.grado = grado;
			this.interes = interes; 
			
			
		}
		public Alumno(string interes)
		{
			this.interes = interes; 
		}
		public Alumno()
		{
			
		}
		public Alumno(string nombre, string interes)
		{
			this.nombre=nombre;
			this.interes=	interes; ;
		}
		public int altaAlumno(Alumno a)
		{
			int resp = 0;
			SqlConnection con;
			con = Conexion.conectarBD();
			SqlCommand cmd = new SqlCommand(String.Format("insert into Estudiante (idEstudiante, nombre, sexo, fechaN, correo, grado, interes) values({0}, '{1}', '{2}','{3}','{4}', {5},'{6}')",a.idAlum,  a.nombre, a.sexo, a.fechaNac, a.correo, a.grado, a.interes), con);
			resp = cmd.ExecuteNonQuery();
			con.Close();

			return resp; 
		}
		public List<Alumno> buscarAlumno(String interes)
		{
			List<Alumno> list = new List<Alumno>();
			Alumno c;
			SqlConnection con = Conexion.conectarBD();
			SqlCommand cmd = new SqlCommand(String.Format("select idEstudiante,nombre,sexo,fechaN,correo,grado,interes from Estudiante where interes like '%{0}%'", interes), con);
			SqlDataReader dr = cmd.ExecuteReader();
			while (dr.Read())
			{
				c = new Alumno();


				c.idAlum = dr.GetInt32(0); 
				c.nombre = dr.GetString(1);
				c.sexo = dr.GetString(2);
				c.fechaNac = dr.GetString(3); 
				c.correo= dr.GetString(4);
				c.grado = dr.GetInt32(5); 
				c.interes= dr.GetString(6);


				list.Add(c);
			}
			con.Close();
			return list;

		}
		public int modificar(Alumno a)
		{
			int res = 0;
			SqlConnection con = Conexion.conectarBD();
			SqlCommand cmd = new SqlCommand(String.Format("UPDATE Estudiante SET interes= '{0}' WHERE nombre = '{1}'", a.interes, a.nombre), con); 
            res = cmd.ExecuteNonQuery();
			return res;
		}

	}
}
