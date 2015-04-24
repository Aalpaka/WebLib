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
    public partial class _return : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // correct data types
            Object idU = Session["id"];
            string idUserStr = (string)idU;
            int idUser = int.Parse(idUserStr);

            string idB = Request["id"];
            int idBook = int.Parse(idB);

            string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
            // set return date for a previously borrowed book, and update borrowed book
            string sql = "update History set ReturnDate = @Date where HBookId=" + idBook + " and HUserId=" + idUser + " and ReturnDate is NULL";
            string sql2 = "update Book set Borrowed=0 WHERE BookId=" + idBook;

            SqlConnection con = new SqlConnection(connStr);

            SqlCommand cmd = new SqlCommand(sql, con);
            SqlCommand cmd2 = new SqlCommand(sql2, con);
            cmd.Parameters.AddWithValue("@Date", DateTime.Now);


            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();

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