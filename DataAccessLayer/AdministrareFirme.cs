using System.Collections.Generic;
using System.Data;
using LibrarieModele;
using Oracle.DataAccess.Client;

namespace NivelAccesDate
{
    public class AdministrareFirme: IStocareFirme
    {
        private const int PRIMUL_TABEL = 0;
        private const int PRIMA_LINIE = 0;

        public List<Firma> GetFirme()
        {
            var result = new List<Firma>();
            
            var dsFirme = SqlDBHelper.ExecuteDataSet("select * from DELIVERY_COMPANIES_DG WHERE IS_DELETED = 1", CommandType.Text);

            foreach (DataRow linieDB in dsFirme.Tables[PRIMUL_TABEL].Rows)
            {
                result.Add( new Firma(linieDB));
            }
            return result;
        }

        public Firma GetFirma(int id)
        {
            Firma result = null;
            var dsFirme = SqlDBHelper.ExecuteDataSet("select * from DELIVERY_COMPANIES_DG where id = :IdCompanie", CommandType.Text,
            new OracleParameter(":IdCompanie", OracleDbType.Int32, id, ParameterDirection.Input));

            if (dsFirme.Tables[PRIMUL_TABEL].Rows.Count > 0)
            {
                DataRow linieDB = dsFirme.Tables[PRIMUL_TABEL].Rows[PRIMA_LINIE];
                result = new Firma(linieDB);
            }
            return result;
        }

        public bool AddFirma(Firma comp)
        {
            return SqlDBHelper.ExecuteNonQuery(
                "INSERT INTO DELIVERY_COMPANIES_DG VALUES (FIRME_LIVRATI_ID_SEQ.nextval, :Name, :LogoUrl, 1)", CommandType.Text,
                new OracleParameter(":Name", OracleDbType.NVarchar2, comp.Name, ParameterDirection.Input),
                new OracleParameter(":LogoUrl", OracleDbType.NVarchar2, comp.LogoUrl, ParameterDirection.Input));
        }

        public bool UpdateFirma(Firma comp)
        {
            return SqlDBHelper.ExecuteNonQuery(
                "UPDATE DELIVERY_COMPANIES_DG set NAME = :Name, LOGO_URL = :LogoUrl, IS_DELETED = 1 where ID = :IdFirma", CommandType.Text,
                new OracleParameter(":Name", OracleDbType.NVarchar2, comp.Name, ParameterDirection.Input),
                new OracleParameter(":LogoUrl", OracleDbType.NVarchar2, comp.LogoUrl, ParameterDirection.Input),
                new OracleParameter(":IdFirma", OracleDbType.NVarchar2, comp.Id, ParameterDirection.Input));
        }
        public bool DeleteFirma(int id)
        {
            return SqlDBHelper.ExecuteNonQuery(
                 "UPDATE DELIVERY_COMPANIES_DG set IS_DELETED = 0 where ID = :IdFirma", CommandType.Text,
                 new OracleParameter(":IdFirma", OracleDbType.NVarchar2, id, ParameterDirection.Input));
        }
    }
}
