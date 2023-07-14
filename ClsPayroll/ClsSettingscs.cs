using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsPayroll
{
    public class ClsSettings
    {
        connection con = new connection();
        public DataSet LoadMonthDetails(string monthId)
        {
            return con.dataGet("Select month,CONVERT(NVARCHAR(10),StartDate,103) AS StartDate,CONVERT(NVARCHAR(10),End_date,103) AS End_date,Monthdate,lever_per_year from setting where setting_id ='" +monthId+ "'");
        }

        public void SaveMonthDetails(string monthId,string Month,string SalaryDate,string StartDate,string EndDate,string LeavePerYear)
        {
            String C = "INSERT INTO Setting(Setting_id, month, Monthdate, StartDate, End_date, lever_per_year)VALUES('" + monthId + "','" + Month + "','" + SalaryDate + "','" + StartDate + "','" + EndDate + "','" + LeavePerYear + "')";
            con.Datasend(C);
        }
        public void UpdateMonthDetails(string monthId, string Month, string SalaryDate, string StartDate, string EndDate, string LeavePerYear)
        {
            String C = "update Setting set month='" + Month + "',Monthdate='" + SalaryDate + "',startDate='" + StartDate + "',End_date='" + EndDate + "',lever_per_year='" + LeavePerYear + "' where setting_id='" + monthId + "'";
            con.Datasend(C);
        }

    }
}
