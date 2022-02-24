using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace fastfood2
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string conectionstring = null;
            SqlConnection connection = null;
            string sql = null;
            

                conectionstring = @"Data Source=DESKTOP-CUCLDV1\MSSQLSERVER2;Initial Catalog=fastfood2;Integrated Security=True";
                sql = "select * from custumer2";
              var  sql2 = "select sum (price) from custumer2";

            connection = new SqlConnection(conectionstring);
                var dataAdapter = new SqlDataAdapter(sql, connection);
            var dataAdapter2 = new SqlDataAdapter(sql2, connection);
            //sql = "INSERT INTO custumer2 (id,name,price) VALUES ( 1,'gg',30)";

            var command = new SqlCommandBuilder(dataAdapter);
            var command2 = new SqlCommandBuilder(dataAdapter2);
            var ds = new DataSet();
            var ds2 = new DataSet();
            dataAdapter.Fill(ds);
            dataAdapter2.Fill(ds2);
            
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();

            GridView2.DataSource = ds2.Tables[0];
            GridView2.DataBind();






        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string conectionstring = null;
            SqlConnection connection = null;
            string sql = null;
            SqlCommand command;

            try
            {
                conectionstring = @"Data Source=DESKTOP-CUCLDV1\MSSQLSERVER2;Initial Catalog=fastfood2;Integrated Security=True";
                connection = new SqlConnection(conectionstring);
                sql = "delete from custumer2";
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