using System;
using System.Data;

namespace LibrarieModele
{
    public class Masina
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Mark { get; set; }
        public int TypeId { get; set; }


        public Masina()
        { }
        public Masina(int id, string model, string mark, int type)
        {
            Id = id;
            Model = model;
            Mark = mark;
            TypeId = type;
        }

        public Masina (DataRow linieBD)
        {
            Id = Convert.ToInt32(linieBD["id"].ToString());
            Model = linieBD["model"].ToString();
            Mark = linieBD["mark"].ToString();
            TypeId = Convert.ToInt32(linieBD["type_id"].ToString());
        }
    }
}
