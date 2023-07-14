using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClsPayroll
{
   public class connection
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
        public DataSet dataGet(String SQL)
        {
            try
            {
                DataSet ds = new DataSet();
                Connection();
                sda = new SqlDataAdapter(SQL, con);
                sda.Fill(ds);
                return ds;
            }
            catch (Exception)
            {
                throw;

            }
        }

        public static void ErrLog(Exception ex)
        {
            //DateTime dtCurrentDate = DateTime.Now;
            //FileStream fileStream = new FileStream(@"..\ErrorLog.txt", FileMode.Append);
            //StreamWriter m_streamWriter = new StreamWriter(fileStream);

            //try
            //{
            //    m_streamWriter.WriteLine("Date/Time :' " + string.Format("{0:dd/MM/yyyy HH:mm:ss}", dtCurrentDate) + "'frmAccount 012. Error Description " + ex.Message + " 'Location :' " + LoginManager.LocaCode + " 'User Name :' " + LoginManager.UserName.Trim() + " '");
            //    // read from file or write to file
            //}
            //finally
            //{
            //    m_streamWriter.Close();
            //    fileStream.Close();
            //}
            MessageBox.Show("Errror" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
