using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Data;
using System.IO;

namespace CISDocumentProcessing.Classes
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string District { get; set; }
        public int Experience { get; set; }
        public DateTime Birthdate { get; set; }
        public string MainLanguage { get; set; }
        public string Education { get; set; }
        public int Salary { get; set; }
        public string Perks { get; set; }
        public Image Photo { get; set; }
        public string Notes { get; set; }

        public Employee(int id, string name, int experience, DateTime birthdate, string mainLanguage, int salary, Image photo, 
                        string address = null, string district = null, string education = null, string perks = null, string notes = null)
        {
            Id = id;
            Name = name;
            Address = address;
            District = district;
            Experience = experience;
            Birthdate = birthdate;
            MainLanguage = mainLanguage;
            Education = education;
            Salary = salary;
            Perks = perks;
            Photo = photo;
            Notes = notes;
        }
        public Employee(IDataReader row)
        {
            // Конвертируем байты в фото
            Image photo;

            if (row["EPhoto"] != DBNull.Value)
            {
                using (var ms = new MemoryStream((byte[])row["EPhoto"]))
                {
                    photo = Image.FromStream(ms);
                }
            }
            else photo = null;

            Id = (int)row["EId"];
            Name = (string)row["EName"];
            Address = row["EAddress"] == DBNull.Value ? string.Empty : (string)row["EAddress"]; ;
            District = row["EDistrict"] == DBNull.Value ? string.Empty : (string)row["EDistrict"]; ;
            Experience = (int)row["EExperience"];
            Birthdate = (DateTime)row["EBirthdate"];
            MainLanguage = (string)row["EMainLanguage"];
            Education = row["EEducation"] == DBNull.Value ? string.Empty : (string)row["EEducation"]; ;
            Salary = (int)row["ECurrentSalary"];
            Perks = row["EPerks"] == DBNull.Value ? string.Empty : (string)row["EPerks"]; ;
            Photo = photo;
            Notes = row["ENotes"] == DBNull.Value ? string.Empty : (string)row["ENotes"]; ;
        }
    }
}
