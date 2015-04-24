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
    public partial class borrow : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // convert session variable and request variable to appropriate type
            Object idU = Session["id"];
            string idUserStr = (string)idU;
            int idUser = int.Parse(idUserStr);
            string idB = Request["id"];
            int idBook = int.Parse(idB);
           
            // db connection, insert new entry in the History relation and update the clicked book 
            string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;

            string sql = "insert into History (HBookId, HUserId, BorrowDate) values (" + idBook + "," + idUser + ", @Date)";
            string sql2 = "update Book set Borrowed=1 WHERE BookId=" + idBook;

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