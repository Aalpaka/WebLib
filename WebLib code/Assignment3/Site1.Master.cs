using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment3
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // if noone is logged in display login and register buttons
            if (Session["loggedin"] == null)
            {
                log.Text = "Login <span class='glyphicon glyphicon-user'/>";
                log.NavigateUrl = "login.aspx";
                reg.Text = "Register";
                reg.NavigateUrl = "reg2.aspx";
            }
            else
            {
                // else dislpay logout, my books and my history buttons
                log.Text = "Logout";
                log.NavigateUrl = "logout.aspx";
                myBooks.Text = "My books <span class='glyphicon glyphicon-book'/>";
                myBooks.NavigateUrl = "myBks.aspx";
                myHistory.Text = "My history <span class='glyphicon glyphicon-sort'/>";
                myHistory.NavigateUrl="myhistory.aspx";
                // if admin is logged in display add books possibility
                if (Session["id"].ToString().Trim() == "2")
                {
                    addBks.Text = "Add Books <span class='glyphicon glyphicon-plus'/>";
                    addBks.NavigateUrl = "addBks.aspx";
                }
            }
        }
    }
}