using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthCareSync.Enums;
using HealthCareSync.Models;
using MySql.Data.MySqlClient;

namespace HealthCareSync.DAL
{
    /// <summary>
    ///  Handles all proccesses involving database management of the patient table
    /// </summary>
    public class PatientDAL
    {
        private AddressDAL addressDAL;

        /// <summary>
        /// Initializes a new instance of the <see cref="PatientDAL"/> class.
        /// </summary>
        public PatientDAL() { this.addressDAL = new AddressDAL(); }

        /// <summary>
        /// Gets the patients with the given name and birth date.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="bDate">The b date.</param>
        /// <returns>the list of patients with the given name and birth date</returns>
        public List<Patient> GetPatientsWithNameAndBirthDate(string firstName, string lastName, DateTime bDate)
        {
            var patientList = new List<Patient>();
            using var connection = new MySqlConnection(Connection.ConnectionString());

            connection.Open();

            var query = string.Empty;

            using MySqlCommand command = new MySqlCommand();
            command.Connection = connection;

            if (string.IsNullOrWhiteSpace(firstName) && string.IsNullOrWhiteSpace(lastName))
            {
                query = @"select 
                            P.id as PatientId, 
                            A.id as AddressId, 
                            fname, 
                            lname, 
                            birth_date, 
                            gender,
                            phone_num, 
                            flag_status, 
                            address_1, 
                            zip, 
                            state, 
                            city, 
                            address_2
                          from patient P
                          left join address A on P.address_id = A.id
                          where (P.address_id = A.id OR P.address_id IS NULL)
                          AND P.birth_date = @bdate";

                command.CommandText = query;
                command.Parameters.Add("@bdate", MySqlDbType.Date).Value = bDate;
            }
            else if (string.IsNullOrWhiteSpace(lastName))
            {
                query = @"select 
                            P.id as PatientId, 
                            A.id as AddressId, 
                            fname, 
                            lname, 
                            birth_date, 
                            gender,
                            phone_num, 
                            flag_status, 
                            address_1, 
                            zip, 
                            state, 
                            city, 
                            address_2
                          from patient P
                          left join address A on P.address_id = A.id
                          where (P.address_id = A.id OR P.address_id IS NULL)
                          AND P.birth_date = @bdate AND P.fname = @fname";

                command.CommandText = query;
                command.Parameters.Add("@bdate", MySqlDbType.Date).Value = bDate;
                command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = firstName;
            }
            else if (string.IsNullOrWhiteSpace(firstName))
            {
                query = @"select 
                            P.id as PatientId, 
                            A.id as AddressId, 
                            fname, 
                            lname, 
                            birth_date, 
                            gender,
                            phone_num, 
                            flag_status, 
                            address_1, 
                            zip, 
                            state, 
                            city, 
                            address_2
                          from patient P
                          left join address A on P.address_id = A.id
                          where (P.address_id = A.id OR P.address_id IS NULL)
                          AND P.birth_date = @bdate AND P.lname = @lname";

                command.CommandText = query;
                command.Parameters.Add("@bdate", MySqlDbType.Date).Value = bDate;
                command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = lastName;
            }
            else
            {
                query = @"select 
                            P.id as PatientId, 
                            A.id as AddressId, 
                            fname, 
                            lname, 
                            birth_date, 
                            gender,
                            phone_num, 
                            flag_status, 
                            address_1, 
                            zip, 
                            state, 
                            city, 
                            address_2
                          from patient P
                          left join address A on P.address_id = A.id
                          where (P.address_id = A.id OR P.address_id IS NULL)
                          AND P.birth_date = @bdate AND P.lname = @lname AND P.fname = @fname";

                command.CommandText = query;
                command.Parameters.Add("@bdate", MySqlDbType.Date).Value = bDate;
                command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = lastName;
                command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = firstName;
            }

            using var reader = command.ExecuteReader();

            var idOrdinal = reader.GetOrdinal("PatientId");
            var addressIdOrdinal = reader.GetOrdinal("AddressId");
            var fnameOrdinal = reader.GetOrdinal("fname");
            var lnameOrdinal = reader.GetOrdinal("lname");
            var bdateOrdinal = reader.GetOrdinal("birth_date");
            var genderOrdinal = reader.GetOrdinal("gender");
            var phoneOrdinal = reader.GetOrdinal("phone_num");
            var flagOrdinal = reader.GetOrdinal("flag_status");
            var address1Ordinal = reader.GetOrdinal("address_1");
            var zipOrdinal = reader.GetOrdinal("zip");
            var stateOrdinal = reader.GetOrdinal("state");
            var cityOrdinal = reader.GetOrdinal("city");
            var address2Ordinal = reader.GetOrdinal("address_2");

            while (reader.Read())
            {
                patientList.Add(CreatePatient(reader, idOrdinal, addressIdOrdinal, fnameOrdinal, lnameOrdinal, bdateOrdinal,
                    genderOrdinal, phoneOrdinal, flagOrdinal, address1Ordinal, zipOrdinal, stateOrdinal, cityOrdinal, address2Ordinal));
            }

            return patientList;
        }

