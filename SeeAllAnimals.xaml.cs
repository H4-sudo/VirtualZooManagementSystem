using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace VirtualZooManagementFA3
{
    public partial class SeeAllAnimals : UserControl
    {
        private ObservableCollection<Animal> animals;

        public SeeAllAnimals()
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

        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            LoadAnimals();
        }

        private void MakeSleep_Click(object sender, RoutedEventArgs e)
        {
            if (animalListBox.SelectedItem is Animal selectedAnimal)
            {
                selectedAnimal.Sleep();
                // Refresh details panel to show updated data
                animalListBox.Items.Refresh();
            }
        }

        private void Play_Click(object sender, RoutedEventArgs e)
        {
            if (animalListBox.SelectedItem is Animal selectedAnimal)
            {
                selectedAnimal.Play();
                // Refresh details panel to show updated data
                animalListBox.Items.Refresh();
            }
        }
    }
}
