using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Globalization;

public partial class Listado : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection conexion = new SqlConnection("Data Source=200.77.121.114;Initial Catalog=GRULOP;User ID=useradmin;Password=admin123*");
        {
            conexion.Open();

            string grid = "SELECT T_Articuladounidades.contador_folio, T_Articuladounidades.feregistro, T_Empleados.nombre, T_Parqvehicular.no_econ, T_Articuladounidades.desc_articu FROM T_Articuladounidades INNER JOIN T_Empleados ON T_Articuladounidades.id_empleado = T_Empleados.id_empleado INNER JOIN T_Parqvehicular ON T_Articuladounidades.id_parqveh = T_Parqvehicular.id_parqveh where T_Articuladounidades.cve_bajal = '1' order by T_Articuladounidades.feregistro ASC";

            SqlCommand consulta = new SqlCommand(grid, conexion);
            SqlDataAdapter da = new SqlDataAdapter(consulta);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();

            conexion.Close();

        }
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        SqlConnection conexion = new SqlConnection("Data Source=200.77.121.114;Initial Catalog=GRULOP;User ID=useradmin;Password=admin123*");
        {
            conexion.Open();

            string grid = "SELECT T_Articuladounidades.contador_folio, T_Articuladounidades.feregistro, T_Empleados.nombre, T_Parqvehicular.no_econ, T_Articuladounidades.desc_articu FROM T_Articuladounidades INNER JOIN T_Empleados ON T_Articuladounidades.id_empleado = T_Empleados.id_empleado INNER JOIN T_Parqvehicular ON T_Articuladounidades.id_parqveh = T_Parqvehicular.id_parqveh where T_Articuladounidades.cve_bajal = '1' order by T_Articuladounidades.feregistro ASC";

            SqlCommand consulta = new SqlCommand(grid, conexion);
            SqlDataAdapter da = new SqlDataAdapter(consulta);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();

            conexion.Close();
        }
    }
}