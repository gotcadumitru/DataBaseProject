using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    internal class VehicleType
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public VehicleType(int id, string type)
        {
            Id = id;
            Type = type;
        }

        public VehicleType(DataRow linieBD)
        {
            Id = Convert.ToInt32(linieBD["id"].ToString());
            Type = linieBD["type"].ToString();
        }
    }
}
