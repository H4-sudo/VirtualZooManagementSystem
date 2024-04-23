using System;
using System.Windows.Forms;

namespace VirtualZooManagementSystem
{
    public partial class VirtualZooMangementSystem : Form
    {
        public VirtualZooMangementSystem()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            addNewAnimal2.Visible = false;
            seeAllAnimals2.Visible = false;
            feedAnimals2.Visible = false;
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void animalAddMenu_Click(object sender, EventArgs e)
        {
            addNewAnimal2.Visible = true;
            feedAnimals2.Visible = false;
            seeAllAnimals2.Visible = false;
            
        }

        private void viewAllAnimalsButton_Click(object sender, EventArgs e)
        {
            addNewAnimal2.Visible = false;
            feedAnimals2.Visible = false;
            seeAllAnimals2.Visible = true;
        }

        private void animalFeedMenu_Click(object sender, EventArgs e)
        {
            addNewAnimal2.Visible = false;
            feedAnimals2.Visible = true;
            seeAllAnimals2.Visible = false;
        }

        private void addNewAnimal2_Load(object sender, EventArgs e)
        {

        }

        private void seeAllAnimals2_Load(object sender, EventArgs e)
        {

        }

        private void feedAnimals2_Load(object sender, EventArgs e)
        {

        }

        private void feedAnimals2_Load_1(object sender, EventArgs e)
        {

        }

        private void seeAllAnimals2_Load_1(object sender, EventArgs e)
        {

        }
    }
}
