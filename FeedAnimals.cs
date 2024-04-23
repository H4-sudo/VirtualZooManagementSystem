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
        public FeedAnimals()
        {
            InitializeComponent();
        }

        private void feedAnimalButton_Click(object sender, EventArgs e)
        {
                        
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void AnimalNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string animalName = AnimalNameComboBox.SelectedItem.ToString();
        }

        private void AnimalTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string animalType = AnimalTypeComboBox.SelectedItem.ToString();
        }
    }
}
