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
        int[,] grid = { { 0 }, {8} };
        int player1 = 1;
        int player2 = 2;
        public void DropCoin()
        {
            if (grid1.Background == Brushes.OrangeRed)
            {
               
                    for (int j = grid1.RowDefinitions.Count; j > 0; j--)
                    {
                        //grid = new int[i, j];
                        TextBox tblock = new TextBox();
                        TextBox tblock2 = new TextBox();


                        if (tblock.GetLineText(j) != "2" || tblock.GetLineText(j) != "1")
                        {
                            if (player1 ==1)
                            {
                                tblock.Background = Brushes.Red;
                                tblock.Foreground = Brushes.Orange;
                                Grid.SetRow(tblock, j);
                                grid1.Children.Add(tblock);
                                player1 = 2;

                                break;
                            }
                            else
                            {
                                tblock2.Background = Brushes.Blue;
                                tblock2.Foreground = Brushes.Orange;
                                Grid.SetRow(tblock2, j);
                                grid1.Children.Add(tblock2);
                                player1 = 1;
                                break;

                            }
                        }
                    }
            }
        }
        
        GridManipulation gameBaord = new GridManipulation();
        public MainWindow()
        {
            InitializeComponent();
        }

        
        private void coin1_click(object sender, RoutedEventArgs e)
        {
                  DropCoin();
        }
        private void coin2_click(object sender, RoutedEventArgs e)
        {
            grid1.Background = Brushes.OrangeRed;
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


//if (player1 == 1)
//{
//    TextBox tblock = new TextBox();
//    tblock.Background = Brushes.Red;
//    tblock.Foreground = Brushes.Orange;
//    Grid.SetRow(tblock, i);
//    grid1.Children.Add(tblock);
//    player1 = player2;
//    break;
//}
//else
//{
//    TextBox tblock2 = new TextBox();
//    tblock2.Background = Brushes.Blue;
//    tblock2.Foreground = Brushes.Orange;
//    Grid.SetRow(tblock2, i);
//    grid1.Children.Add(tblock2);
//    player1 = 1;
//    break;
//}

//tblock.SetValue(Grid.RowProperty, 16);
//tblock.SetValue(Grid.ColumnProperty, 0);