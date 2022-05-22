using System.Collections.Generic;
using System.Data;
using LibrarieModele;
using Oracle.DataAccess.Client;

namespace NivelAccesDate
{
    public class AdministrareLivratori : IStocareLivratori
    {
        private const int PRIMUL_TABEL = 0;
        private const int PRIMA_LINIE = 0;

        public List<Employee> GetLivatori(int firmaId)
        {
            var result = new List<Employee>();

            // add car types
            //SqlDBHelper.ExecuteDataSet("INSERT INTO VEHICLE_TYPE_DG VALUES(1,'AUTO')", CommandType.Text);
            //SqlDBHelper.ExecuteDataSet("INSERT INTO VEHICLE_TYPE_DG VALUES(2,'BICYCLE')", CommandType.Text);
            //SqlDBHelper.ExecuteDataSet("INSERT INTO VEHICLE_TYPE_DG VALUES(3,'ELECTRIC SCOOTER')", CommandType.Text);
            //SqlDBHelper.ExecuteDataSet("INSERT INTO VEHICLE_TYPE_DG VALUES(4,'MOTO ')", CommandType.Text);

            //create tables
            //var response1 = SqlDBHelper.ExecuteDataSet("CREATE SEQUENCE MASINI_ID_DG_SEQ START WITH 1 INCREMENT BY 1 CACHE 100", CommandType.Text);
            //var response1 = SqlDBHelper.ExecuteDataSet("CREATE SEQUENCE EMPLOYEE_ID_SEQ START WITH 1 INCREMENT BY 1 CACHE 100", CommandType.Text);
            //var response2 = SqlDBHelper.ExecuteDataSet("CREATE SEQUENCE FIRME_LIVRATI_ID_SEQ START WITH 1 INCREMENT BY 1 CACHE 100", CommandType.Text);
            //var response3 = SqlDBHelper.ExecuteDataSet("CREATE TABLE VEHICLE_TYPE_DG ( ID NUMBER(3) CONSTRAINT pk_dg_veh_type_id PRIMARY KEY, TYPE VARCHAR2(100) CONSTRAINT ck_dg_veh_type_type CHECK(TYPE = ANY('AUTO', 'MOTO', 'ELECTRIC SCOOTER', 'BICYCLE')))", CommandType.Text);
            //var response4 = SqlDBHelper.ExecuteDataSet("CREATE TABLE VEHICLES_DG ( ID NUMBER(3) CONSTRAINT pk_dg_veh_id PRIMARY KEY, MODEL VARCHAR2(100) CONSTRAINT nn_dg_veh_model NOT NULL, MARK VARCHAR2(100) CONSTRAINT nn_dg_veh_mark NOT NULL, TYPE_ID NUMBER(3) CONSTRAINT fk_dg_veh_mark REFERENCES VEHICLE_TYPE_DG(ID))", CommandType.Text);
            //var response5 = SqlDBHelper.ExecuteDataSet("CREATE TABLE DELIVERY_COMPANIES_DG ( ID NUMBER(3) CONSTRAINT pk_dg_firma_id PRIMARY KEY, NAME VARCHAR2(100) CONSTRAINT nn_dg_firma_name NOT NULL, LOGO_URL VARCHAR2(100) CONSTRAINT nn_dg_firma_logo_url NOT NULL )", CommandType.Text);
            //var response6 = SqlDBHelper.ExecuteDataSet("CREATE TABLE EMPLOYEES_DG ( ID NUMBER(3) CONSTRAINT pk_dg_employee_id PRIMARY KEY, FIRST_NAME VARCHAR2(100) CONSTRAINT nn_dg_employee_first_name NOT NULL, LAST_NAME VARCHAR2(100) CONSTRAINT nn_dg_employee_last_name NOT NULL, HIRE_DATE Date CONSTRAINT nn_dg_employee_hire_date NOT NULL, BIRTH_DATE Date CONSTRAINT nn_dg_employee_birth_date NOT NULL, EMAIL VARCHAR2(100) CONSTRAINT nn_dg_employee_email NOT NULL, COMPANY_ID NUMBER(3) CONSTRAINT fk_dg_employee_company_id REFERENCES DELIVERY_COMPANIES_DG(ID), NUMBER_OF_DELIVERIES NUMBER(3) CONSTRAINT nn_dg_employee_numb_of_deliv NOT NULL, VEHICLE_ID NUMBER(3) CONSTRAINT fk_dg_employee_vehicle_id REFERENCES VEHICLES_DG(ID))", CommandType.Text);

            var dsFirme = SqlDBHelper.ExecuteDataSet("select * from EMPLOYEES_DG where company_id = :IdCompanie", CommandType.Text,
                     new OracleParameter(":IdCompanie", OracleDbType.Int32, firmaId, ParameterDirection.Input));

            foreach (DataRow linieDB in dsFirme.Tables[PRIMUL_TABEL].Rows)
            {
                result.Add(new Employee(linieDB));
            }
            return result;
        }

