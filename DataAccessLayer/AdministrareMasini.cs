using System.Collections.Generic;
using System.Data;
using LibrarieModele;
using Oracle.DataAccess.Client;

namespace NivelAccesDate
{
    public class AdministrareMasini: IStocareMasini
    {
        private const int PRIMUL_TABEL = 0;
        private const int PRIMA_LINIE = 0;

        public List<Masina> GetMasini()
        {
            var result = new List<Masina>();
            var dsMasini = SqlDBHelper.ExecuteDataSet("select * from VEHICLES_DG", CommandType.Text);
            foreach (DataRow linieDB in dsMasini.Tables[PRIMUL_TABEL].Rows)
            {
                result.Add(new Masina(linieDB));
            }
            return result;
        }

        public Masina GetMasina(int id)
        {
            Masina result = null;
            var dsMasini = SqlDBHelper.ExecuteDataSet("select * from VEHICLES_DG where id = :IdMasina", CommandType.Text,
                new OracleParameter(":IdMasina", OracleDbType.Int32, id, ParameterDirection.Input));
            if (dsMasini.Tables[PRIMUL_TABEL].Rows.Count > 0)
            {
                DataRow linieDB = dsMasini.Tables[PRIMUL_TABEL].Rows[PRIMA_LINIE];
                result = new Masina(linieDB);
            }
            return result;
        }

        public bool AddMasina(Masina m)
        {
            return SqlDBHelper.ExecuteNonQuery(
                "insert into VEHICLES_DG VALUES (MASINI_ID_DG_SEQ.nextval, :Model, :Mark, :TypeId)", CommandType.Text,
                new OracleParameter(":Model", OracleDbType.NVarchar2, m.Model, ParameterDirection.Input),
                new OracleParameter(":Mark", OracleDbType.NVarchar2, m.Mark, ParameterDirection.Input),
                new OracleParameter(":TypeId", OracleDbType.Int32, m.TypeId, ParameterDirection.Input)
            );
        }

        public bool UpdateMasina(Masina m)
        {
            return SqlDBHelper.ExecuteNonQuery(
                "UPDATE VEHICLES_DG set model =:Model, mark =:Mark, type_id =:TypeId where id=:Id", CommandType.Text,
               new OracleParameter(":Model", OracleDbType.NVarchar2, m.Model, ParameterDirection.Input),
                new OracleParameter(":Mark", OracleDbType.NVarchar2, m.Mark, ParameterDirection.Input),
                new OracleParameter(":TypeId", OracleDbType.Int32, m.TypeId, ParameterDirection.Input),
                  new OracleParameter(":Id", OracleDbType.Int32, m.Id, ParameterDirection.Input)
            );
        }
    }
}
