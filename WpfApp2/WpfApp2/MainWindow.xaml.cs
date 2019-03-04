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
    public partial class MainWindow : Window
    {
        //Player & Win variables
        int player1 = 1;
        int player2 = 2;
        TextBlock child;
        TextBlock child1;
        TextBlock child2;
        TextBlock child3;

        //GridArray[ r , c ] from Base CLass
        public UIElement GridChildArray(int r, int c)
        {
            for (int i = 0; i < grid1.Children.Count; i++)
            {
                UIElement e = grid1.Children[i];
                if (Grid.GetRow(e) == r && Grid.GetColumn(e) == c)
                    return e;
            }
            return null;
        }

        //GridManipulation gameBaord = new GridManipulation();
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void coin1_Click(object sender, RoutedEventArgs e)
        {
            DropCoin(0);
            CalculateWinner();
        }

        private void coin2_click(object sender, RoutedEventArgs e)
        {
            
            DropCoin(1);
            CalculateWinner();
        }

        private void coin3_click(object sender, RoutedEventArgs e)
        {
            DropCoin(2);
            CalculateWinner();
        }

        private void coin4_click(object sender, RoutedEventArgs e)
        {
            DropCoin(3);
            CalculateWinner();
        }

        private void coin5_click(object sender, RoutedEventArgs e)
        {
            //TextBlock bd = (TextBlock)e.Source;
            ////Buttons with Tag name bd
            //int bt = Int32.Parse(bd.Tag.ToString());
            DropCoin(4);
            CalculateWinner();
        }

        private void coin6_click(object sender, RoutedEventArgs e)
        {
            DropCoin(5);
            CalculateWinner();
        }

        private void coin7_click(object sender, RoutedEventArgs e)
        {
            DropCoin(6);
            CalculateWinner();
        }

        private void coin8_click(object sender, RoutedEventArgs e)
        {
            DropCoin(7);
            CalculateWinner();
        }

        //create player variables
        public void DropCoin(int x)
        {
            if (grid1.Background == Brushes.DarkOrange)
            {
                //for (int i = 0; i < 8; i++)
                //{
                    for (int j = 8; j > 0; j--)
                    {
                         child = (TextBlock)GridChildArray(j, x);

                        if (child.Text == "2" || child.Text == "1" || child.Text == "3")
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
                    
                //}
            }
        }

        //calculate winner & Player
        public void CalculateWinner()
        {
            if (/*WinnerInColumn() || */WinnerInRow() /*|| WinnerInDR() /*||WinnerInDL()*/)
            {
                if (player1 == 1)
                {
                    System.Windows.Forms.MessageBox.Show("winner found player2");
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("winner found player1");

                }
            }
        }

        /// <summary>
        /// Win Statements & checks
        /// </summary>
        private bool WinnerInColumn()
        {
            if (grid1.Background == Brushes.DarkOrange)
            {
                for (int i = 0; i < 7; i++)
                {
                    for (int j = 8; j > 0 + 3; j--)
                    {
                        child = (TextBlock)GridChildArray(j, i);
                        child1 = (TextBlock)GridChildArray(j - 1, i);
                        child2 = (TextBlock)GridChildArray(j - 2, i);
                        child3 = (TextBlock)GridChildArray(j - 3, i);

                        if (child.Text == child1.Text)
                        {
                            if (child1.Text == child2.Text && child2.Text == child3.Text)
                            {
                                return true;
                            }
                            break;

                        }
                    }
                }
            }
            return false;
        }
        private bool WinnerInRow()
        {
            if (child.Text != "2" || child.Text != "1" || child.Text != "3")
            {
                for (int f = 0; f < 7; f++)
                {
                        for (int p = 8; p >= 1 ; p--)
                        {
                            child = (TextBlock)GridChildArray(p, f);
                            child1 = (TextBlock)GridChildArray(p, f+1);
                            child2 = (TextBlock)GridChildArray(p, f+2);
                            child3 = (TextBlock)GridChildArray(p, f+3);

                            if (child.Text == child1.Text)
                            {
                                if (child1.Text == child2.Text && child2.Text == child3.Text)
                                {
                                    return true;
                                }
                            }
                        break;
                        }
                }
            }
            return false;
        }
        private bool WinnerInDR()
        {

            if (grid1.Background == Brushes.DarkOrange)
            {
                    for (int i = 0; i <= 7 - 3; i++)
                    {
                        for (int j = 8; j >= 1 + 3; j--)
                        {
                            child = (TextBlock)GridChildArray(j, i);
                            child1 = (TextBlock)GridChildArray(j - 1, i + 1);
                            child2 = (TextBlock)GridChildArray(j - 2, i + 2);
                            child3 = (TextBlock)GridChildArray(j - 3, i + 3);

                            if (child.Text == child1.Text)
                            {
                                if (child1.Text == child2.Text && child2.Text == child3.Text)
                                {
                                    return true;
                                }
                                break;

                            }
                        }

                    }
            }
            return false;
        }
        private bool WinnerInDL()
        {

            if (grid1.Background == Brushes.DarkOrange)
            {
                    for (int y = 7; y > 0 + 3; y--)
                    {
                        for (int x = 8; x >= 1 + 3; x--)
                        {
                            child = (TextBlock)GridChildArray(x, y);
                            child1 = (TextBlock)GridChildArray(x - 1, y - 1);
                            child2 = (TextBlock)GridChildArray(x - 2, y - 2);
                            child3 = (TextBlock)GridChildArray(x - 3, y - 3);

                            if (child.Text == child1.Text)
                            {
                                if (child1.Text == child2.Text && child2.Text == child3.Text)
                                {
                                    return true;
                                }
                                break;
                            }
                        }
                    }
            }
            return false;
        }

        //Start Game initialise board
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            grid1.Background = Brushes.DarkOrange;
            grid1.ShowGridLines = true;
            

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
            Application.Current.Shutdown();
        }

        private void Button_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
