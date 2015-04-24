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
    public partial class myhistory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // prepare table
            booksTable.CssClass = "table table-hover";
            TableRow tRow = new TableRow();
            booksTable.Rows.Add(tRow);
            TableCell tCell1 = new TableCell();
            TableCell tCell2 = new TableCell();
            TableCell tCell3 = new TableCell();
            TableCell tCell5 = new TableCell();
            TableCell tCell6 = new TableCell();
            TableCell tCell7 = new TableCell();

            tCell1.Text = "Title";
            tCell2.Text = "Author";
            tCell3.Text = "ISBN";
            tCell5.Text = "Category";
            tCell6.Text = "Borrow Date";
            tCell7.Text = "Return Date";
            tRow.Cells.Add(tCell1);
            tRow.Cells.Add(tCell2);
            tRow.Cells.Add(tCell3);
            tRow.Cells.Add(tCell5);
            tRow.Cells.Add(tCell6);
            tRow.Cells.Add(tCell7);
            // convert to usable type
            Object idU = Session["id"];
            string idUserStr = (string)idU;
            int idUser = int.Parse(idUserStr);

            string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
            // fetch all books that the specific user has borrowed (and returend) in the past and order them by the date borrowed
            string sql = "select distinct BookTitle, BookAuthor, ISBN, CAT_NAME, BorrowDate, ReturnDate, BookId from Book, Category, History, ud WHERE Book.CAT_ID=Category.CAT_ID AND History.HUserId=" + idUser + " AND History.HBookId=Book.BookId AND ReturnDate IS NOT NULL ORDER BY BorrowDate ";
            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr;

            try
            {
                con.Open();

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    // for every row from the query add new row to table 
                    TableRow tRow2 = new TableRow();
                    booksTable.Rows.Add(tRow2);
                    for (int j = 0; j <= 5; j++)
                    {
                        // Create a new cell and add it to the row.
                        TableCell tCell = new TableCell();
                        tCell.Text = dr[j].ToString();
                        tRow2.Cells.Add(tCell);

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