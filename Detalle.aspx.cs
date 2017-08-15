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

public partial class Detalle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label8.Text = Request.QueryString["id"];

        SqlConnection connn = new SqlConnection("Data Source=200.77.121.114;Initial Catalog=GRULOP;User ID=useradmin;Password=admin123*");
        {

            connn.Open();

            string rpt1 = "SELECT tipo_articulado FROM T_Articuladounidades where contador_folio = '" + Label8.Text + "'";

            SqlCommand cmd1 = new SqlCommand(rpt1, connn);

            SqlDataAdapter AdaptadorTabla = new SqlDataAdapter(rpt1, connn);
            DataTable tabla1 = new DataTable();

            AdaptadorTabla.Fill(tabla1);

            string tipo_articulado = tabla1.Rows[0]["tipo_articulado"].ToString();

            Label16.Text = tipo_articulado;

            connn.Close();

        }

        string tipo = Label16.Text;

        if (tipo == "1")
        {

            SqlConnection conn = new SqlConnection("Data Source=200.77.121.114;Initial Catalog=GRULOP;User ID=useradmin;Password=admin123*");
            {

                conn.Open();

                string rpt = "SELECT T_Articuladounidades.feregistro, T_Empleados.nombre, T_Parqvehicular.no_econ, A.no_econ as remolque1, B.no_econ as dolly, C.no_econ as remolque2, T_Articuladounidades.desc_articu, T_Articuladounidades.tipo_articulado, T_Articuladounidades.fe_articulado, T_Activonombre.nom_activo FROM T_Articuladounidades INNER JOIN T_Parqvehicular as A ON T_Articuladounidades.remolque1 = A.id_parqveh INNER JOIN T_Parqvehicular as B ON T_Articuladounidades.dolly = B.id_parqveh INNER JOIN T_Parqvehicular as C ON T_Articuladounidades.remolque2 = C.id_parqveh INNER JOIN T_Empleados ON T_Articuladounidades.id_empleado = T_Empleados.id_empleado INNER JOIN T_Parqvehicular ON T_Articuladounidades.id_parqveh = T_Parqvehicular.id_parqveh INNER JOIN t_activonombre ON T_Articuladounidades.tipo_unidad = t_activonombre.id_nomactivo where T_Articuladounidades.contador_folio = '" + Label8.Text + "'";

                SqlCommand cmd = new SqlCommand(rpt, conn);

                SqlDataAdapter AdaptadorTabla = new SqlDataAdapter(rpt, conn);
                DataTable tabla = new DataTable();

                AdaptadorTabla.Fill(tabla);

                string operador = tabla.Rows[0]["nombre"].ToString();
                string feregistro = tabla.Rows[0]["feregistro"].ToString();
                string fe_articulado = tabla.Rows[0]["fe_articulado"].ToString();
                string no_econ = tabla.Rows[0]["no_econ"].ToString();
                string remolque1 = tabla.Rows[0]["remolque1"].ToString();
                string dolly = tabla.Rows[0]["dolly"].ToString();
                string remolque2 = tabla.Rows[0]["remolque2"].ToString();
                string desc_articu = tabla.Rows[0]["desc_articu"].ToString();
                string tipo_articulado = tabla.Rows[0]["tipo_articulado"].ToString();
                string nom_activo = tabla.Rows[0]["nom_activo"].ToString();

                Label14.Text = operador;
                Label10.Text = no_econ;
                Label11.Text = remolque1;
                Label12.Text = dolly;
                Label13.Text = remolque2;
                Label15.Text = desc_articu;
                Label16.Text = tipo_articulado;
                Label18.Text = feregistro;
                Label20.Text = fe_articulado;
                Label21.Text = nom_activo;

                Label16.Text = "FULL";

                conn.Close();
            }
        }
        else
        {


            SqlConnection conn = new SqlConnection("Data Source=200.77.121.114;Initial Catalog=GRULOP;User ID=useradmin;Password=admin123*");
            {

                conn.Open();

                string rpt = "SELECT T_Articuladounidades.feregistro, T_Empleados.nombre, T_Parqvehicular.no_econ, A.no_econ as remolque1, T_Articuladounidades.desc_articu, T_Articuladounidades.tipo_articulado, T_Articuladounidades.fe_articulado, T_Activonombre.nom_activo FROM T_Articuladounidades INNER JOIN T_Parqvehicular as A ON T_Articuladounidades.remolque1 = A.id_parqveh INNER JOIN T_Empleados ON T_Articuladounidades.id_empleado = T_Empleados.id_empleado INNER JOIN T_Parqvehicular ON T_Articuladounidades.id_parqveh = T_Parqvehicular.id_parqveh INNER JOIN t_activonombre ON T_Articuladounidades.tipo_unidad = t_activonombre.id_nomactivo where T_Articuladounidades.contador_folio = '" + Label8.Text + "'";

                SqlCommand cmd = new SqlCommand(rpt, conn);

                SqlDataAdapter AdaptadorTabla = new SqlDataAdapter(rpt, conn);
                DataTable tabla = new DataTable();

                AdaptadorTabla.Fill(tabla);

                string operador = tabla.Rows[0]["nombre"].ToString();
                string feregistro = tabla.Rows[0]["feregistro"].ToString();
                string fe_articulado = tabla.Rows[0]["fe_articulado"].ToString();
                string no_econ = tabla.Rows[0]["no_econ"].ToString();
                string remolque1 = tabla.Rows[0]["remolque1"].ToString();
                string desc_articu = tabla.Rows[0]["desc_articu"].ToString();
                string tipo_articulado = tabla.Rows[0]["tipo_articulado"].ToString();
                string nom_activo = tabla.Rows[0]["nom_activo"].ToString();

                Label14.Text = operador;
                Label10.Text = no_econ;
                Label11.Text = remolque1;
                Label15.Text = desc_articu;
                Label16.Text = tipo_articulado;
                Label18.Text = feregistro;
                Label20.Text = fe_articulado;
                Label21.Text = nom_activo;

                Label16.Text = "SENCILLO";

                Label12.Visible = false;
                Label13.Visible = false;
                Label3.Visible = false;
                Label4.Visible = false;

                conn.Close();
            }

        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        Response.Redirect("Historico.aspx");

    }
}