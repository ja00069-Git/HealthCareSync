using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthCareSync.Enums;
using HealthCareSync.Models;
using MySql.Data.MySqlClient;

namespace HealthCareSync.DAL
{
    public class PatientDAL
    {
        private readonly string connectionString = "server=cs-dblab01.uwg.westga.edu;uid=cs3230f24c;" +
             "pwd=ZIEbXBxGYTIGdXa>RbSJ;database=cs3230f24c;";

        public void SaveEditedPatient(int id, string fname, string lname, DateTime bdate, string? address_1,
            string? zip, string? city, string? state, string? address_2, string? phone_num, FlagStatus? flag)
        {
            using var connection = new MySqlConnection(connectionString);

            connection.Open();

            var query = string.Empty;
            int address_id = 0;

            if (string.IsNullOrWhiteSpace(address_1))
            {
                query = @"update patient 
                        set fname = @fname, lname = @lname, address_id = null,
                        birth_date = @bdate, phone_num = @phone_num, flag_status = @flag
                        where id = @id";
            }
            else
            {
                address_id = this.updateAddressIfExistsElseCreate(address_1!, zip!, city, state, address_2);

                query = @"update patient 
                        set fname = @fname, lname = @lname, address_id = @address_id,
                        birth_date = @bdate, phone_num = @phone_num, flag_status = @flag
                        where id = @id";
            }
            
            using var command  = new MySqlCommand(query, connection);
            command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@address_id", MySqlDbType.Int32).Value = address_id;
            command.Parameters.Add("@bdate", MySqlDbType.Date).Value = bdate;
            command.Parameters.Add("@phone_num", MySqlDbType.VarChar).Value = phone_num;
            command.Parameters.Add("@flag", MySqlDbType.VarChar).Value = flag.ToString();
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

            command.ExecuteNonQuery();
            connection.Close();
        }

        private int updateAddressIfExistsElseCreate(string address_1, string zip, string? city, string? state, string? address_2)
        {
            using var connection = new MySqlConnection(connectionString);

            connection.Open();

            var query = @"select count(1) from address where address_1 = @address_1 AND zip = @zip";
            
            using var command = new MySqlCommand(query, connection);
            command.Parameters.Add("@address_1", MySqlDbType.VarChar).Value = address_1;
            command.Parameters.Add("@zip", MySqlDbType.VarChar).Value = zip;

            int count = Convert.ToInt32(command.ExecuteScalar());

            if (count == 1) // An address exists
            {
                var updateAddressQuery = @"update address
                                           set address_2 = @address_2, state = @state, city = @city
                                           where address_1 = @address_1 and zip = @zip";

                using var updateAddressCommand = new MySqlCommand(updateAddressQuery, connection);
                updateAddressCommand.Parameters.Add("@address_2", MySqlDbType.VarChar).Value = address_2;
                updateAddressCommand.Parameters.Add("@state", MySqlDbType.VarString).Value = state;
                updateAddressCommand.Parameters.Add("@city", MySqlDbType.VarChar).Value = city;
                updateAddressCommand.Parameters.Add("@address_1", MySqlDbType.VarChar).Value = address_1;
                updateAddressCommand.Parameters.Add("@zip", MySqlDbType.VarChar).Value = zip;

                updateAddressCommand.ExecuteNonQuery();
            }
            else // An address doesn't exists
            {
                var createAddressQuery = @"insert into address (address_1, address_2, zip, state, city)
                                           values (@address_1, @address_2, @zip, @state, @city)";

                using var createAddressCommand = new MySqlCommand(createAddressQuery, connection);
                createAddressCommand.Parameters.Add("@address_1", MySqlDbType.VarChar).Value = address_1;
                createAddressCommand.Parameters.Add("@address_2", MySqlDbType.VarChar).Value = address_2;
                createAddressCommand.Parameters.Add("@zip", MySqlDbType.VarChar).Value = zip;
                createAddressCommand.Parameters.Add("@state", MySqlDbType.VarChar).Value = state;
                createAddressCommand.Parameters.Add("@city", MySqlDbType.VarChar).Value= city;

                createAddressCommand.ExecuteNonQuery();
            }

            // Return address id

            var retrieveIdQuery = @"select id from address where address_1 = @address_1 AND zip = @zip";

            using var retrieveIdCommand = new MySqlCommand(retrieveIdQuery, connection);
            retrieveIdCommand.Parameters.Add("@address_1", MySqlDbType.VarChar).Value = address_1;
            retrieveIdCommand.Parameters.Add("@zip", MySqlDbType.VarChar).Value = zip;

            using var retrieveIdReader = retrieveIdCommand.ExecuteReader();
            var idOrdinal = retrieveIdReader.GetOrdinal("id");

            int id = 0;

            while (retrieveIdReader.Read())
            {
                id = retrieveIdReader.GetFieldValueCheckNull<int>(idOrdinal);
            }

            connection.Close();
            return id;
        }

        public List<Patient> GetPatients()
        {
            var patientList = new List<Patient>();
            using var connection = new MySqlConnection(connectionString);

            connection.Open();

            var query = @"select 
                            P.id as PatientId, 
                            A.id as AddressId, 
                            fname, 
                            lname, 
                            birth_date, 
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
                    phoneOrdinal, flagOrdinal, address1Ordinal, zipOrdinal, stateOrdinal, cityOrdinal, address2Ordinal));
            }

            connection.Close();
            return patientList;

        }

        private static Patient CreatePatient(MySqlDataReader reader, int idOrdinal, int addressIdOrdinal, int fnameOrdinal, int lnameOrdinal, int bdateOrdinal,
            int phoneOrdinal, int flagOrdinal, int address1Ordinal, int zipOrdinal, int stateOrdinal,
            int cityOrdinal, int address2Ordinal)
        {
            FlagStatus? flag = null;

            if (reader.GetFieldValueCheckNull<string?>(flagOrdinal) != null)
            {
                flag = (FlagStatus?)Enum.Parse(typeof(FlagStatus), reader.GetFieldValueCheckNull<string?>(flagOrdinal)!);
            }

            var patient = new Patient(
                reader.GetFieldValueCheckNull<int>(idOrdinal),
                reader.GetFieldValueCheckNull<string>(fnameOrdinal),
                reader.GetFieldValueCheckNull<string>(lnameOrdinal),
                reader.GetFieldValueCheckNull<DateTime>(bdateOrdinal),
                reader.GetFieldValueCheckNull<string?>(phoneOrdinal),
                null,
                flag
            );

            var address1 = reader.GetFieldValueCheckNull<string?>(address1Ordinal);
            var zip = reader.GetFieldValueCheckNull<string?>(zipOrdinal);

            if (address1 != null && zip != null) // Address isn't null
            {
                var address = new Address(
                    reader.GetFieldValueCheckNull<int>(addressIdOrdinal),
                    address1,
                    zip,
                    reader.GetFieldValueCheckNull<string?>(cityOrdinal),
                    reader.GetFieldValueCheckNull<string?>(stateOrdinal),
                    reader.GetFieldValueCheckNull<string?>(address2Ordinal)
                );

                patient.Address = address;
            }

            return patient;
        }


    }
}
