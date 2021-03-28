using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CISDocumentProcessing.Classes
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Cost { get; set; }
        public int LeaderId { get; set; }
        public string LeaderName { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string RepresentativeName { get; set; }
        public string RepresentativePhone { get; set; }
        public int BonusAmount { get; set; }
        public Project(int id, string name, DateTime startDate, DateTime endDate, int cost, int leaderId, 
                       string leaderName, int customerId, string customerName, string representativeName = null, 
                       string representativePhone = null, int bonusAmount = 0)
        {
            Id = id;
            Name = name;
            StartDate = startDate;
            EndDate = endDate;
            Cost = cost;
            LeaderId = leaderId;
            LeaderName = leaderName;
            CustomerId = customerId;
            CustomerName = customerName;
            RepresentativeName = representativeName;
            RepresentativePhone = representativePhone;
            BonusAmount = bonusAmount;
        }

        public Project(IDataReader reader)
        {
            Id = (int)reader["PId"];
            Name = (string)reader["PName"];
            StartDate = (DateTime)reader["PStartDate"];
            EndDate = (DateTime)reader["PEndDate"];
            Cost = (int)reader["PCost"];
            LeaderId = (int)reader["EId"];
            LeaderName = (string)reader["EName"];
            CustomerId = (int)reader["CId"];
            CustomerName = (string)reader["CName"];
            RepresentativeName = (string)reader["PCRepresentativeName"];
            RepresentativePhone = (string)reader["PCRepresentativePhone"];
            BonusAmount = (int)reader["PBonusAmount"];
        }
    }
}
