using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CISDocumentProcessing.Classes
{
    public class EmployeePayment
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int Amount { get; set; }
        public string PaymentType { get; set; }

        public EmployeePayment(int id, DateTime date, int employeeId, string employeeName, int amount, string paymentType)
        {
            Id = id;
            Date = date;
            EmployeeId = employeeId;
            EmployeeName = employeeName;
            Amount = amount;
            PaymentType = paymentType;
        }

        public EmployeePayment(IDataReader row)
        {
            Id = (int)row["EPId"];
            Date = (DateTime)row["EPDate"];
            EmployeeId = (int)row["EId"];
            EmployeeName = (string)row["EName"];
            Amount = (int)row["EPAmount"];
            PaymentType = (string)row["EPType"];
        }
    }
}
