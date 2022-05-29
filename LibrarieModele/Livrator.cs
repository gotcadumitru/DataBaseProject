using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    public class Livrator
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public int CompanyId { get; set; }
        public int NumberOfDeliveries { get; set; }
        public int VehicleId{ get; set; }
        public int isDeleted { get; set; }

        public Livrator(int id, string firstName, string lastName, DateTime hireDate, DateTime birthDate, string email, int companyId, int numberOfDeliveries, int vehicleId)
        {

            Id = id;
            FirstName = firstName;
            LastName = lastName;
            HireDate = hireDate;
            BirthDate = birthDate;
            Email = email;
            CompanyId = companyId;
            NumberOfDeliveries = numberOfDeliveries;
            VehicleId= vehicleId;
            isDeleted = 1;
            Console.WriteLine("");
        }

        public Livrator(DataRow linieBD)
        {
            Id = Convert.ToInt32(linieBD["id"].ToString());
            FirstName = linieBD["first_name"].ToString();
            LastName = linieBD["last_name"].ToString();
            HireDate = Convert.ToDateTime(linieBD["hire_date"].ToString());
            BirthDate = Convert.ToDateTime(linieBD["birth_date"].ToString());
            Email = linieBD["email"].ToString();
            CompanyId = Convert.ToInt32(linieBD["company_id"].ToString());
            NumberOfDeliveries = Convert.ToInt32(linieBD["number_of_deliveries"].ToString());
            VehicleId = Convert.ToInt32(linieBD["vehicle_id"].ToString());
            isDeleted = Convert.ToInt32(linieBD["is_deleted"].ToString());
        }


    }
}
