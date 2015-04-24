using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace Assignment3
{
    public partial class reg2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnReg_Clic(object sender, EventArgs e)
        {
            // db connection, insert new user to ud(user data) relation, check if user exists
            string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString; 

            string sql = "insert into ud (Em, Pw) values ('" + emailReg.Text + "', '" + passwordReg.Text + "')";
            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(sql, con);
            string sql2 = "select Em from ud WHERE Em='" + emailReg.Text + "'";
            SqlCommand cmd2 = new SqlCommand(sql2, con);

            try
            {
                con.Open();
                // if user doesn't already exist
                if (cmd2.ExecuteScalar() == null)
                {
                    cmd.ExecuteNonQuery();

                    System.Threading.Thread.Sleep(3000);
                    Response.Redirect("login.aspx");
                }
                else
                {
                    // else display error
                    System.Threading.Thread.Sleep(2000);
                    Response.Redirect("err.aspx");
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

    }
}