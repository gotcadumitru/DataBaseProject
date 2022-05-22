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
            var dsFirme = SqlDBHelper.ExecuteDataSet("select * from DELIVERY_COMPANIES_DG", CommandType.Text);
            //var response = SqlDBHelper.ExecuteDataSet("CREATE TABLE DELIVERY_COMPANIES_DG ( ID NUMBER(3) CONSTRAINT pk_dg_firma_id PRIMARY KEY, NAME VARCHAR2(100) CONSTRAINT nn_dg_firma_name NOT NULL, LOGO_URL VARCHAR2(100) CONSTRAINT nn_dg_firma_logo_url NOT NULL )", CommandType.Text);

            foreach (DataRow linieDB in dsFirme.Tables[PRIMUL_TABEL].Rows)
            {
                result.Add( new Firma(linieDB));
            }
            return result;
        }

        public Firma GetFirma(int id)
        {
            Firma result = null;
            var dsFirme = SqlDBHelper.ExecuteDataSet("select * from companii_DEV where IdCompanie = :IdCompanie", CommandType.Text,
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
                "INSERT INTO companii_DEV VALUES (seq_companii_DEV.nextval, :Name, :LogoUrl)", CommandType.Text,
                new OracleParameter(":Name", OracleDbType.NVarchar2, comp.Name, ParameterDirection.Input),
                new OracleParameter(":LogoUrl", OracleDbType.NVarchar2, comp.LogoUrl, ParameterDirection.Input));
        }

        public bool UpdateFirma(Firma comp)
        {
            return SqlDBHelper.ExecuteNonQuery(
                "UPDATE companii_DEV set Name = :Name, LogoUrl = :LogoUrl", CommandType.Text,
                new OracleParameter(":Name", OracleDbType.NVarchar2, comp.Name, ParameterDirection.Input),
                new OracleParameter(":LogoUrl", OracleDbType.NVarchar2, comp.LogoUrl, ParameterDirection.Input));
        }
    }
}
