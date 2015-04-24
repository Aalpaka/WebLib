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
    public partial class avlbBks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // same as for allBks.aspx, check there
            booksTable.CssClass = "table table-hover";
            TableRow tRow = new TableRow();
            booksTable.Rows.Add(tRow);
            TableCell tCell1 = new TableCell();
            TableCell tCell2 = new TableCell();
            TableCell tCell3 = new TableCell();
            TableCell tCell5 = new TableCell();
            tCell1.Text = "Title";
            tCell2.Text = "Author";
            tCell3.Text = "ISBN";
            tCell5.Text = "Category";
            tRow.Cells.Add(tCell1);
            tRow.Cells.Add(tCell2);
            tRow.Cells.Add(tCell3);
            tRow.Cells.Add(tCell5);

            string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;

            string sql = "select BookTitle, BookAuthor, ISBN, CAT_NAME, BookId from Book,Category WHERE Book.CAT_ID=Category.CAT_ID AND Borrowed=0 ORDER BY BookAuthor, BookTitle, CAT_NAME";
            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr;

            try
            {
                con.Open();

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    TableRow tRow2 = new TableRow();
                    booksTable.Rows.Add(tRow2);
                    for (int j = 0; j <= 3; j++)
                    {
                        
                        TableCell tCell = new TableCell();
                        tCell.Text = dr[j].ToString();
                        tRow2.Cells.Add(tCell);

                    }
                    // if there is a user logged in display the button for borrowing the books
                    if (Session["id"] != null)
                    {
                        TableCell tCell4 = new TableCell();
                        string id = dr[4].ToString();
                        tCell4.Text = "<a href='borrow.aspx?id=" + id + "'><span class='btn btn-primary glyphicon glyphicon-cloud-download'>Borrow </span></a>";
                        tRow2.Cells.Add(tCell4);
                    }
                }

                dr.Close();


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
