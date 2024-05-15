using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace VirtualZooManagementFA3
{
    public partial class FeedAnimals : UserControl
    {
        private ObservableCollection<Animal> animals;
        public FeedAnimals()
        {
            InitializeComponent();

            animals = new ObservableCollection<Animal>();
            animalListBox.ItemsSource = animals;
            LoadAnimals();
        }

        private async void LoadAnimals()
        {
            animals.Clear();
            var animalList = await SQLiteConnector.LoadAnimalsAsync();
            foreach (var animal in animalList)
            {
                animals.Add(animal);
            }
        }

        private void FeedAnimal_Click(object sender, RoutedEventArgs e)
        {
            FeedAnimalWithFood();
        }

        private void GiveWater_Click(object sender, RoutedEventArgs e)
        {
            FeedAnimalWithWater();
        }

        private void FeedAnimalWithFood()
        {
            if (animalListBox.SelectedItem is Animal selectedAnimal)
            {
                // Feed the selected animal with food
                selectedAnimal.Eat();

                // Display a notification with the animal's thirst, hunger, and energy levels
                string message = $"Animal: {selectedAnimal.Name}\nThirst: {selectedAnimal.ThirstLevel}\nHunger: {selectedAnimal.HungerLevel}\nEnergy: {selectedAnimal.EnergyLevel}";
                MessageBox.Show(message, "Feeding Notification", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void FeedAnimalWithWater()
        {
            if (animalListBox.SelectedItem is Animal selectedAnimal)
            {
                // Feed the selected animal with water
                selectedAnimal.Drink();

                // Display a notification with the animal's thirst, hunger, and energy levels
                string message = $"Animal: {selectedAnimal.Name}\nThirst: {selectedAnimal.ThirstLevel}\nHunger: {selectedAnimal.HungerLevel}\nEnergy: {selectedAnimal.EnergyLevel}";
                MessageBox.Show(message, "Feeding Notification", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
