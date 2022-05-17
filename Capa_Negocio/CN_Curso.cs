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
    public class CN_Curso
    {
        CD_Curso nuevocurso = new CD_Curso();

        public bool guardar_cursos(CE_Curso conect4)
        {
            return nuevocurso.guardar_cursos(conect4);
        }

        public bool anula_cursos(CE_Curso conect5)
        {
            return nuevocurso.anula_cursos(conect5);
        }

        public DataSet consultar_cursos(CE_Curso conect6)
        {
            return nuevocurso.consultar_cursos(conect6);
        }
    }
}