        /// <summary>
        /// Gets the patients with the given birth date.
        /// </summary>
        /// <param name="bDate">The b date.</param>
        /// <returns>the list of patients with the given birth date</returns>
        public List<Patient> GetPatientsWithBirthDate(DateTime bDate) 
        {
            var patientList = new List<Patient>();
            using var connection = new MySqlConnection(Connection.ConnectionString());

            connection.Open();

            var query = @"select 
                            P.id as PatientId, 
                            A.id as AddressId, 
                            fname, 
                            lname, 
                            birth_date, 
                            gender,
                            phone_num, 
                            flag_status, 
                            address_1, 
                            zip, 
                            state, 
                            city, 
                            address_2
                          from patient P
                          left join address A on P.address_id = A.id
                          where (P.address_id = A.id OR P.address_id IS NULL)
                          AND P.birth_date = @bdate";

            using var command = new MySqlCommand(query, connection);

            command.Parameters.Add("@bdate", MySqlDbType.Date).Value = bDate;

            using var reader = command.ExecuteReader();

            var idOrdinal = reader.GetOrdinal("PatientId");
            var addressIdOrdinal = reader.GetOrdinal("AddressId");
            var fnameOrdinal = reader.GetOrdinal("fname");
            var lnameOrdinal = reader.GetOrdinal("lname");
            var bdateOrdinal = reader.GetOrdinal("birth_date");
            var genderOrdinal = reader.GetOrdinal("gender");
            var phoneOrdinal = reader.GetOrdinal("phone_num");
            var flagOrdinal = reader.GetOrdinal("flag_status");
            var address1Ordinal = reader.GetOrdinal("address_1");
            var zipOrdinal = reader.GetOrdinal("zip");
            var stateOrdinal = reader.GetOrdinal("state");
            var cityOrdinal = reader.GetOrdinal("city");
            var address2Ordinal = reader.GetOrdinal("address_2");

            while (reader.Read())
            {
                patientList.Add(CreatePatient(reader, idOrdinal, addressIdOrdinal, fnameOrdinal, lnameOrdinal, bdateOrdinal,
                    genderOrdinal, phoneOrdinal, flagOrdinal, address1Ordinal, zipOrdinal, stateOrdinal, cityOrdinal, address2Ordinal));
            }

            return patientList;
        }

