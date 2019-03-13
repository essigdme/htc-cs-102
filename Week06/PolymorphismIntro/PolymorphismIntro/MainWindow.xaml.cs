using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace PolymorphismIntro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Animal> Animals;

        public MainWindow()
        {
            InitializeComponent();

            Animals = new ObservableCollection<Animal>();

            Frog frog = new Frog(4, "Kermit", false, 10);
            Duck duck = new Duck(10, "Donald", 20);
            Duck duck1 = new Duck(5, "Daffy", 60);
            Dog dog = new Dog("Rapper", 10, "Snoop",70);

            Animals.Add(frog);
            Animals.Add(dog);
            Animals.Add(duck);
            Animals.Add(duck1);

            lvAnimals.ItemsSource = Animals;

        }

        private void Bark_Button_Click(object sender, RoutedEventArgs e)
        {
            Dog dog = new Dog();
            dog.Bark();
        }

        private void Quack_Button_Click(object sender, RoutedEventArgs e)
        {
            Duck duck = new Duck();
            duck.Quack();
        }

        private void Ribbit_Button_Click(object sender, RoutedEventArgs e)
        {
            Frog frog = new Frog();
            frog.Ribbit();
        }

        private void SayName_Button_Click(object sender, RoutedEventArgs e)
        {
            foreach (Animal animal in Animals)
            {
                animal.SayName();
            }

            /*// Define a new List of dogs
            List<Dog> dogs = new List<Dog>();
            
            // Instantiate some dog objects
            Dog dog1 = new Dog("Muppet", 20, "Rolf");
            Dog dog2 = new Dog("Golden Retriever", 30, "Air Bud");

            // Add the dogs to the list
            dogs.Add(dog1);
            dogs.Add(dog2);

            // Loop through the list and call a method on the objects
            foreach (Dog d in dogs)
            {
                d.SayName();
            }

            // Ducks and Frogs
            Duck duck1 = new Duck(9, "Donald");
            duck1.SayName();

            Frog frog1 = new Frog(4, "Kermit", false);
            frog1.SayName();*/
        }

        private void lvAnimals_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            Animal selectedAnimal = lvAnimals.SelectedItem as Animal;
            if(selectedAnimal != null)
            {
                selectedAnimal.Speak();
            }
        }
    }
}
