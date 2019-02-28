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
        public UIElement GridChildArray(int r, int c)
        {
            for (int i = 0; i <grid1.Children.Count; i++)
            {
                UIElement e = grid1.Children[i];
                if (Grid.GetRow(e) == r && Grid.GetColumn(e) == c)
                    return e;
            }
            return null;
        }
        int player1 = 1;
        int player2 = 2;
        public void DropCoin(int x)
        {
            if (grid1.Background == Brushes.DarkOrange)
            {
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 8; j > i; j--)
                    {
                        TextBlock child = (TextBlock)GridChildArray(j, x);

                        if (child.Text == "2" || child.Text == "1")
                        {
                            if (player1 == 1)
                            {
                                child.Background = Brushes.Black;
                                child.Text = "player1";
                                player1 = player2;
                                //GetGridChild(j, 0).Background = Brushes.Black;
                            }
                            else
                            {
                                child.Background = Brushes.DeepPink;
                                child.Text = "player2";
                                player1 = 1;
                            }
                            break;
                        }
                    }
                    break;
                }
            }
        }
        GridManipulation gameBaord = new GridManipulation();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void coin1_Click(object sender, RoutedEventArgs e)
        {
            DropCoin(0);
        }

        private void coin2_click(object sender, RoutedEventArgs e)
        {
            grid1.Background = Brushes.DarkOrange;
            grid1.ShowGridLines = true;
            DropCoin(1);
        }

        private void coin3_click(object sender, RoutedEventArgs e)
        {
            DropCoin(2);
        }

        private void coin4_click(object sender, RoutedEventArgs e)
        {
            DropCoin(3);
        }

        private void coin5_click(object sender, RoutedEventArgs e)
        {
            DropCoin(4);
        }

        private void coin6_click(object sender, RoutedEventArgs e)
        {
            DropCoin(5);
        }

        private void coin7_click(object sender, RoutedEventArgs e)
        {
            DropCoin(6);
        }

        private void coin8_click(object sender, RoutedEventArgs e)
        {
            DropCoin(7);
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