        /// <summary>
        /// Gets the patients with the given first name.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <returns>the list of patients with the given first name</returns>
        public List<Patient> GetPatientsWithFirstName(string firstName)
        {
            var patientList = new List<Patient>();
            using var connection = new MySqlConnection(Connection.ConnectionString());

            connection.Open();

            var query = @"select 
                            P.id as PatientId, 
                            A.id as AddressId, 
                            fname, 
                            lname, 
                            birth_date, 
                            gender,
                            phone_num, 
                            flag_status, 
                            address_1, 
                            zip, 
                            state, 
                            city, 
                            address_2
                          from patient P
                          left join address A on P.address_id = A.id
                          where (P.address_id = A.id OR P.address_id IS NULL)
                          AND P.fname = @fname";

            using var command = new MySqlCommand(query, connection);
            
            command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = firstName;

            using var reader = command.ExecuteReader();

            var idOrdinal = reader.GetOrdinal("PatientId");
            var addressIdOrdinal = reader.GetOrdinal("AddressId");
            var fnameOrdinal = reader.GetOrdinal("fname");
            var lnameOrdinal = reader.GetOrdinal("lname");
            var bdateOrdinal = reader.GetOrdinal("birth_date");
            var genderOrdinal = reader.GetOrdinal("gender");
            var phoneOrdinal = reader.GetOrdinal("phone_num");
            var flagOrdinal = reader.GetOrdinal("flag_status");
            var address1Ordinal = reader.GetOrdinal("address_1");
            var zipOrdinal = reader.GetOrdinal("zip");
            var stateOrdinal = reader.GetOrdinal("state");
            var cityOrdinal = reader.GetOrdinal("city");
            var address2Ordinal = reader.GetOrdinal("address_2");

            while (reader.Read())
            {
                patientList.Add(CreatePatient(reader, idOrdinal, addressIdOrdinal, fnameOrdinal, lnameOrdinal, bdateOrdinal,
                    genderOrdinal, phoneOrdinal, flagOrdinal, address1Ordinal, zipOrdinal, stateOrdinal, cityOrdinal, address2Ordinal));
            }

            return patientList;
        }

        /// <summary>
        /// Gets the patients with the given last name.
        /// </summary>
        /// <param name="lastName">The last name.</param>
        /// <returns>the list of patients with the given last name</returns>
        public List<Patient> GetPatientsWithLastName(string lastName)
        {
            var patientList = new List<Patient>();
            using var connection = new MySqlConnection(Connection.ConnectionString());

            connection.Open();

            var query = @"select 
                            P.id as PatientId, 
                            A.id as AddressId, 
                            fname, 
                            lname, 
                            birth_date, 
                            gender,
                            phone_num, 
                            flag_status, 
                            address_1, 
                            zip, 
                            state, 
                            city, 
                            address_2
                          from patient P
                          left join address A on P.address_id = A.id
                          where (P.address_id = A.id OR P.address_id IS NULL)
                          AND P.lname = @lname";

            using var command = new MySqlCommand(query, connection);

            command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = lastName;

            using var reader = command.ExecuteReader();

            var idOrdinal = reader.GetOrdinal("PatientId");
            var addressIdOrdinal = reader.GetOrdinal("AddressId");
            var fnameOrdinal = reader.GetOrdinal("fname");
            var lnameOrdinal = reader.GetOrdinal("lname");
            var bdateOrdinal = reader.GetOrdinal("birth_date");
            var genderOrdinal = reader.GetOrdinal("gender");
            var phoneOrdinal = reader.GetOrdinal("phone_num");
            var flagOrdinal = reader.GetOrdinal("flag_status");
            var address1Ordinal = reader.GetOrdinal("address_1");
            var zipOrdinal = reader.GetOrdinal("zip");
            var stateOrdinal = reader.GetOrdinal("state");
            var cityOrdinal = reader.GetOrdinal("city");
            var address2Ordinal = reader.GetOrdinal("address_2");

            while (reader.Read())
            {
                patientList.Add(CreatePatient(reader, idOrdinal, addressIdOrdinal, fnameOrdinal, lnameOrdinal, bdateOrdinal,
                    genderOrdinal, phoneOrdinal, flagOrdinal, address1Ordinal, zipOrdinal, stateOrdinal, cityOrdinal, address2Ordinal));
            }

            return patientList;
        }