        public Employee GetLivrator(int id)
        {
            Employee result = null;
            var dsLivratori= SqlDBHelper.ExecuteDataSet("select * from EMPLOYEES_DG where id = :IdLivrator", CommandType.Text,
            new OracleParameter(":IdLivrator", OracleDbType.Int32, id, ParameterDirection.Input));

            if (dsLivratori.Tables[PRIMUL_TABEL].Rows.Count > 0)
            {
                DataRow linieDB = dsLivratori.Tables[PRIMUL_TABEL].Rows[PRIMA_LINIE];
                result = new Employee(linieDB);
            }
            return result;
        }

        public bool AddLivrator(Employee livrator)
        {
            return SqlDBHelper.ExecuteNonQuery(
                "INSERT INTO EMPLOYEES_DG VALUES (EMPLOYEE_ID_SEQ.nextval, :FirstName, :LastName, :HireDate, :BirthDate, :Email, :CompanyId, :NumberOfDeliveries, :VehicleId)", CommandType.Text,
                new OracleParameter(":FirstName", OracleDbType.NVarchar2, livrator.FirstName, ParameterDirection.Input),
                new OracleParameter(":LastName", OracleDbType.NVarchar2, livrator.LastName, ParameterDirection.Input),
                new OracleParameter(":HireDate", OracleDbType.Date, livrator.HireDate, ParameterDirection.Input),
                new OracleParameter(":BirthDate", OracleDbType.Date, livrator.BirthDate, ParameterDirection.Input),
                new OracleParameter(":Email", OracleDbType.NVarchar2, livrator.Email, ParameterDirection.Input),
                new OracleParameter(":CompanyId", OracleDbType.Int32, livrator.CompanyId, ParameterDirection.Input),
                new OracleParameter(":NumberOfDeliveries", OracleDbType.Int32, livrator.NumberOfDeliveries, ParameterDirection.Input),
                new OracleParameter(":VehicleId", OracleDbType.Int32, livrator.VehicleId, ParameterDirection.Input));
        }

        public bool UpdateLivrator(Employee livrator)
        {
            return SqlDBHelper.ExecuteNonQuery(
                "UPDATE EMPLOYEES_DG set NAME = :Name, LOGO_URL = :LogoUrl where ID = :IdFirma", CommandType.Text,
                new OracleParameter(":FirstName", OracleDbType.NVarchar2, livrator.FirstName, ParameterDirection.Input),
                new OracleParameter(":LastName", OracleDbType.NVarchar2, livrator.LastName, ParameterDirection.Input),
                new OracleParameter(":HireDate", OracleDbType.Date, livrator.HireDate, ParameterDirection.Input),
                new OracleParameter(":BirthDate", OracleDbType.Date, livrator.BirthDate, ParameterDirection.Input),
                new OracleParameter(":Email", OracleDbType.NVarchar2, livrator.Email, ParameterDirection.Input),
                new OracleParameter(":CompanyId", OracleDbType.Int32, livrator.CompanyId, ParameterDirection.Input),
                new OracleParameter(":NumberOfDeliveries", OracleDbType.Int32, livrator.NumberOfDeliveries, ParameterDirection.Input),
                new OracleParameter(":VehicleId", OracleDbType.Int32, livrator.VehicleId, ParameterDirection.Input),
                new OracleParameter(":IdFirma", OracleDbType.NVarchar2, livrator.Id, ParameterDirection.Input));
        }
    }
}
