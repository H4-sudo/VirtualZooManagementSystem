using System;
using System.Windows.Forms;

namespace VirtualZooManagementSystem
{
    public partial class VirtualZooMangementSystem : Form
    {
        private ZooContext context;
        public VirtualZooMangementSystem()
        {
            InitializeComponent();
            context = new ZooContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            addNewAnimal1.Visible = false;
            seeAllAnimals1.Visible = false;
            feedAnimals1.Visible = false;
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void animalAddMenu_Click(object sender, EventArgs e)
        {
            addNewAnimal1.Visible = true;
            feedAnimals1.Visible = false;
            seeAllAnimals1.Visible = false;
            
        }

        private void seeAllAnimals1_Load(object sender, EventArgs e)
        {
            
        }

        private void viewAllAnimalsButton_Click(object sender, EventArgs e)
        {
            addNewAnimal1.Visible = false;
            feedAnimals1.Visible = false;
            seeAllAnimals1.Visible = true;
        }

        private void animalFeedMenu_Click(object sender, EventArgs e)
        {
            addNewAnimal1.Visible = false;
            feedAnimals1.Visible = true;
            seeAllAnimals1.Visible = false;
        }


    }
}
