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
using Connect4;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public void mathew()
        {
            for (int i = 1; i < grid1.RowDefinitions.Count; i++)
            {
                TextBox tblock = new TextBox();
                tblock.Background = Brushes.Red;
                tblock.Foreground = Brushes.Orange;
                TextBox tblock2 = new TextBox();
                tblock2.Background = Brushes.Blue;
                tblock2.Foreground = Brushes.Orange;
                //tblock.SetValue(Grid.RowProperty, 16);
                //tblock.SetValue(Grid.ColumnProperty, 0);
                Grid.SetRow(tblock, i);
                Grid.SetRow(tblock2, i);
                grid1.Children.Add(tblock);
                grid1.Children.Add(tblock2);

                //for (int x = 0; x < grid1.ColumnDefinitions.Count; x++)
                //{

                //}
            }
        }
        
        GridManipulation gameBaord = new GridManipulation();
        public MainWindow()
        {
            InitializeComponent();
            //grid1.Background = new SolidColorBrush(Colors.Orange);
            //grid1.GetType();
           
            //Console.WriteLine(grid1);

        }

        
        private void coin1_click(object sender, RoutedEventArgs e)
        {
            //TextBox tblock = new TextBox();
            //tblock.Background = Brushes.Red;
            //tblock.Foreground = Brushes.Orange;
            //TextBox tblock2 = new TextBox();
            //tblock2.Background = Brushes.Blue;
            //tblock2.Foreground = Brushes.Orange;
            ////tblock.SetValue(Grid.RowProperty, 16);
            ////tblock.SetValue(Grid.ColumnProperty, 0);
            //Grid.SetRow(tblock, 9);
            //Grid.SetRow(tblock2, 8);
            //grid1.Children.Add(tblock);
            //grid1.Children.Add(tblock2);
            //int[] col = new int[64];
            //grid1.Background.
           
        }
        private void coin2_click(object sender, RoutedEventArgs e)
        {

        }

        private void coin8_click(object sender, RoutedEventArgs e)
        {

        }

        private void coin3_click(object sender, RoutedEventArgs e)
        {

        }

        private void coin4_click(object sender, RoutedEventArgs e)
        {

        }

        private void coin5_click(object sender, RoutedEventArgs e)
        {

        }

        private void coin6_click(object sender, RoutedEventArgs e)
        {

        }

        private void coin7_click(object sender, RoutedEventArgs e)
        {

        }
    }
}
