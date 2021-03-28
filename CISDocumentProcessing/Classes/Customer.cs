using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CISDocumentProcessing.Classes
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Bank { get; set; }
        public string Inn { get; set; }
        public string Address { get; set; }

        public Customer(int id, string name, string phone, string bank, string inn, string address)
        {
            Id = id;
            Name = name;
            Phone = phone;
            Bank = bank;
            Inn = inn;
            Address = address;
        }
        public Customer(IDataReader row)
        {
            Id = (int)row["CId"];
            Name = (string)row["CName"];
            Phone = (string)row["CPhone"];
            Bank = (string)row["CBank"];
            Inn = (string)row["CInn"];
            Address = row["CAddress"] == DBNull.Value ? "отсутствует" : (string)row["CAddress"]; 
        }

    }
}
