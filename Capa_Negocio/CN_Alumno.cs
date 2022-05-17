using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;
using Capa_Datos;
using System.Data;

namespace Capa_Negocio
{
    public class CN_Alumno
    {
        CD_Alumno nuevoalumno = new CD_Alumno();
        public bool guardar_alumnos(CE_Alumno oalumno4)
        {
            return nuevoalumno.guardar_alumnos(oalumno4);
        }

        public bool anula_alumno(CE_Alumno oalumno5)
        {
            return nuevoalumno.anula_alumno(oalumno5);
        }

        public DataSet consultar_alumno(CE_Alumno oalumno6)
        {
            return nuevoalumno.consultar_alumno(oalumno6);
        }
    }
}
