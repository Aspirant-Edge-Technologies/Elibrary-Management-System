using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ElibraryManagement
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                if (Session["role"].Equals(""))
                {

                    LinkButton20.Visible = false;
                    LinkButton16.Visible = true;
                    LinkButton14.Visible = true;
                    LinkButton21.Visible = false;
                    LinkButton28.Visible = false;

                    LinkButton11.Visible = false;
                    LinkButton12.Visible = false;
                    LinkButton8.Visible = false;
                    LinkButton9.Visible = false;
                    LinkButton10.Visible = false;
                    LinkButton6.Visible = true;

                }
                else if (Session["role"].Equals("user"))
                {
                    LinkButton20.Visible = true;
                    LinkButton16.Visible = false;
                    LinkButton14.Visible = false;
                    LinkButton21.Visible = true;
                    LinkButton28.Visible = true;


                    LinkButton11.Visible = false;
                    LinkButton12.Visible = false;
                    LinkButton8.Visible = false;
                    LinkButton9.Visible = false;
                    LinkButton10.Visible = false;
                    LinkButton6.Visible = true;
                    LinkButton28.Text = "Hello " + Session["username"].ToString();
                }
                else if (Session["role"].Equals("admin"))
                {
                    LinkButton20.Visible = true;
                    LinkButton16.Visible = false;
                    LinkButton14.Visible = false;
                    LinkButton21.Visible = true;
                    LinkButton28.Visible = true;


                    LinkButton11.Visible = true;
                    LinkButton12.Visible = true;
                    LinkButton8.Visible = true;
                    LinkButton9.Visible = true;
                    LinkButton10.Visible = true;
                    LinkButton6.Visible = false;
                    LinkButton28.Text = "Hello admin";
                }
            }
            catch (Exception ex)
            {

            }

        }

        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminlogin.aspx");
        }
        //logout button
        protected void LinkButton11_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminauthormanagement.aspx");
            LinkButton20.Visible = true;
            LinkButton16.Visible = false;
            LinkButton14.Visible = false;
            LinkButton21.Visible = true;
            LinkButton28.Visible = true;


            LinkButton11.Visible = true;
            LinkButton12.Visible = true;
            LinkButton8.Visible = true;
            LinkButton9.Visible = true;
            LinkButton10.Visible = true;
            LinkButton6.Visible = false;
            LinkButton28.Text = "Hello admin";

        }


        protected void LinkButton12_Click(object sender, EventArgs e)
        {
            Response.Redirect("publishermanagement.aspx");
            LinkButton20.Visible = true;
            LinkButton16.Visible = false;
            LinkButton14.Visible = false;
            LinkButton21.Visible = true;
            LinkButton28.Visible = true;


            LinkButton11.Visible = true;
            LinkButton12.Visible = true;
            LinkButton8.Visible = true;
            LinkButton9.Visible = true;
            LinkButton10.Visible = true;
            LinkButton6.Visible = false;
            LinkButton28.Text = "Hello admin";
        }

        protected void LinkButton8_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminbookinventory.aspx");
            LinkButton20.Visible = true;
            LinkButton16.Visible = false;
            LinkButton14.Visible = false;
            LinkButton21.Visible = true;
            LinkButton28.Visible = true;


            LinkButton11.Visible = true;
            LinkButton12.Visible = true;
            LinkButton8.Visible = true;
            LinkButton9.Visible = true;
            LinkButton10.Visible = true;
            LinkButton6.Visible = false;
            LinkButton28.Text = "Hello admin";
        }

        protected void LinkButton9_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminbookissuing.aspx");
            LinkButton20.Visible = true;
            LinkButton16.Visible = false;
            LinkButton14.Visible = false;
            LinkButton21.Visible = true;
            LinkButton28.Visible = true;


            LinkButton11.Visible = true;
            LinkButton12.Visible = true;
            LinkButton8.Visible = true;
            LinkButton9.Visible = true;
            LinkButton10.Visible = true;
            LinkButton6.Visible = false;
            LinkButton28.Text = "Hello admin";

        }

        protected void LinkButton10_Click(object sender, EventArgs e)
        {
            LinkButton20.Visible = true;
            LinkButton16.Visible = false;
            LinkButton14.Visible = false;
            LinkButton21.Visible = true;
            LinkButton28.Visible = true;


            LinkButton11.Visible = true;
            LinkButton12.Visible = true;
            LinkButton8.Visible = true;
            LinkButton9.Visible = true;
            LinkButton10.Visible = true;
            LinkButton6.Visible = false;
            LinkButton28.Text = "Hello admin";
            Response.Redirect("adminmembermanagement.aspx");
        }
        protected void LinkButton3_Click(object sender, EventArgs e)
        {
           
        }
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            

                    LinkButton20.Visible = false;
                    LinkButton16.Visible = true;
                    LinkButton14.Visible = true;
                    LinkButton21.Visible = false;
                    LinkButton28.Visible = false;

                    LinkButton11.Visible = false;
                    LinkButton12.Visible = false;
                    LinkButton8.Visible = false;
                    LinkButton9.Visible = false;
                    LinkButton10.Visible = false;
                    LinkButton6.Visible = true;
            Response.Redirect("homepage.aspx");
        }

        protected void LinkButton14_Click(object sender, EventArgs e)
        {
            Response.Redirect("usersignup.aspx");
            LinkButton20.Visible = false;
            LinkButton16.Visible = true;
            LinkButton14.Visible = true;
            LinkButton21.Visible = false;
            LinkButton28.Visible = false;

            LinkButton11.Visible = false;
            LinkButton12.Visible = false;
            LinkButton8.Visible = false;
            LinkButton9.Visible = false;
            LinkButton10.Visible = false;
            LinkButton6.Visible = true;
        }

        protected void LinkButton16_Click(object sender, EventArgs e)
        {
            Response.Redirect("userlogin.aspx");
            LinkButton20.Visible = false;
            LinkButton16.Visible = true;
            LinkButton14.Visible = true;
            LinkButton21.Visible = false;
            LinkButton28.Visible = false;

            LinkButton11.Visible = false;
            LinkButton12.Visible = false;
            LinkButton8.Visible = false;
            LinkButton9.Visible = false;
            LinkButton10.Visible = false;
            LinkButton6.Visible = true;
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {

        }

        protected void LinkButton20_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewbooks.aspx");
            LinkButton20.Visible = true;
            LinkButton16.Visible = false;
            LinkButton14.Visible = false;
            LinkButton21.Visible = true;
            LinkButton28.Visible = true;


            LinkButton11.Visible = false;
            LinkButton12.Visible = false;
            LinkButton8.Visible = false;
            LinkButton9.Visible = false;
            LinkButton10.Visible = false;
            LinkButton6.Visible = true;
            LinkButton28.Text = "Hello " + Session["username"].ToString();
        }

        protected void LinkButton21_Click(object sender, EventArgs e)
        {


            Session["username"] = "";
            Session["fullname"] = "";
            Session["role"] = "";
            Session["status"] = "";
            LinkButton20.Visible = false;
            LinkButton16.Visible = true;
            LinkButton14.Visible = true;
            LinkButton21.Visible = false;
            LinkButton28.Visible = false;

            LinkButton11.Visible = false;
            LinkButton12.Visible = false;
            LinkButton8.Visible = false;
            LinkButton9.Visible = false;
            LinkButton10.Visible = false;
            LinkButton6.Visible = true;
            Response.Redirect("Homepage.aspx");
        }

        protected void LinkButton28_Click(object sender, EventArgs e)
        {
            Response.Redirect("userprofile.aspx");

        }
    }
}