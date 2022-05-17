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
    public class CD_Curso
    {
        Conexion materias = new Conexion();
        SqlCommand estudios = new SqlCommand();

        public bool guardar_cursos(CE_Curso conect1)
        {
            try
            {
                estudios.CommandType = CommandType.StoredProcedure;
                estudios.Connection = materias.conectar("BD_Colegio");
                estudios.CommandText = "agregar_Curso";
                estudios.Parameters.Add("@Id_Curso", conect1.Id_Curso1);
                estudios.Parameters.Add("@Nom_Curso", conect1.Nom_Curso1);
                estudios.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool anula_cursos(CE_Curso conect2)
        {
            try
            {
                estudios.CommandType = CommandType.StoredProcedure;
                estudios.Connection = materias.conectar("BD_Colegio");
                estudios.CommandText = "modificar_curso";
                estudios.Parameters.Add("@Id_Curso", conect2.Id_Curso1);
                estudios.Parameters.Add("@Nom_Curso", conect2.Nom_Curso1);
                estudios.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataSet consultar_cursos(CE_Curso conect3)
        {
            try
            {
                estudios.CommandType = CommandType.StoredProcedure;
                estudios.Connection = materias.conectar("BD_Colegio");
                estudios.CommandText = "consultar_curso";
                estudios.Parameters.Add("@Id_Curso", conect3.Id_Curso1);
                SqlDataAdapter informe = new SqlDataAdapter(estudios);
                DataSet consulta = new DataSet();
                informe.Fill(consulta);
                return consulta;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
