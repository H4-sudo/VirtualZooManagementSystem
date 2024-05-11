using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace VirtualZooManagementSystem
{
    public partial class AddNewAnimal : UserControl
    {
        string animalName;
        int animalAge;
        string animalType;

        private string connectionString = "Data Source=virtualzoo.db;Version=3;";

        public AddNewAnimal()
        {
            InitializeComponent();
        }

        private void addAnimalInfoButton_Click(object sender, EventArgs e)
        {
            animalName = animalNameInput.Text;
            animalAge = (int)animalAgeInput.Value;
            animalType = GetSelectedAnimalType();

            if (string.IsNullOrEmpty(animalName) || string.IsNullOrEmpty(animalType))
            {
                MessageBox.Show("Please enter animal name and select animal type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string checkQuery = "SELECT COUNT(*) FROM Animals WHERE Name = @Name AND AnimalType = @AnimalType";
                    using (SQLiteCommand checkCommand = new SQLiteCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@Name", animalName);
                        checkCommand.Parameters.AddWithValue("@AnimalType", animalType);

                        int existingAnimalsCount = Convert.ToInt32(checkCommand.ExecuteScalar());
                        if (existingAnimalsCount > 0)
                        {
                            MessageBox.Show("An animal with the same name and type already exists in the database. Please enter a different name or type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    string query = "INSERT INTO Animals (Name, Age, AnimalType) VALUES (@Name, @Age, @AnimalType)";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", animalName);
                        command.Parameters.AddWithValue("@Age", animalAge);
                        command.Parameters.AddWithValue("@AnimalType", animalType);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Animal added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to add animal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetSelectedAnimalType()
        {
            if (elephantSelection.Checked) return elephantSelection.Text;
            if (lionSelection.Checked) return lionSelection.Text;
            if (parrotSelection.Checked) return parrotSelection.Text;
            if (turtleSelection.Checked) return turtleSelection.Text;
            return string.Empty;
        }
    }
}
