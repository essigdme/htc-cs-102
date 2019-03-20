using System.Windows;

namespace MovieList
{
    public class Movie
    {
        private string text;
        private int v;

        public string Title
        {
            get;
            set;
        }

        public int ReleaseYear
        {
            get;
            set;
        }

       public virtual void ShowDetails()
        {
            string infoString = "Title: " + this.Title;
            infoString += "\nRelease Year: " + this.ReleaseYear;
            MessageBox.Show(infoString);
        }

        public Movie() { }

        public Movie(string myTitle, int myReleaseYear, string myAnimationType, string myAnimationStudio)
        {
            this.Title = myTitle;
            this.ReleaseYear = myReleaseYear;
            
        }

        public Movie(string text, int v)
        {
            this.text = text;
            this.v = v;
        }
    }
}
