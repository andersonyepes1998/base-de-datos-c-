using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa_Entidad;
using Capa_Negocio;
using System.Data;

namespace Colegio_Capas
{
    public partial class Capa_de_presentacion : System.Web.UI.Page
    {

        CN_Alumno ONalumno = new CN_Alumno();
        CE_Alumno OEalumno = new CE_Alumno();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BTNguardar_Click(object sender, EventArgs e)
        {
            OEalumno.Id_Alumno1 = Convert.ToString(txt1);
            OEalumno.Nom_Alumno1 = Convert.ToString(txt2);
            OEalumno.Dir_Alumno1 = Convert.ToString(txt3);
            OEalumno.Tel_Alumno1 = Convert.ToInt32(txt4);
            OEalumno.Grp_Alumno1 = Convert.ToString(txt5);

            if (ONalumno.guardar_alumnos(OEalumno))
            {

            }
        }

     
    }
}