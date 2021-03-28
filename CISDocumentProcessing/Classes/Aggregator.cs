using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Data;

namespace CISDocumentProcessing.Classes
{
    public static class Aggregator
    {
        private static MySqlConnection _conn = new MySqlConnection();
        
        public static bool InitiateConnection(string user, string password)
        {
            try
            {
                string _connString = $"SERVER=remotemysql.com;PORT=3306;DATABASE=tLEtNiLFPl;UID={user};PASSWORD={password}";

                _conn = new MySqlConnection();
                _conn.ConnectionString = _connString;
                
                _conn.Open();
                _conn.Close();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static void ExecuteNonQuery(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, _conn);

            _conn.Open();

            cmd.ExecuteNonQuery();

            _conn.Close();
        }

        public static IDataReader ExecuteReader(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, _conn);

            _conn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(reader);
            
            _conn.Close();

            return dt.CreateDataReader();
        }

        public static List<Employee> GetEmployees(string filter = "")
        {
            List<Employee> emps = new List<Employee>();
            string query =
                $"SELECT * FROM employee {filter};";

            using (var reader = Aggregator.ExecuteReader(query))
            {
                while (reader.Read()) emps.Add(new Employee(reader));
            }
            return emps;
        }
        public static List<EmployeePayment> GetPayments(string filter = "")
        {
            List<EmployeePayment> payments = new List<EmployeePayment>();
            string query = 
                $"SELECT EPId, EPDate, EId, EName, EPAmount, EPType " +
                $"FROM employee JOIN employee_payment USING(EId) " +
                $"{filter};";

            using (var reader = Aggregator.ExecuteReader(query))
            {
                while (reader.Read()) payments.Add(new EmployeePayment(reader));
            }
            return payments;
        }

        public static List<Project> GetProjects(string filter = "")
        {
            List<Project> projects = new List<Project>();
            string query = 
                $"SELECT PId, PName, PStartDate, PEndDate, PCost, EId, EName, CId, CName, " +
                $"PCRepresentativeName, PCRepresentativePhone, PBonusAmount " +
                $"FROM project JOIN employee ON (project.PLeaderEId = employee.EId) " +
                $"JOIN customer USING(CId) " +
                $"{filter};";

            using (var reader = Aggregator.ExecuteReader(query))
            {
                while (reader.Read()) projects.Add(new Project(reader));
            }
            return projects;
        }
        public static Employee GetEmployeeById(int id)
        {
            string query = 
                $"SELECT * FROM employee WHERE EId={id};";

            using (var reader = Aggregator.ExecuteReader(query))
            {
                reader.Read();
                return new Employee(reader);
            }
        }
        public static EmployeePayment GetPaymentById(int id)
        {
            string query = 
                $"SELECT EPId, EPDate, EId, EName, EPAmount, EPType " +
                $" FROM employee JOIN employee_payment USING(EId) WHERE EPId={id};";

            using (var reader = Aggregator.ExecuteReader(query))
            {
                reader.Read();
                return new EmployeePayment(reader);
            }
        }
        public static List<EmployeePayment> GetPaymentsByEmployeeId(int id)
        {
            List<EmployeePayment> payments = new List<EmployeePayment>();
            string query =
                $"SELECT EPId, EPDate, EId, EName, EPAmount, EPType " +
                $" FROM employee JOIN employee_payment USING(EId) WHERE EId={id};";

            using (var reader = Aggregator.ExecuteReader(query))
            {
                while (reader.Read()) payments.Add(new EmployeePayment(reader));
            }
            return payments;
        }
        public static Project GetProjectById(int id)
        {
            string query =
                $"SELECT PId, PName, PStartDate, PEndDate, PCost, EId, EName, CId, CName, PCRepresentativeName, " +
                $"PCRepresentativePhone, PBonusAmount FROM project " +
                $"JOIN employee ON (project.PLeaderEId = employee.EId) " +
                $"JOIN customer USING(CId) WHERE PId={id}";

            using (var reader = Aggregator.ExecuteReader(query))
            {
                reader.Read();
                return new Project(reader);
            }
        }
        public static List<Project> GetProjectsByEmployeeId(int id)
        {
            List<Project> projects = new List<Project>();
            string query =
                $"SELECT PId, PName, PStartDate, PEndDate, PCost, EId, EName, CId, CName, PCRepresentativeName, " +
                $"PCRepresentativePhone, PBonusAmount FROM project " +
                $"JOIN employee ON (project.PLeaderEId = employee.EId) " +
                $"JOIN customer USING(CId) " +
                $"WHERE PLeaderEId={id} OR PId IN (" +
                $"SELECT PId FROM employee_project " +
                $"WHERE EId={id});";

            using (var reader = Aggregator.ExecuteReader(query))
            {
                while (reader.Read()) projects.Add(new Project(reader));
            }
            return projects;
        }
        public static Customer GetCustomerById(int id)
        {
            string query =
                $"SELECT * FROM customer WHERE CId={id};";

            using (var reader = Aggregator.ExecuteReader(query))
            {
                reader.Read();
                return new Customer(reader);
            }
        }
        public static List<Employee> GetEmployeesByProjectId(int id)
        {
            List<Employee> emps = new List<Employee>();
            string query =
                $"SELECT * FROM employee " +
                $"WHERE EId=(" +
                $"SELECT PLeaderEId FROM project " +
                $"WHERE PId={id}) " +
                $"OR EId IN (" +
                $"SELECT EId FROM employee_project " +
                $"WHERE PId={id});";

            using (var reader = Aggregator.ExecuteReader(query))
            {
                while (reader.Read()) emps.Add(new Employee(reader));
            }
            return emps;
        }
    }
}