        /// <summary>
        /// Gets the list of patients with the given full name.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <returns>the list of patients with the given full name</returns>
        public List<Patient> GetPatientsWithFullName(string firstName, string lastName)
        {
            var patientList = new List<Patient>();
            using var connection = new MySqlConnection(Connection.ConnectionString());

            connection.Open();

            var query = @"select 
                            P.id as PatientId, 
                            A.id as AddressId, 
                            fname, 
                            lname, 
                            birth_date, 
                            gender,
                            phone_num, 
                            flag_status, 
                            address_1, 
                            zip, 
                            state, 
                            city, 
                            address_2
                          from patient P
                          left join address A on P.address_id = A.id
                          where (P.address_id = A.id OR P.address_id IS NULL)
                          AND P.fname = @fname AND P.lname = @lname";

            using var command = new MySqlCommand(query, connection);

            command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = firstName;
            command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = lastName;

            using var reader = command.ExecuteReader();

            var idOrdinal = reader.GetOrdinal("PatientId");
            var addressIdOrdinal = reader.GetOrdinal("AddressId");
            var fnameOrdinal = reader.GetOrdinal("fname");
            var lnameOrdinal = reader.GetOrdinal("lname");
            var bdateOrdinal = reader.GetOrdinal("birth_date");
            var genderOrdinal = reader.GetOrdinal("gender");
            var phoneOrdinal = reader.GetOrdinal("phone_num");
            var flagOrdinal = reader.GetOrdinal("flag_status");
            var address1Ordinal = reader.GetOrdinal("address_1");
            var zipOrdinal = reader.GetOrdinal("zip");
            var stateOrdinal = reader.GetOrdinal("state");
            var cityOrdinal = reader.GetOrdinal("city");
            var address2Ordinal = reader.GetOrdinal("address_2");

            while (reader.Read())
            {
                patientList.Add(CreatePatient(reader, idOrdinal, addressIdOrdinal, fnameOrdinal, lnameOrdinal, bdateOrdinal,
                    genderOrdinal, phoneOrdinal, flagOrdinal, address1Ordinal, zipOrdinal, stateOrdinal, cityOrdinal, address2Ordinal));
            }

            return patientList;
        }

        /// <summary>
        /// Adds the patient.
        /// </summary>
        /// <param name="fname">The fname.</param>
        /// <param name="lname">The lname.</param>
        /// <param name="bdate">The bdate.</param>
        /// <param name="address_1">The address 1.</param>
        /// <param name="zip">The zip.</param>
        /// <param name="city">The city.</param>
        /// <param name="state">The state.</param>
        /// <param name="address_2">The address 2.</param>
        /// <param name="phone_num">The phone number.</param>
        /// <param name="flag">The flag.</param>
        /// <returns></returns>
        public int AddPatient(string fname, string lname, DateTime bdate, Gender gender, string address_1,
            string zip, string city, State state, string? address_2, string phone_num, FlagStatus flag)
        {
            using var connection = new MySqlConnection(Connection.ConnectionString());

            connection.Open();

            MySqlTransaction transaction = connection.BeginTransaction();

            var query = @"insert into patient (fname, lname, birth_date, gender, phone_num, address_id, flag_status)
                          values (@fname, @lname, @bdate, @gender, @phone_num, @address_id, @flag)";
            

            using var command = new MySqlCommand(query, connection);
            command.Transaction = transaction;

            int id = 0;

            try
            {
                int address_id = this.addressDAL.UpdateAddressIfExistsElseCreate(connection, transaction, address_1!, zip!, city, state, address_2);

                command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = fname;
                command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = lname;
                command.Parameters.Add("@address_id", MySqlDbType.Int32).Value = address_id;
                command.Parameters.Add("@bdate", MySqlDbType.Date).Value = bdate;
                command.Parameters.Add("@gender", MySqlDbType.VarChar).Value = gender.ToString();
                command.Parameters.Add("@phone_num", MySqlDbType.VarChar).Value = phone_num;
                command.Parameters.Add("@flag", MySqlDbType.VarChar).Value = flag.ToString();

                command.ExecuteNonQuery();

                // retrieve patient id
                var retrieveQuery = @"select LAST_INSERT_ID()";

                using var retrieveIdCommand = new MySqlCommand(retrieveQuery, connection);
                retrieveIdCommand.Transaction = transaction;

                id = Convert.ToInt32(retrieveIdCommand.ExecuteScalar());

                transaction.Commit();
            }
            catch (Exception ex)
            {
                try
                {
                    transaction.Rollback();
                }
                catch (Exception rollbackEx)
                {
                    Debug.WriteLine("Rollback failed: " + rollbackEx.Message);
                }
            }
            

            return id;
        }

