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
using Shapes;


namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Rectangle rect = new Rectangle();
            rect.Height = 90;
            rect.Width = 80;
            rect.Fill = Brushes.Aquamarine;
            rect.Stroke = Brushes.YellowGreen;
            rect.StrokeThickness = 1;

            Canvas.SetLeft(rect, 200);
            Canvas.SetTop(rect, 100);

            myCanvas.Children.Add(rect);



            Diamond diamond1 = new Diamond();
            diamond1.Fill = Brushes.Red;
            diamond1.Stroke = Brushes.Purple;
            diamond1.StrokeThickness = 2;

            Canvas.SetLeft(diamond1, 300);
            Canvas.SetTop(diamond1, 100);

            myCanvas.Children.Add(diamond1);
            
        }
    }
}
