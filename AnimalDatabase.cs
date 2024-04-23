using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using VirtualZooManagementSystem;

class AnimalDatabase
{
    // Connection string for your database
    private static string connectionString = "Data Source=H4Z3Y_\\JEFFY;Initial Catalog=animals;Integrated Security=True;";

    internal static List<string> GetAllAnimalNames()
    {
        List<string> animalNames = new List<string>();

        string query = "SELECT Name FROM Animals";
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string name = reader["Name"].ToString();
                    animalNames.Add(name);
                }
                reader.Close();
            }
        }
        return animalNames;
    }

    internal static List<string> GetAllAnimalTypes()
    {
        List<string> animalTypes = new List<string>();

        string query = "SELECT AnimalType FROM Animals";
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string type = reader["AnimalType"].ToString();
                    animalTypes.Add(type);
                }
                reader.Close();
            }
        }
        return animalTypes;
    }

    internal static Animal GetAnimal(string selectedAnimalName, string selectedAnimalType)
    {
        Animal selectedAnimal = null;
        string query = "SELECT * FROM Animals WHERE Name = @Name AND AnimalType = @AnimalType";
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Name", selectedAnimalName);
                command.Parameters.AddWithValue("@AnimalType", selectedAnimalType);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // Determine the type of animal based on the retrieved data
                    string animalType = reader["AnimalType"].ToString();

                    // Create a new instance of the appropriate subclass of Animal
                    switch (animalType)
                    {
                        case "Lion":
                            selectedAnimal = new Lion();
                            break;
                        case "Elephant":
                            selectedAnimal = new Elephant();
                            break;
                        case "Parrot":
                            selectedAnimal = new Parrot();
                            break;
                        case "Turtle":
                            selectedAnimal = new Turtle();
                            break;
                        default:
                            // Handle unknown animal types or errors
                            break;
                    }

                    selectedAnimal.ID = Convert.ToInt32(reader["ID"]);
                    selectedAnimal.Name = reader["Name"].ToString();
                }
                reader.Close();
            }
        }
        return selectedAnimal;
    }

}
