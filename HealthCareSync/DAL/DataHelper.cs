﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace HealthCareSync.DAL
{
    /// <summary>
    ///     Helper class define an Extension method that checks if a column is null before it returns it value.
    /// </summary>
    public static class DataHelper
    {

        /// <summary>
        /// Extension method that checks if a column is null before return its value.
        /// 
        /// </summary>
        /// <typeparam name="T"> column type</typeparam>
        /// <param name="reader">DataReader object</param>
        /// <param name="columnOrdinal">column ordinal</param>
        /// <returns></returns>
        public static T GetFieldValueCheckNull<T>(this MySqlDataReader reader, int columnOrdinal)
        {
            T returnValue = default;

            if (!reader[columnOrdinal].Equals(DBNull.Value))
            {
                returnValue = (T)reader[columnOrdinal];
            }
            return returnValue;
        }

    }
}
