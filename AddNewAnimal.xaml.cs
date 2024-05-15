using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VirtualZooManagementFA3
{
    /// <summary>
    /// Interaction logic for AddNewAnimal.xaml
    /// </summary>
 
    public class AnimalAddedEventArgs : EventArgs
    {
        public string Name { get; }
        public int Age { get; }
        public string Type { get; }

        public AnimalAddedEventArgs(string name, int age, string type)
        {
            Name = name;
            Age = age;
            Type = type;
        }
    }

    public partial class AddNewAnimal : UserControl
    {
        public AddNewAnimal()
        {
            InitializeComponent();
        }

        public event EventHandler<AnimalAddedEventArgs> AnimalAdded;

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || 
                !int.TryParse(txtAge.Text, out int age) ||
                cmbType.SelectedItem == null)
            {
                txtError.Text = "Please fill out all fields correctly.";
                return;
            }

            string name = txtName.Text;
            string type = ((ComboBoxItem)cmbType.SelectedItem).Content.ToString();

            Animal newAnimal = null;

            switch (type)
            {
                case "Lion":
                    newAnimal = new Lion(name, age, type);
                    break;
                case "Elephant":
                    newAnimal = new Elephant(name, age, type);
                    break;
                case "Parrot":
                    newAnimal = new Parrot(name, age, type);
                    break;
                case "Turtle":
                    newAnimal = new Turtle(name, age, type);
                    break;
                case "Monkey":
                    newAnimal = new Monkey(name, age, type);
                    break;
                case "PolarBear":
                    newAnimal = new PolarBear(name, age, type);
                    break;
                case "Giraffe":
                    newAnimal = new Giraffe(name, age, type);
                    break;
                case "Kangaroo":
                    newAnimal = new Kangaroo(name, age, type);
                    break;
                default:
                    Console.WriteLine("No animal of this type");
                    break;
            }

            if (newAnimal != null)
            {
                SQLiteConnector.SaveAnimalAsync(newAnimal);
                OnAnimalAdded(new AnimalAddedEventArgs(name, age, type));
            }
            else
            {
                Console.WriteLine("Failed to create an instance of the selected animal type.");
            }

            txtName.Text = "";
            txtAge.Text = "";
            cmbType.SelectedItem = null;
            txtError.Text = "";
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            txtName.Text = "";
            txtAge.Text = "";
            cmbType.SelectedItem = null;
            txtError.Text = "";
        }

        private void TxtAge_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!int.TryParse(txtAge.Text, out int age))
            {
                txtError.Text = "Age must be a numeric value, try again.";
            }
            else
            {
                txtError.Text = "";
            }
        }

        protected virtual void OnAnimalAdded(AnimalAddedEventArgs e)
        {
            AnimalAdded?.Invoke(this, e);
        }
    }
}