        /// <summary>
        /// Saves the edited patient.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="fname">The fname.</param>
        /// <param name="lname">The lname.</param>
        /// <param name="bdate">The bdate.</param>
        /// <param name="address_1">The address 1.</param>
        /// <param name="zip">The zip.</param>
        /// <param name="city">The city.</param>
        /// <param name="state">The state.</param>
        /// <param name="address_2">The address 2.</param>
        /// <param name="phone_num">The phone number.</param>
        /// <param name="flag">The flag.</param>
        public void SaveEditedPatient(int id, string fname, string lname, DateTime bdate, Gender gender, string address_1,
            string zip, string city, State state, string? address_2, string phone_num, FlagStatus flag)
        {
            using var connection = new MySqlConnection(Connection.ConnectionString());

            connection.Open();

            MySqlTransaction transaction = connection.BeginTransaction();

            var query = @"update patient 
                        set fname = @fname, lname = @lname, address_id = @address_id,
                        birth_date = @bdate, gender = @gender, phone_num = @phone_num, flag_status = @flag
                        where id = @id";
            

            using var command = new MySqlCommand(query, connection);
            command.Transaction = transaction;

            try
            {
                int address_id = this.addressDAL.UpdateAddressIfExistsElseCreate(connection, transaction, address_1!, zip!, city, state, address_2);

                command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = fname;
                command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = lname;
                command.Parameters.Add("@address_id", MySqlDbType.Int32).Value = address_id;
                command.Parameters.Add("@bdate", MySqlDbType.Date).Value = bdate;
                command.Parameters.Add("@gender", MySqlDbType.VarChar).Value = gender.ToString();
                command.Parameters.Add("@phone_num", MySqlDbType.VarChar).Value = phone_num;
                command.Parameters.Add("@flag", MySqlDbType.VarChar).Value = flag.ToString();
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

                command.ExecuteNonQuery();

                this.addressDAL.DeleteUnreferencedAddresses(connection, transaction);

                transaction.Commit();
            }
            catch (Exception ex)
            {
                try
                {
                    transaction.Rollback();
                }
                catch (Exception rollbackEx)
                {
                    Debug.WriteLine("Rollback failed: " + rollbackEx.Message);
                }
            }
        }

        /// <summary>
        /// Gets the patient with identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public Patient? GetPatientWithId(int id)
        {
            Patient patient = null;

            using var connection = new MySqlConnection(Connection.ConnectionString());

            connection.Open();

            var query = @"select 
                            P.id as PatientId, 
                            A.id as AddressId, 
                            fname, 
                            lname, 
                            birth_date, 
                            gender,
                            phone_num, 
                            flag_status, 
                            address_1, 
                            zip, 
                            state, 
                            city, 
                            address_2
                          from patient P
                          left join address A on P.address_id = A.id
                          where (P.address_id = A.id OR P.address_id IS NULL)
                                AND P.id = @id";

            using var command = new MySqlCommand(query, connection);

            command.Parameters.Add("@id", MySqlDbType.Int32 ).Value = id;

            using var reader = command.ExecuteReader();

            var idOrdinal = reader.GetOrdinal("PatientId");
            var addressIdOrdinal = reader.GetOrdinal("AddressId");
            var fnameOrdinal = reader.GetOrdinal("fname");
            var lnameOrdinal = reader.GetOrdinal("lname");
            var bdateOrdinal = reader.GetOrdinal("birth_date");
            var genderOrdinal = reader.GetOrdinal("gender");
            var phoneOrdinal = reader.GetOrdinal("phone_num");
            var flagOrdinal = reader.GetOrdinal("flag_status");
            var address1Ordinal = reader.GetOrdinal("address_1");
            var zipOrdinal = reader.GetOrdinal("zip");
            var stateOrdinal = reader.GetOrdinal("state");
            var cityOrdinal = reader.GetOrdinal("city");
            var address2Ordinal = reader.GetOrdinal("address_2");

            while (reader.Read())
            {
                patient = CreatePatient(reader, idOrdinal, addressIdOrdinal, fnameOrdinal, lnameOrdinal, bdateOrdinal,
                    genderOrdinal, phoneOrdinal, flagOrdinal, address1Ordinal, zipOrdinal, stateOrdinal, cityOrdinal, address2Ordinal);
            }

            return patient;
        }

