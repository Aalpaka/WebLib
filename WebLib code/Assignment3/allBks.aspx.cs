using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Assignment3
{
    public partial class allBks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // adding class to table, adding first row with column description
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
            
            // conn to database
            string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;

            string sql = "select BookTitle, BookAuthor, ISBN, CAT_NAME, BookId from Book,Category WHERE Book.CAT_ID=Category.CAT_ID ORDER BY BookAuthor, BookTitle, CAT_NAME";
            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr;

            try
            {
                con.Open();

                dr = cmd.ExecuteReader();
                // get all books and for every book create a new row with the needed information in row cells
                while (dr.Read())
                {
                    TableRow tRow2 = new TableRow();
                    booksTable.Rows.Add(tRow2);
                    for (int j = 0; j <= 3; j++)
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