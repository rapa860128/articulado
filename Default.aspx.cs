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

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        DropDownList1.Visible = false;
        DropDownList2.Visible = false;
        DropDownList3.Visible = false;
        DropDownList4.Visible = false;
        DropDownList5.Visible = false;
        DropDownList6.Visible = false;

        Label1.Visible = false;
        Label2.Visible = false;
        Label3.Visible = false;
        Label4.Visible = false;
        Label6.Visible = false;
        Label7.Visible = false;
        Label8.Visible = false;
        Label9.Visible = false;
        Label10.Visible = false;

        TextBox1.Visible = false;
        Button1.Visible = false;
        Button2.Visible = false;

        
      
        if (!IsPostBack)
        {
            string query = "SELECT id_parqveh, no_econ, articulado FROM V_Parqvehicular where id_nomactivo = '52' and id_statuspveh = '1' and articulado = '0' order by id_nomactivo ASC";
            DataTable dt = GetData(query);
            DropDownList1.DataSource = dt;
            DropDownList1.DataTextField = "no_econ";
            DropDownList1.DataValueField = "id_parqveh";
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0, new ListItem(" - Select - ", ""));

            string query2 = "SELECT id_parqveh, no_econ, articulado FROM V_Parqvehicular where id_nomactivo = '33' or id_nomactivo = '64' or id_nomactivo = '35' or id_nomactivo = '65' or id_nomactivo = '32' or id_nomactivo = '67' and id_statuspveh = '1' and articulado = '0' order by id_nomactivo ASC";
            DataTable dt2 = GetData(query2);
            DropDownList2.DataSource = dt2;
            DropDownList2.DataTextField = "no_econ";
            DropDownList2.DataValueField = "id_parqveh";
            DropDownList2.DataBind();
            DropDownList2.Items.Insert(0, new ListItem(" - Select - ", ""));

            string query3 = "SELECT id_parqveh, no_econ, articulado FROM V_Parqvehicular where id_nomactivo = '36' and id_statuspveh = '1' and articulado = '0' order by id_nomactivo ASC";
            DataTable dt3 = GetData(query3);
            DropDownList3.DataSource = dt3;
            DropDownList3.DataTextField = "no_econ";
            DropDownList3.DataValueField = "id_parqveh";
            DropDownList3.DataBind();
            DropDownList3.Items.Insert(0, new ListItem(" - Select - ", ""));

            string query4 = "SELECT id_parqveh, no_econ, articulado FROM V_Parqvehicular where id_nomactivo = '33' or id_nomactivo = '64' or id_nomactivo = '35' or id_nomactivo = '65' or id_nomactivo = '32' or id_nomactivo = '67' and id_statuspveh = '1' and articulado = '0' order by id_nomactivo ASC";
            DataTable dt4 = GetData(query4);
            DropDownList4.DataSource = dt4;
            DropDownList4.DataTextField = "no_econ";
            DropDownList4.DataValueField = "id_parqveh";
            DropDownList4.DataBind();
            DropDownList4.Items.Insert(0, new ListItem(" - Select - ", ""));

            string query5 = "select id_empleado, nombre from T_Empleados where id_puesto = '13' or id_puesto = '38' and baja = '0'";
            DataTable dt5 = GetData(query5);
            DropDownList5.DataSource = dt5;
            DropDownList5.DataTextField = "nombre";
            DropDownList5.DataValueField = "id_empleado";
            DropDownList5.DataBind();
            DropDownList5.Items.Insert(0, new ListItem(" - Select - ", ""));

            string query6 = "SELECT DISTINCT(nom_activo), id_nomactivo FROM V_Parqvehicular where id_nomactivo = '33' or id_nomactivo = '64' or id_nomactivo = '35' or id_nomactivo = '65' or id_nomactivo = '32' or id_nomactivo = '67' and id_statuspveh = '1' and articulado = '0' order by nom_activo ASC";
            DataTable dt6 = GetData(query6);
            DropDownList6.DataSource = dt6;
            DropDownList6.DataTextField = "nom_activo";
            DropDownList6.DataValueField = "id_nomactivo";
            DropDownList6.DataBind();
            DropDownList6.Items.Insert(0, new ListItem(" - Select - ", ""));

        }
    }

    private static DataTable GetData(string query)
    {
        DataTable dt = new DataTable();
        SqlCommand cmd = new SqlCommand(query);
        String constr = ConfigurationManager.ConnectionStrings["GRULOPConnectionString"].ConnectionString;
        SqlConnection con = new SqlConnection(constr);
        SqlDataAdapter sda = new SqlDataAdapter();
        cmd.CommandType = CommandType.Text;
        cmd.Connection = con;
        sda.SelectCommand = cmd;
        sda.Fill(dt);
        return dt;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (RadioButtonList1.SelectedIndex == 0)
        {
           if (DropDownList6.SelectedIndex == 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Articulado no registrado, falta Tipo de Articulado!');", true);
                DropDownList1.Visible = true;
                DropDownList2.Visible = true;
                DropDownList3.Visible = true;
                DropDownList4.Visible = true;
                DropDownList5.Visible = true;
                DropDownList6.Visible = true;

                Label1.Visible = true;
                Label2.Visible = true;
                Label3.Visible = true;
                Label4.Visible = true;
                Label6.Visible = true;
                Label7.Visible = true;
                Label8.Visible = true;
                Label9.Visible = true;
                Label9.Visible = true;

                TextBox1.Visible = true;
                Button1.Visible = true;
                Button2.Visible = true;
            }

            else if (DropDownList1.SelectedIndex == 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Articulado no registrado, falta Tracto!');", true);
                DropDownList1.Visible = true;
                DropDownList2.Visible = true;
                DropDownList3.Visible = true;
                DropDownList4.Visible = true;
                DropDownList5.Visible = true;
                DropDownList6.Visible = true;

                Label1.Visible = true;
                Label2.Visible = true;
                Label3.Visible = true;
                Label4.Visible = true;
                Label6.Visible = true;
                Label7.Visible = true;
                Label8.Visible = true;
                Label9.Visible = true;
                Label10.Visible = true;

                TextBox1.Visible = true;
                Button1.Visible = true;
                Button2.Visible = true;
            }
            else if (DropDownList2.SelectedIndex == 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Articulado no registrado, falta Remolque!');", true);
                DropDownList1.Visible = true;
                DropDownList2.Visible = true;
                DropDownList3.Visible = true;
                DropDownList4.Visible = true;
                DropDownList5.Visible = true;
                DropDownList6.Visible = true;

                Label1.Visible = true;
                Label2.Visible = true;
                Label3.Visible = true;
                Label4.Visible = true;
                Label6.Visible = true;
                Label7.Visible = true;
                Label8.Visible = true;
                Label9.Visible = true;
                Label9.Visible = true;

                TextBox1.Visible = true;
                Button1.Visible = true;
                Button2.Visible = true;
            }

            else if (DropDownList3.SelectedIndex == 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Articulado no registrado, falta Dolly!');", true);
                DropDownList1.Visible = true;
                DropDownList2.Visible = true;
                DropDownList3.Visible = true;
                DropDownList4.Visible = true;
                DropDownList5.Visible = true;
                DropDownList6.Visible = true;

                Label1.Visible = true;
                Label2.Visible = true;
                Label3.Visible = true;
                Label4.Visible = true;
                Label6.Visible = true;
                Label7.Visible = true;
                Label8.Visible = true;
                Label9.Visible = true;
                Label10.Visible = true;

                TextBox1.Visible = true;
                Button1.Visible = true;
                Button2.Visible = true;
            }
            else if (DropDownList4.SelectedIndex == 0)
            {

                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Articulado no registrado, falta Remolque!');", true);
                DropDownList1.Visible = true;
                DropDownList2.Visible = true;
                DropDownList3.Visible = true;
                DropDownList4.Visible = true;
                DropDownList5.Visible = true;
                DropDownList6.Visible = true;

                Label1.Visible = true;
                Label2.Visible = true;
                Label3.Visible = true;
                Label4.Visible = true;
                Label6.Visible = true;
                Label7.Visible = true;
                Label8.Visible = true;
                Label9.Visible = true;
                Label10.Visible = true;

                TextBox1.Visible = true;
                Button1.Visible = true;
                Button2.Visible = true;
            }
            else if (DropDownList5.SelectedIndex == 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Articulado no registrado, falta Operador!');", true);
                DropDownList1.Visible = true;
                DropDownList2.Visible = true;
                DropDownList3.Visible = true;
                DropDownList4.Visible = true;
                DropDownList5.Visible = true;
                DropDownList6.Visible = true;

                Label1.Visible = true;
                Label2.Visible = true;
                Label3.Visible = true;
                Label4.Visible = true;
                Label6.Visible = true;
                Label7.Visible = true;
                Label8.Visible = true;
                Label9.Visible = true;
                Label10.Visible = true;

                TextBox1.Visible = true;
                Button1.Visible = true;
                Button2.Visible = true;
            }
           else if (DropDownList2.SelectedIndex == DropDownList4.SelectedIndex)
           {
               ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Remolque 1 y 2 deben ser diferentes, verifique el armado!');", true);
               DropDownList1.Visible = true;
               DropDownList2.Visible = true;
               DropDownList3.Visible = true;
               DropDownList4.Visible = true;
               DropDownList5.Visible = true;
               DropDownList6.Visible = true;

               Label1.Visible = true;
               Label2.Visible = true;
               Label3.Visible = true;
               Label4.Visible = true;
               Label6.Visible = true;
               Label7.Visible = true;
               Label8.Visible = true;
               Label9.Visible = true;
               Label10.Visible = true;

               TextBox1.Visible = true;
               Button1.Visible = true;
               Button2.Visible = true;
           }

            else
            {

                SqlConnection cn = new SqlConnection("Data Source=200.77.121.114;Initial Catalog=GRULOP;User ID=useradmin;Password=admin123*");
                {


                    SqlCommand consulta = new SqlCommand("update T_Articuladounidades set id_parqveh = '" + DropDownList1.SelectedValue + "', remolque1 = '" + DropDownList2.SelectedValue + "', dolly = '" + DropDownList3.SelectedValue + "', remolque2 = '" + DropDownList4.SelectedValue + "', id_empleado = '" + DropDownList5.SelectedValue + "', desc_articu = '" + TextBox1.Text + "', tipo_articulado = '" + RadioButtonList1.SelectedValue + "', tipo_unidad = '" + DropDownList6.SelectedValue + "' where contador_folio = '" + Label8.Text + "'", cn);
                    cn.Open();

                    consulta.ExecuteNonQuery();

                    cn.Close();
                }
                SqlConnection cn1 = new SqlConnection("Data Source=200.77.121.114;Initial Catalog=GRULOP;User ID=useradmin;Password=admin123*");
                {

                    cn1.Open();

                    SqlCommand tracto = new SqlCommand("update T_Parqvehicular set articulado = '1' where id_parqveh = '" + DropDownList1.SelectedValue + "'", cn1);
                    SqlCommand remolque1 = new SqlCommand("update T_Parqvehicular set articulado = '1' where id_parqveh = '" + DropDownList2.SelectedValue + "'", cn1);
                    SqlCommand dolly = new SqlCommand("update T_Parqvehicular set articulado = '1' where id_parqveh = '" + DropDownList3.SelectedValue + "'", cn1);
                    SqlCommand remolque2 = new SqlCommand("update T_Parqvehicular set articulado = '1' where id_parqveh = '" + DropDownList4.SelectedValue + "'", cn1);

                    tracto.ExecuteNonQuery();
                    remolque1.ExecuteNonQuery();
                    dolly.ExecuteNonQuery();
                    remolque2.ExecuteNonQuery();

                    cn1.Close();
                }

                RadioButtonList1.ClearSelection();
                Response.Redirect("Listado.aspx");
            }
        }
        else
        {
            if (DropDownList6.SelectedIndex == 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Articulado no registrado, falta Tipo de Articulado!');", true);
                DropDownList1.Visible = true;
                DropDownList2.Visible = true;
                DropDownList3.Visible = false;
                DropDownList4.Visible = false;
                DropDownList5.Visible = true;
                DropDownList6.Visible = true;

                Label1.Visible = true;
                Label2.Visible = true;
                Label3.Visible = false;
                Label4.Visible = false;
                Label6.Visible = true;
                Label7.Visible = true;
                Label8.Visible = true;
                Label9.Visible = true;
                Label10.Visible = true;

                TextBox1.Visible = true;
                Button1.Visible = true;
                Button2.Visible = true;
            }

            else if (DropDownList1.SelectedIndex == 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Articulado no registrado, falta Tracto!');", true);
                DropDownList1.Visible = true;
                DropDownList2.Visible = true;
                DropDownList3.Visible = false;
                DropDownList4.Visible = false;
                DropDownList5.Visible = true;
                DropDownList6.Visible = true;

                Label1.Visible = true;
                Label2.Visible = true;
                Label3.Visible = false;
                Label4.Visible = false;
                Label6.Visible = true;
                Label7.Visible = true;
                Label8.Visible = true;
                Label9.Visible = true;
                Label10.Visible = true;

                TextBox1.Visible = true;
                Button1.Visible = true;
                Button2.Visible = true;
            }
            else if (DropDownList2.SelectedIndex == 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Articulado no registrado, falta Remolque!');", true);
                DropDownList1.Visible = true;
                DropDownList2.Visible = true;
                DropDownList3.Visible = false;
                DropDownList4.Visible = false;
                DropDownList5.Visible = true;
                DropDownList6.Visible = true;

                Label1.Visible = true;
                Label2.Visible = true;
                Label3.Visible = false;
                Label4.Visible = false;
                Label6.Visible = true;
                Label7.Visible = true;
                Label8.Visible = true;
                Label9.Visible = true;
                Label10.Visible = true;

                TextBox1.Visible = true;
                Button1.Visible = true;
                Button2.Visible = true;
            }
            else if (DropDownList5.SelectedIndex == 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Articulado no registrado, falta Operador!');", true);
                DropDownList1.Visible = true;
                DropDownList2.Visible = true;
                DropDownList3.Visible = false;
                DropDownList4.Visible = false;
                DropDownList5.Visible = true;
                DropDownList6.Visible = true;

                Label1.Visible = true;
                Label2.Visible = true;
                Label3.Visible = false;
                Label4.Visible = false;
                Label6.Visible = true;
                Label7.Visible = true;
                Label8.Visible = true;
                Label9.Visible = true;
                Label10.Visible = true;

                TextBox1.Visible = true;
                Button1.Visible = true;
                Button2.Visible = true;
            }
            
            else
            {

                SqlConnection cn = new SqlConnection("Data Source=200.77.121.114;Initial Catalog=GRULOP;User ID=useradmin;Password=admin123*");
                {


                    SqlCommand consulta = new SqlCommand("update T_Articuladounidades set id_parqveh = '" + DropDownList1.SelectedValue + "', remolque1 = '" + DropDownList2.SelectedValue + "', dolly = '" + DropDownList3.SelectedValue + "', remolque2 = '" + DropDownList4.SelectedValue + "', id_empleado = '" + DropDownList5.SelectedValue + "', desc_articu = '" + TextBox1.Text + "', tipo_articulado = '" + RadioButtonList1.SelectedValue + "', tipo_unidad = '" + DropDownList6.SelectedValue + "' where contador_folio = '" + Label8.Text + "'", cn);
                    cn.Open();

                    consulta.ExecuteNonQuery();

                    cn.Close();
                }
                SqlConnection cn1 = new SqlConnection("Data Source=200.77.121.114;Initial Catalog=GRULOP;User ID=useradmin;Password=admin123*");
                {

                    cn1.Open();

                    SqlCommand tracto = new SqlCommand("update T_Parqvehicular set articulado = '1' where id_parqveh = '" + DropDownList1.SelectedValue + "'", cn1);
                    SqlCommand remolque1 = new SqlCommand("update T_Parqvehicular set articulado = '1' where id_parqveh = '" + DropDownList2.SelectedValue + "'", cn1);
                    SqlCommand dolly = new SqlCommand("update T_Parqvehicular set articulado = '1' where id_parqveh = '" + DropDownList3.SelectedValue + "'", cn1);
                    SqlCommand remolque2 = new SqlCommand("update T_Parqvehicular set articulado = '1' where id_parqveh = '" + DropDownList4.SelectedValue + "'", cn1);

                    tracto.ExecuteNonQuery();
                    remolque1.ExecuteNonQuery();
                    dolly.ExecuteNonQuery();
                    remolque2.ExecuteNonQuery();

                    cn1.Close();
                }

                RadioButtonList1.ClearSelection();
                Response.Redirect("Listado.aspx");
            }
        }



    }
    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {

        if (RadioButtonList1.SelectedIndex == 0)
        {

            SqlConnection cn = new SqlConnection("Data Source=200.77.121.114;Initial Catalog=GRULOP;User ID=useradmin;Password=admin123*");
            {

                cn.Open();

                SqlCommand limpiar = new SqlCommand("delete from T_Articuladounidades where id_parqveh Is Null", cn);
                limpiar.ExecuteNonQuery();

                string access2 = "select IsNull(max(contador_folio),0) + 1 as FOLIO from T_Articuladounidades";
                SqlCommand cmd2 = new SqlCommand(access2, cn);
                SqlDataAdapter AdaptadorTabla = new SqlDataAdapter(access2, cn);
                DataTable tabla2 = new DataTable();
                AdaptadorTabla.Fill(tabla2);
                string folio = tabla2.Rows[0]["FOLIO"].ToString();
                Label8.Text = folio;

                SqlCommand consulta = new SqlCommand("insert into T_Articuladounidades (contador_folio, tipo_articulado) Values (@contador_folio, @tipo_articulado)", cn);
                consulta.Parameters.AddWithValue("@contador_folio", Label8.Text);
                consulta.Parameters.AddWithValue("@tipo_articulado", RadioButtonList1.SelectedValue);
                consulta.ExecuteNonQuery();

                cn.Close();
            }

            
            DropDownList1.Visible = true;
            DropDownList2.Visible = true;
            DropDownList3.Visible = true;
            DropDownList4.Visible = true;
            DropDownList5.Visible = true;
            DropDownList6.Visible = true;

            Label1.Visible = true;
            Label2.Visible = true;
            Label3.Visible = true;
            Label4.Visible = true;
            Label6.Visible = true;
            Label7.Visible = true;
            Label8.Visible = true;
            Label9.Visible = true;
            Label10.Visible = true;

            TextBox1.Visible = true;
            Button1.Visible = true;
            Button2.Visible = true;

        }
        else if (RadioButtonList1.SelectedIndex == 1)
        {

            SqlConnection cn = new SqlConnection("Data Source=200.77.121.114;Initial Catalog=GRULOP;User ID=useradmin;Password=admin123*");
            {

                cn.Open();

                SqlCommand limpiar = new SqlCommand("delete from T_Articuladounidades where id_parqveh Is Null", cn);
                limpiar.ExecuteNonQuery();

                string access2 = "select IsNull(max(contador_folio),0) + 1 as FOLIO from T_Articuladounidades";
                SqlCommand cmd2 = new SqlCommand(access2, cn);
                SqlDataAdapter AdaptadorTabla = new SqlDataAdapter(access2, cn);
                DataTable tabla2 = new DataTable();
                AdaptadorTabla.Fill(tabla2);
                string folio = tabla2.Rows[0]["FOLIO"].ToString();
                Label8.Text = folio;

                SqlCommand consulta = new SqlCommand("insert into T_Articuladounidades (contador_folio, tipo_articulado) Values (@contador_folio, @tipo_articulado)", cn);
                consulta.Parameters.AddWithValue("@contador_folio", Label8.Text);
                consulta.Parameters.AddWithValue("@tipo_articulado", RadioButtonList1.SelectedValue);
                consulta.ExecuteNonQuery();

                cn.Close();
            }
            DropDownList1.Visible = true;
            DropDownList2.Visible = true;
            DropDownList3.Visible = false;
            DropDownList4.Visible = false;
            DropDownList5.Visible = true;
            DropDownList6.Visible = true;

            Label1.Visible = true;
            Label2.Visible = true;
            Label3.Visible = false;
            Label4.Visible = false;
            Label6.Visible = true;
            Label7.Visible = true;
            Label8.Visible = true;
            Label9.Visible = true;
            Label10.Visible = true;

            TextBox1.Visible = true;
            Button1.Visible = true;
            Button2.Visible = true;

            string query3 = "SELECT id_parqveh, no_econ, articulado FROM V_Parqvehicular where id_nomactivo = '36' and id_statuspveh = '1' and articulado = '0' order by id_nomactivo ASC";
            DataTable dt3 = GetData(query3);
            DropDownList3.DataSource = dt3;
            DropDownList3.DataTextField = "no_econ";
            DropDownList3.DataValueField = "id_parqveh";
            DropDownList3.DataBind();
            DropDownList3.Items.Insert(0, new ListItem(" - Select - ", ""));

            string query4 = "SELECT id_parqveh, no_econ, articulado FROM V_Parqvehicular where id_nomactivo = '33' or id_nomactivo = '64' or id_nomactivo = '35' or id_nomactivo = '65' or id_nomactivo = '32' or id_nomactivo = '67' and id_statuspveh = '1' and articulado = '0' order by id_nomactivo ASC";
            DataTable dt4 = GetData(query4);
            DropDownList4.DataSource = dt4;
            DropDownList4.DataTextField = "no_econ";
            DropDownList4.DataValueField = "id_parqveh";
            DropDownList4.DataBind();
            DropDownList4.Items.Insert(0, new ListItem(" - Select - ", ""));

        }

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection("Data Source=200.77.121.114;Initial Catalog=GRULOP;User ID=useradmin;Password=admin123*");
        {

            cn.Open();

            SqlCommand limpiar = new SqlCommand("delete from T_Articuladounidades where id_parqveh Is Null", cn);
            limpiar.ExecuteNonQuery();

            cn.Close();
        }

        RadioButtonList1.ClearSelection();
        Response.Redirect("Default.aspx");
    }
    
    
}