        /// <summary>
        /// Gets the patients.
        /// </summary>
        /// <returns></returns>
        public List<Patient> GetPatients()
        {
            var patientList = new List<Patient>();
            using var connection = new MySqlConnection(Connection.ConnectionString());

            connection.Open();

            var query = @"select 
                            P.id as PatientId, 
                            A.id as AddressId, 
                            fname, 
                            lname, 
                            birth_date, 
                            gender,
                            phone_num, 
                            flag_status, 
                            address_1, 
                            zip, 
                            state, 
                            city, 
                            address_2
                          from patient P
                          left join address A on P.address_id = A.id
                          where P.address_id = A.id OR P.address_id IS NULL";

            using var command = new MySqlCommand(query, connection);
            using var reader = command.ExecuteReader();

            var idOrdinal = reader.GetOrdinal("PatientId");
            var addressIdOrdinal = reader.GetOrdinal("AddressId");
            var fnameOrdinal = reader.GetOrdinal("fname");
            var lnameOrdinal = reader.GetOrdinal("lname");
            var bdateOrdinal = reader.GetOrdinal("birth_date");
            var genderOrdinal = reader.GetOrdinal("gender");
            var phoneOrdinal = reader.GetOrdinal("phone_num");
            var flagOrdinal = reader.GetOrdinal("flag_status");
            var address1Ordinal = reader.GetOrdinal("address_1");
            var zipOrdinal = reader.GetOrdinal("zip");
            var stateOrdinal = reader.GetOrdinal("state");
            var cityOrdinal = reader.GetOrdinal("city");
            var address2Ordinal = reader.GetOrdinal("address_2");

            while (reader.Read())
            {
                patientList.Add(CreatePatient(reader, idOrdinal, addressIdOrdinal, fnameOrdinal, lnameOrdinal, bdateOrdinal,
                    genderOrdinal, phoneOrdinal, flagOrdinal, address1Ordinal, zipOrdinal, stateOrdinal, cityOrdinal, address2Ordinal));
            }

            return patientList;

        }

        private static Patient CreatePatient(MySqlDataReader reader, int idOrdinal, int addressIdOrdinal, int fnameOrdinal, int lnameOrdinal, int bdateOrdinal,
            int genderOrdinal, int phoneOrdinal, int flagOrdinal, int address1Ordinal, int zipOrdinal, int stateOrdinal,
            int cityOrdinal, int address2Ordinal)
        {
            State state = Enum.Parse<State>(reader.GetFieldValueCheckNull<string>(stateOrdinal).ToUpper());

            var address = new Address(
                reader.GetFieldValueCheckNull<int>(addressIdOrdinal),
                reader.GetFieldValueCheckNull<string>(address1Ordinal),
                reader.GetFieldValueCheckNull<string>(zipOrdinal),
                reader.GetFieldValueCheckNull<string>(cityOrdinal),
                state,
                reader.GetFieldValueCheckNull<string?>(address2Ordinal)
            );

            Gender gender = Enum.Parse<Gender>(reader.GetFieldValueCheckNull<string>(genderOrdinal).ToUpper());
            FlagStatus flag = Enum.Parse<FlagStatus>(reader.GetFieldValueCheckNull<string>(flagOrdinal).ToUpper());

            var patient = new Patient(
                reader.GetFieldValueCheckNull<int>(idOrdinal),
                reader.GetFieldValueCheckNull<string>(fnameOrdinal),
                reader.GetFieldValueCheckNull<string>(lnameOrdinal),
                reader.GetFieldValueCheckNull<DateTime>(bdateOrdinal),
                gender,
                reader.GetFieldValueCheckNull<string>(phoneOrdinal),
                address,
                flag
            );

            return patient;
        }
    }
}
