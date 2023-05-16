using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grifindo_Payroll_system_new
{
    class connection
    {
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataAdapter sda;
        public string pkk;

        public void Connection()
        {
            con = new SqlConnection(@"Data source=(local);initial Catalog=Payroll;User Id=sa;Password=itonimta");
            con.Open();

        }
        public void Datasend(string SQL)
        {
            try
            {
                Connection();
                cmd = new SqlCommand(SQL, con);
                cmd.ExecuteNonQuery();
                pkk = "";
            }
            catch (Exception)
            {
                pkk = "Please check Your Data";
            }
            con.Close();

        }
        public void dataGet(String SQL)
        {
            try
            {
                Connection();
                sda = new SqlDataAdapter(SQL, con);

            }
            catch (Exception)
            {


            }
        }
    }
}
