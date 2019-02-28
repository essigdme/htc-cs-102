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

namespace MovieList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public List<Movie> movieList;

        public MainWindow()
        {
            InitializeComponent();

            movieList = new List<Movie>();
        }

        private void buttonAddMovie_Click(object sender, RoutedEventArgs e)
        {
            string name = textBoxTitle.Text;
            bool success = Int32.TryParse(value, out number);
            if(success == false)
            {
                MessageBox.Show("Please input an actual year in numbers.");
            }
            else
            {

            }
            int year = Convert.ToInt32(textBoxTitle1.Text);
            textBoxTitle.Clear();
            textBoxTitle1.Clear();

            Movie newMovie = new Movie(name, year);
            movieList.Add(newMovie);
            MessageBox.Show(name);
            MessageBox.Show(Convert.ToString(year));
        }

        private void buttonShowAll_Click(object sender, RoutedEventArgs e)
        {
            foreach(Movie movie in movieList)
            {
                movie.ShowMovie();
            }

    } 
        }
    }

