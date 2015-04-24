using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment3
{
    public partial class _login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSgnIn_Click(object sender, EventArgs e)
        {
            //db connection
            string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
            // query to check if user and password exist
            string sql = "select * from ud where Em='"+userName.Text+"' and Pw='"+password.Text+"'";
            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr;
            
            try
            {
                con.Open();
                // if that combination doesnt exist
                if (cmd.ExecuteScalar() == null)
                {
                    //display error
                    System.Threading.Thread.Sleep(1000);
                    Response.Redirect("err2.aspx");
                }
                else
                {
                    // if exists set session 
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    Session["id"] = dr[0].ToString();
                    Session["loggedin"] = 1;
                    System.Threading.Thread.Sleep(1000);
                    dr.Close();
                    Response.Redirect("default.aspx");
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