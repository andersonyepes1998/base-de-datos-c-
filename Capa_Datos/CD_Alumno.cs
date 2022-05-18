using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Capa_Entidad;
using System.Data;

namespace Capa_Datos
{
    public class CD_Alumno
    {
        Conexion estudio = new Conexion();
        SqlCommand avanzados = new SqlCommand();

        public bool guardar_alumnos(CE_Alumno oalumno)
        {
            try
            {
                avanzados.CommandType = CommandType.StoredProcedure;
                avanzados.Connection = estudio.conectar("BD_Colegio");
                avanzados.CommandText = "agregar_alumno";
                avanzados.Parameters.Add("@Id_Alumno", oalumno.Id_Alumno1);
                avanzados.Parameters.Add("@Nom_Alumno", oalumno.Nom_Alumno1);
                avanzados.Parameters.Add("@Dir_Alumno", oalumno.Dir_Alumno1);
                avanzados.Parameters.Add("@Tel_Alumno", oalumno.Tel_Alumno1);
                avanzados.Parameters.Add("@Grp_Alumno", oalumno.Grp_Alumno1);
                avanzados.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {

                throw new Exception(); ;
            }
           
        }

        public bool anula_alumno(CE_Alumno oalumno2)
        {
            try
            {
                avanzados.CommandType = CommandType.StoredProcedure;
                avanzados.Connection = estudio.conectar("BD_Colegio");
                avanzados.CommandText = "modificar_alumno";
                avanzados.Parameters.Add("@Id_Alumno", oalumno2.Id_Alumno1);
                avanzados.ExecuteNonQuery();
                return true;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataSet consultar_alumno(CE_Alumno olumno3)
        {
            try
            {
                avanzados.CommandType = CommandType.StoredProcedure;
                avanzados.Connection = estudio.conectar("BD_Colegio");
                avanzados.CommandText = "consultar_alumno";
                avanzados.Parameters.Add("@Id_Alumno", olumno3.Id_Alumno1);
                SqlDataAdapter da = new SqlDataAdapter(avanzados);
                DataSet consulta = new DataSet();
                da.Fill(consulta);
                return consulta;
                
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
