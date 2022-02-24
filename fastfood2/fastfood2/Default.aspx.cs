using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace fastfood2
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
           
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            string conectionstring = null;
            SqlConnection connection = null;
            string sql = null;
            SqlCommand command;

            try
            {
                conectionstring = @"Data Source=DESKTOP-CUCLDV1\MSSQLSERVER2;Initial Catalog=fastfood2;Integrated Security=True";
                connection = new SqlConnection(conectionstring);
                sql = "INSERT INTO custumer2 (name,price) VALUES ('burger',5)";
                // sql = "select * from custumer2";
                command = new SqlCommand(sql, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            string conectionstring = null;
            SqlConnection connection = null;
            string sql = null;
            SqlCommand command;

            try
            {
                conectionstring = @"Data Source=DESKTOP-CUCLDV1\MSSQLSERVER2;Initial Catalog=fastfood2;Integrated Security=True";
                connection = new SqlConnection(conectionstring);
                sql = "INSERT INTO custumer2 (name,price) VALUES ('cake',2)";
                // sql = "select * from custumer2";
                command = new SqlCommand(sql, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }
        }

        protected void Button3_Click1(object sender, EventArgs e)
        {
            string conectionstring = null;
            SqlConnection connection = null;
            string sql = null;
            SqlCommand command;

            try
            {
                conectionstring = @"Data Source=DESKTOP-CUCLDV1\MSSQLSERVER2;Initial Catalog=fastfood2;Integrated Security=True";
                connection = new SqlConnection(conectionstring);
                sql = "INSERT INTO custumer2 (name,price) VALUES ('pizza',4)";
                //sql = "select * from custumer2";
                command = new SqlCommand(sql, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }
        }
    }
}