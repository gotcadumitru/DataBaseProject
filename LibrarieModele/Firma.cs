using System;
using System.Data;

namespace LibrarieModele
{
    public class Firma
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LogoUrl { get; set; }
        public Firma()
        { }

        public Firma (string nume, string logo, int idFirma = 0)
        {
            Id = idFirma;
            Name = nume;
            LogoUrl = logo;
        }

        public Firma (DataRow linieDB)
        {
            Id = Convert.ToInt32(linieDB["id"].ToString());
            Name = linieDB["name"].ToString();
            LogoUrl = linieDB["logo_url"].ToString();
        }
    }
}
