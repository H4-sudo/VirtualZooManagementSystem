using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualZooManagementSystem
{
    public partial class FeedAnimals : UserControl
    {
        private Animal selectedAnimal;

        public FeedAnimals()
        {
            InitializeComponent();
            

            List<string> animalTypes = AnimalDatabase.GetAllAnimalTypes();
            List<string> animalNames = AnimalDatabase.GetAllAnimalNames();
            
            foreach (string type in animalTypes)
            {
                AnimalTypeComboBox.Items.Add(type);
            }
            
            foreach (string name in  animalNames)
            {
                AnimalNameComboBox.Items.Add(name);
            }
        }

        private void feedAnimalButton_Click(object sender, EventArgs e)
        {
            selectedAnimal = GetSelectedAnimal();
            if (selectedAnimal != null)
            {
                selectedAnimal.Eat();
                selectedAnimal.Energy();
                MessageBox.Show($"{selectedAnimal.Name} has been fed.\nEnergy: {selectedAnimal.EnergyLevel} | Hunger: {selectedAnimal.HungerLevel}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void giveAnimalWaterButton_Click(object sender, EventArgs e)
        {
            selectedAnimal = GetSelectedAnimal();
            if (selectedAnimal != null)
            {
                selectedAnimal.Thirst();
                selectedAnimal.Energy();
                MessageBox.Show($"{selectedAnimal.Name} has been given water.\nEnergy: {selectedAnimal.EnergyLevel} | Thirst: {selectedAnimal.ThirstLevel}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void AnimalNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void AnimalTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void restAnimalButton_Click(object sender, EventArgs e)
        {
            selectedAnimal = GetSelectedAnimal();
            if (selectedAnimal != null)
            {
                selectedAnimal.Sleep();
                MessageBox.Show($"{selectedAnimal.Name} is resting.\nEnergy: {selectedAnimal.EnergyLevel}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private Animal GetSelectedAnimal()
        {
            if (AnimalNameComboBox.SelectedItem == null || AnimalTypeComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select an animal name and type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            } else
            {
                string selectedAnimalName = AnimalNameComboBox.SelectedItem.ToString();
                string selectedAnimalType = AnimalTypeComboBox.SelectedItem.ToString();

                return AnimalDatabase.GetAnimal(selectedAnimalName, selectedAnimalType);
            }
        }

        private void InteractWithAnimalButton_Click(object sender, EventArgs e)
        {
            selectedAnimal = GetSelectedAnimal();
            if (selectedAnimal != null)
            {
                selectedAnimal.Move();
                selectedAnimal.Hunger();
                selectedAnimal.IsThirsty();
                MessageBox.Show($"{selectedAnimal.Name} had some fun with you.\nEnergy: {selectedAnimal.EnergyLevel} | Hunger: {selectedAnimal.HungerLevel} | Thirst: {selectedAnimal.ThirstLevel}"
                    , "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                selectedAnimal.Stop();
            }
        }

        private void playAnimalSoundBox_CheckedChanged(object sender, EventArgs e)
        {
            selectedAnimal = GetSelectedAnimal();
            if (selectedAnimal != null)
            {
                selectedAnimal.MakeSound();
                MessageBox.Show($"{selectedAnimal.Name} made a sound.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                selectedAnimal.StopSound();
            }
        }

    }
}
