using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsPayroll
{
    public class ClsSalary
    {
        connection con = new connection();
        private string txtallownces;
        private string txtbase;
        private string txtgross;
        private string txtid;
        private string txtmonth;
        private string txtname;
        private string txtnopay;
        private string txtNoPayDays;
        private string txtot;
        private string txtOtRate;
        private string txtsalary;
        private string txttax;
        private string txtworkingDays;

        //{
        //    return con.dataGet("Select month,CONVERT(NVARCHAR(10),StartDate,103) AS StartDate,CONVERT(NVARCHAR(10),End_date,103) AS End_date,Monthdate,lever_per_year from setting where setting_id ='" + monthId + "'");
        //}

        //public DataSet LoadMonthDetails(string monthId)
        //Emp_id, Emp_Name, Salary, Allownces, Tax, OT_Rate, OT_Hours, Monthdate, Month, Basepay, Nopay_Deduct, Grosspay, NoPay_Days
        public void SaveSalaryDetails(string Empid, string EmpName, string Salary, string Allownce, string Tax, string OtRate, string OtHours, string MonthDate, string Month, string BasePay, string NopayDeduct, string Grosspay , string NoPayDays)
        {
            //String C = "INSERT INTO Setting(Setting_id, month, Monthdate, StartDate, End_date, lever_per_year)VALUES('" + monthId + "','" + Month + "','" + SalaryDate + "','" + StartDate + "','" + EndDate + "','" + LeavePerYear + "')";
            String C = "INSERT INTO Salary(Emp_id, Emp_Name, Salary, Allownces, Tax, OT_Rate, OT_Hours, Monthdate, Month, Basepay, Nopay_Deduct, Grosspay, NoPay_Days)VALUES ('" + Empid + "','" + EmpName + "','" + Salary + "','" + Allownce + "','" + Tax + "','" + OtRate + "','" + OtHours + "','" + MonthDate + "','" + Month + "','" + BasePay + "','" + NopayDeduct + "','" + Grosspay + "','" + NoPayDays + "')";
            con.Datasend(C);
        }
        public void UpdateSalaryDetails(string Empid, string EmpName, string Salary, string Allownce, string Tax, string OtRate, string OtHours, string MonthDate, string Month, string BasePay, string NopayDeduct, string Grosspay, string NoPayDays)
        {
            String C = "update salary set emp_name='" + EmpName + "',salary='" + Salary + "',Allownces='" + Allownce + "',Tax='" + Tax+ "',OT_Rate='" + OtRate+ "',OT_Hours='" + OtHours + "',Monthdate='" + MonthDate + "',Month='" + Month + "',Basepay='" + BasePay + "',Nopay_Deduct='" + NopayDeduct + "',Grosspay='" + Grosspay + "',NoPay_Days='" + NoPayDays + "' where Emp_id ='"+Empid+"')";
            con.Datasend(C);
        }
        public void DeleteSalaryDetails(string Empid, string EmpName, string Salary, string Allownce, string Tax, string OtRate, string OtHours, string MonthDate, string Month, string BasePay, string NopayDeduct, string Grosspay, string NoPayDays)
        {
            String C = "Delete from salary where Emp_id ='" + Empid + "')";
            con.Datasend(C);
        }
    }
}
