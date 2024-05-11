using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualZooManagementSystem
{
    internal class SQLiteHelper
    {
        public static void CreateDatabase(string databaseFile)
        {
            if (!File.Exists(databaseFile))
            {
                SQLiteConnection.CreateFile(databaseFile);
            }
        }

        public static void AddAnimal(string databaseFile, Animal animal)
        {
            string connectionString = $"Data Source={databaseFile}";

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string insertQuery = "INSERT INTO Animals (Name, Age, Type) VALUES (@Name, @Age, @Type)";

                using (var command = new SQLiteCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@Name", animal.Name);
                    command.Parameters.AddWithValue("@Age", animal.Age);
                    command.Parameters.AddWithValue("@Type", animal.Type);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
