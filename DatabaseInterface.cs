using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.Sqlite;
using System.Collections;
using Dapper;

namespace StudentExercises
{
    public class DatabaseInterface
    {
        public static SqliteConnection Connection
        {
            get
            {
                string connectionString = $"Data Source=./StudentExercises.db";
                return new SqliteConnection(connectionString);
            }
        }
    }
}