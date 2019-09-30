using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    class Connection
    {
        public SqlConnection con;
        public string str;

        public Connection()
        {
            try
            {
                str = @"Data Source=.;Initial Catalog=SchoolManagementSystemDB;Integrated Security=True";
                con = new SqlConnection(str);
                con.Open();

            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);

            }
        }
    }
}
