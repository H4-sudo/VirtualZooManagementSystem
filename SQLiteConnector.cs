using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Threading.Tasks;

namespace VirtualZooManagementFA3
{
    internal class SQLiteConnector
    {
        public static async Task<List<Animal>> LoadAnimalsAsync()
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    var output = await cnn.QueryAsync<dynamic>("SELECT * FROM Animals");
                    List<Animal> animals = new List<Animal>();

                    foreach (var data in output)
                    {
                        string type = data.Type;
                        switch (type)
                        {
                            case "Lion":
                                animals.Add(new Lion((string)data.Name, (int)data.Age, (string)type));
                                break;
                            case "Elephant":
                                animals.Add(new Elephant((string)data.Name, (int)data.Age, (string)type));
                                break;
                            case "Parrot":
                                animals.Add(new Parrot((string)data.Name, (int)data.Age, (string)type));
                                break;
                            case "Turtle":
                                animals.Add(new Turtle((string)data.Name, (int)data.Age, (string)type));
                                break;
                            case "Monkey":
                                animals.Add(new Monkey((string)data.Name, (int)data.Age, (string)type));
                                break;
                            case "PolarBear":
                                animals.Add(new PolarBear((string)data.Name, (int)data.Age, (string)type));
                                break;
                            case "Giraffe":
                                animals.Add(new Giraffe((string)data.Name, (int)data.Age, (string)type));
                                break;
                            case "Kangaroo":
                                animals.Add(new Kangaroo((string)data.Name, (int)data.Age, (string)type));
                                break;
                            default:
                                throw new ArgumentException($"Unknown animal type: {type}");
                        }
                    }

                    return animals;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return new List<Animal>();
            }
        }

        public static async Task SaveAnimalAsync(Animal animal)
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    await cnn.ExecuteAsync("INSERT INTO Animals (Name, Age, Type) VALUES (@Name, @Age, @Type)", new
                    {
                        animal.Name,
                        animal.Age,
                        animal.Type
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while saving the animal: {ex.Message}");
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            var connectionString = ConfigurationManager.ConnectionStrings[id]?.ConnectionString;
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new ConfigurationErrorsException($"Connection string '{id}' is not found in the configuration.");
            }
            return connectionString;
        }
    }
}
