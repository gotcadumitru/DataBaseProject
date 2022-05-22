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
            //var response = SqlDBHelper.ExecuteDataSet("CREATE SEQUENCE FIRME_LIVRATI_ID_SEQ START WITH 1 INCREMENT BY 1 CACHE 100", CommandType.Text);
            //var response = SqlDBHelper.ExecuteDataSet("CREATE TABLE VEHICLE_TYPE_DG ( ID NUMBER(3) CONSTRAINT pk_dg_veh_type_id PRIMARY KEY, TYPE VARCHAR2(100) CONSTRAINT ck_dg_veh_type_type CHECK(TYPE = ANY('AUTO', 'MOTO', 'ELECTRIC SCOOTER', 'BICYCLE')))", CommandType.Text);
            //var response = SqlDBHelper.ExecuteDataSet("CREATE TABLE VEHICLES_DG ( ID NUMBER(3) CONSTRAINT pk_dg_veh_id PRIMARY KEY, MODEL VARCHAR2(100) CONSTRAINT nn_dg_veh_model NOT NULL, MARK VARCHAR2(100) CONSTRAINT nn_dg_veh_mark NOT NULL, TYPE_ID NUMBER(3) CONSTRAINT fk_dg_veh_mark REFERENCES VEHICLE_TYPE_DG(ID))", CommandType.Text);
            //var response = SqlDBHelper.ExecuteDataSet("CREATE TABLE DELIVERY_COMPANIES_DG ( ID NUMBER(3) CONSTRAINT pk_dg_firma_id PRIMARY KEY, NAME VARCHAR2(100) CONSTRAINT nn_dg_firma_name NOT NULL, LOGO_URL VARCHAR2(100) CONSTRAINT nn_dg_firma_logo_url NOT NULL )", CommandType.Text);
            //var response = SqlDBHelper.ExecuteDataSet("CREATE TABLE EMPLOYEES_DG ( ID NUMBER(3) CONSTRAINT pk_dg_employee_id PRIMARY KEY, FIRST_NAME VARCHAR2(100) CONSTRAINT nn_dg_employee_first_name NOT NULL, LAST_NAME VARCHAR2(100) CONSTRAINT nn_dg_employee_last_name NOT NULL, HIRE_DATE Date CONSTRAINT nn_dg_employee_hire_date NOT NULL, BIRTH_DATE Date CONSTRAINT nn_dg_employee_birth_date NOT NULL, EMAIL VARCHAR2(100) CONSTRAINT nn_dg_employee_email NOT NULL, COMPANY_ID NUMBER(3) CONSTRAINT fk_dg_employee_company_id REFERENCES DELIVERY_COMPANIES_DG(ID), NUMBER_OF_DELIVERIES NUMBER(3) CONSTRAINT nn_dg_employee_numb_of_deliv NOT NULL, VEHICLE_ID NUMBER(3) CONSTRAINT fk_dg_employee_vehicle_id REFERENCES VEHICLES_DG(ID))", CommandType.Text);
            
            var dsFirme = SqlDBHelper.ExecuteDataSet("select * from DELIVERY_COMPANIES_DG", CommandType.Text);

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
                "INSERT INTO DELIVERY_COMPANIES_DG VALUES (FIRME_LIVRATI_ID_SEQ.nextval, :Name, :LogoUrl)", CommandType.Text,
                new OracleParameter(":Name", OracleDbType.NVarchar2, comp.Name, ParameterDirection.Input),
                new OracleParameter(":LogoUrl", OracleDbType.NVarchar2, comp.LogoUrl, ParameterDirection.Input));
        }

        public bool UpdateFirma(Firma comp)
        {
            return SqlDBHelper.ExecuteNonQuery(
                "UPDATE DELIVERY_COMPANIES_DG set NAME = :Name, LOGO_URL = :LogoUrl where ID = :IdFirma", CommandType.Text,
                new OracleParameter(":Name", OracleDbType.NVarchar2, comp.Name, ParameterDirection.Input),
                new OracleParameter(":LogoUrl", OracleDbType.NVarchar2, comp.LogoUrl, ParameterDirection.Input),
                new OracleParameter(":IdFirma", OracleDbType.NVarchar2, comp.Id, ParameterDirection.Input));
        }
    }
}
