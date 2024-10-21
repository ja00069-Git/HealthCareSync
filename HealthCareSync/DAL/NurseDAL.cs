using HealthCareSync.Enums;
using HealthCareSync.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareSync.DAL
{
    internal class NurseDAL
    {
        private AddressDAL addressDAL;

        private readonly string connectionString = "server=cs-dblab01.uwg.westga.edu;uid=cs3230f24c;" +
             "pwd=ZIEbXBxGYTIGdXa>RbSJ;database=cs3230f24c;";

        /// <summary>
        /// Initializes a new instance of the <see cref="PatientDAL"/> class.
        /// </summary>
        public NurseDAL() { this.addressDAL = new AddressDAL(); }

        /// <summary>
        /// Adds the nurse.
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
        /// <param name="username">The username.</param>
        /// <returns></returns>
        public int AddNurse(string fname, string lname, DateTime bdate, string? address_1,
            string? zip, string? city, string? state, string? address_2, string? phone_num, string? username)
        {
            using var connection = new MySqlConnection(connectionString);

            connection.Open();

            var query = string.Empty;
            int address_id = 0;

            if (string.IsNullOrWhiteSpace(address_1))
            {
                query = @"insert into nurse (fname, lname, birth_date, phone_num, username)
                          values (@fname, @lname, @bdate, @phone_num, @username)";
            }
            else
            {
                address_id = this.addressDAL.UpdateAddressIfExistsElseCreate(address_1!, zip!, city, state, address_2);

                query = @"insert into nurse (fname, lname, birth_date, phone_num, address, username)
                          values (@fname, @lname, @bdate, @phone_num, @address, @username)";
            }

            using var command = new MySqlCommand(query, connection);
            command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@address_id", MySqlDbType.Int32).Value = address_id;
            command.Parameters.Add("@bdate", MySqlDbType.Date).Value = bdate;
            command.Parameters.Add("@phone_num", MySqlDbType.VarChar).Value = phone_num;
            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;

            command.ExecuteNonQuery();

            // retrieve nurse id
            var retrieveQuery = @"select LAST_INSERT_ID()";

            using var retrieveIdCommand = new MySqlCommand(retrieveQuery, connection);
            using var retrieveIdReader = retrieveIdCommand.ExecuteReader();
            int idOrdinal = retrieveIdReader.GetOrdinal("LAST_INSERT_ID()");

            int id = 0;

            while (retrieveIdReader.Read())
            {
                ulong tempId = retrieveIdReader.GetFieldValueCheckNull<UInt64>(idOrdinal);

                if (tempId <= Int32.MaxValue)
                {
                    id = (int)tempId;
                }
            }

            connection.Close();
            return id;
        }

        /// <summary>
        /// Deletes the nurse.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public void DeleteNurse(int id)
        {
            using var connection = new MySqlConnection(connectionString);

            connection.Open();

            var query = @"delete from nurse where id = @id";

            using var command = new MySqlCommand(query, connection);
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

            command.ExecuteNonQuery();
            connection.Close();
        }

        /// <summary>
        /// Saves the edited nurse.
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
        /// <param name="username">The username.</param>
        public void SaveEditedPatient(int id, string fname, string lname, DateTime bdate, string? address_1,
            string? zip, string? city, string? state, string? address_2, string? phone_num, string? username)
        {
            using var connection = new MySqlConnection(connectionString);

            connection.Open();

            var query = string.Empty;
            int address_id = 0;

            if (string.IsNullOrWhiteSpace(address_1))
            {
                query = @"update nurse 
                        set fname = @fname, lname = @lname, address_id = null,
                        birth_date = @bdate, phone_num = @phone_num, username = @username
                        where id = @id";
            }
            else
            {
                address_id = this.addressDAL.UpdateAddressIfExistsElseCreate(address_1!, zip!, city, state, address_2);

                query = @"update nurse 
                        set fname = @fname, lname = @lname, address_id = @address_id,
                        birth_date = @bdate, phone_num = @phone_num, username = @username
                        where id = @id";
            }

            using var command = new MySqlCommand(query, connection);
            command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@address_id", MySqlDbType.Int32).Value = address_id;
            command.Parameters.Add("@bdate", MySqlDbType.Date).Value = bdate;
            command.Parameters.Add("@phone_num", MySqlDbType.VarChar).Value = phone_num;
            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

            command.ExecuteNonQuery();
            connection.Close();
        }

        /// <summary>
        /// Gets the patients.
        /// </summary>
        /// <returns></returns>
        public List<Nurse> GetNurses()
        {
            var nurseList = new List<Nurse>();
            using var connection = new MySqlConnection(connectionString);

            connection.Open();

            var query = @"select 
                            N.id as NurseId, 
                            A.id as AddressId, 
                            fname, 
                            lname, 
                            birth_date, 
                            phone_num, 
                            username, 
                            address_1, 
                            zip, 
                            state, 
                            city, 
                            address_2
                          from nurse N
                          left join address A on N.address_id = A.id
                          where N.address_id = A.id OR N.address_id IS NULL";

            using var command = new MySqlCommand(query, connection);
            using var reader = command.ExecuteReader();

            var idOrdinal = reader.GetOrdinal("NurseId");
            var addressIdOrdinal = reader.GetOrdinal("AddressId");
            var fnameOrdinal = reader.GetOrdinal("fname");
            var lnameOrdinal = reader.GetOrdinal("lname");
            var bdateOrdinal = reader.GetOrdinal("birth_date");
            var phoneOrdinal = reader.GetOrdinal("phone_num");
            var usernameOrdinal = reader.GetOrdinal("username");
            var address1Ordinal = reader.GetOrdinal("address_1");
            var zipOrdinal = reader.GetOrdinal("zip");
            var stateOrdinal = reader.GetOrdinal("state");
            var cityOrdinal = reader.GetOrdinal("city");
            var address2Ordinal = reader.GetOrdinal("address_2");

            while (reader.Read())
            {
                nurseList.Add(CreateNurse(reader, idOrdinal, addressIdOrdinal, fnameOrdinal, lnameOrdinal, bdateOrdinal,
                    phoneOrdinal, usernameOrdinal, address1Ordinal, zipOrdinal, stateOrdinal, cityOrdinal, address2Ordinal));
            }

            connection.Close();
            return nurseList;

        }

        private static Nurse CreateNurse(MySqlDataReader reader, int idOrdinal, int addressIdOrdinal, int fnameOrdinal, int lnameOrdinal, int bdateOrdinal,
            int phoneOrdinal, int usernameOrdinal, int address1Ordinal, int zipOrdinal, int stateOrdinal,
            int cityOrdinal, int address2Ordinal)
        {
             
            var nurse = new Nurse(
                reader.GetFieldValueCheckNull<int>(idOrdinal),
                reader.GetFieldValueCheckNull<string>(fnameOrdinal),
                reader.GetFieldValueCheckNull<string>(lnameOrdinal),
                reader.GetFieldValueCheckNull<DateTime>(bdateOrdinal),
                reader.GetFieldValueCheckNull<string?>(phoneOrdinal),
                null,
                reader.GetFieldValueCheckNull<string?>(usernameOrdinal)
            );

            var address1 = reader.GetFieldValueCheckNull<string?>(address1Ordinal);
            var zip = reader.GetFieldValueCheckNull<string?>(zipOrdinal);

            if (address1 != null && zip != null) // Address isn't null
            {
                var address = new Address(
                    reader.GetFieldValueCheckNull<Int32>(addressIdOrdinal),
                    address1,
                    zip,
                    reader.GetFieldValueCheckNull<string?>(cityOrdinal),
                    reader.GetFieldValueCheckNull<string?>(stateOrdinal),
                    reader.GetFieldValueCheckNull<string?>(address2Ordinal)
                );

                nurse.Address = address;
            }

            return nurse;
        }
    }
}

