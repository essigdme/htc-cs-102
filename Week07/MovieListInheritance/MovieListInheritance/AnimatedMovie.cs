using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MovieList
{
    class AnimatedMovie : Movie
    {
        public string AnimationStudio;
        public string AnimationType;

        public AnimatedMovie(string AnimationType, string AnimationStudio)
        {
            this.AnimationType = AnimationType;
            this.AnimationStudio = AnimationStudio;

        }

        public override void ShowDetails()
        {
            MessageBox.Show(AnimationStudio);
            MessageBox.Show(AnimationType);
            MessageBox.Show(Convert.ToString(ReleaseYear));
            MessageBox.Show(Title);
        }
       
    }
}
