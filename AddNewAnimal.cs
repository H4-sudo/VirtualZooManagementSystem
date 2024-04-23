using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VirtualZooManagementSystem
{
    public partial class AddNewAnimal : UserControl
    {
        string animalName;
        int animalAge;
        string animalType;

        private string connectionString = "Data Source=H4Z3Y_\\JEFFY;Initial Catalog=animals;Integrated Security=True;";
        public AddNewAnimal()
        {
            InitializeComponent();
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addAnimalInfoButton_Click(object sender, EventArgs e)
        {
            string animalName = animalNameInput.Text;
            int animalAge = (int)animalAgeInput.Value;
            string animalType = GetSelectedAnimalType();

            if (string.IsNullOrEmpty(animalName) || string.IsNullOrEmpty(animalType))
            {
                MessageBox.Show("Please enter animal name and select animal type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO Animals (Name, Age, AnimalType) VALUES (@Name, @Age, @AnimalType)";
                    SqlCommand command = new SqlCommand(query, connection);
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


        private void elephantSelection_CheckedChanged(object sender, EventArgs e)
        {
            animalType = elephantSelection.Text;
        }

        private void lionSelection_CheckedChanged(object sender, EventArgs e)
        {
            animalType = lionSelection.Text;

        }

        private void animalNameInput_TextChanged(object sender, EventArgs e)
        {
            animalName = animalNameInput.Text;
            
        }

        private void animalAgeInput_ValueChanged(object sender, EventArgs e)
        {
            animalAge = (int)animalAgeInput.Value;

        }

        private void parrotSelection_CheckedChanged(object sender, EventArgs e)
        {
            animalType = parrotSelection.Text;

        }

        private void turtleSelection_CheckedChanged(object sender, EventArgs e)
        {
            animalType = turtleSelection.Text;

        }
    }
}
