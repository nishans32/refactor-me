﻿using System.Data.SqlClient;
using Microsoft.Data.Sqlite;

namespace Carsales_test.Models
{
    public class Helpers
    {
        private const string ConnectionString = "Data Source=App_Data/products.db";

        public static SqliteConnection NewConnection()
        {
            return new SqliteConnection(ConnectionString);
        }
    }
}