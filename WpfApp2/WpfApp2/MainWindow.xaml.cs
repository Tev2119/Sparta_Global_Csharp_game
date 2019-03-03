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
        int player1 = 1;
        int player2 = 2;
        TextBlock child;
        TextBlock child1;
        TextBlock child2;
        TextBlock child3;
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
        public void CalculateWinner()
        {
            if (/*WinnerInColumn() || WinnerInRow() || WinnerInDR() ||*/ WinnerInDL())
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
        private bool WinnerInColumn()
        {

            if (grid1.Background == Brushes.DarkOrange)
            {
                if (grid1.Background == Brushes.DarkOrange)
                {
                    for (int i = 1; i < 7; i++)
                    {
                        for (int j = 8; j > 0+3; j--)
                        {
                             child = (TextBlock)GridChildArray(j, 0);
                             child1 = (TextBlock)GridChildArray(j-1, 0);
                            child2 = (TextBlock)GridChildArray(j - 2, 0);
                            child3 = (TextBlock)GridChildArray(j - 3, 0);

                            if (child.Text ==  child1.Text)
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
            }
            return false;
        }
        private bool WinnerInRow()
        {

            if (grid1.Background == Brushes.DarkOrange)
            {
                if (grid1.Background == Brushes.DarkOrange)
                {
                    for (int i = 0; i < 7-3; i++)
                    {
                        for (int j = 8; j > 0 ; j--)
                        {
                            child = (TextBlock)GridChildArray(j , i);
                            child1 = (TextBlock)GridChildArray(j , i+1);
                            child2 = (TextBlock)GridChildArray(j , i+2);
                            child3 = (TextBlock)GridChildArray(j , i+3);

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
            }
            return false;
        }
        private bool WinnerInDR()
        {

            if (grid1.Background == Brushes.DarkOrange)
            {
                if (grid1.Background == Brushes.DarkOrange)
                {
                    for (int i = 0; i < 7 - 3; i++)
                    {
                        for (int j = 8; j > 0 + 3; j--)
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
            }
            return false;
        }
        private bool WinnerInDL()
        {

            if (grid1.Background == Brushes.DarkOrange)
            {
                if (grid1.Background == Brushes.DarkOrange)
                {
                    for (int i = 7; i >= 0 + 3; i--)
                    {
                        for (int j = 8; j >= 0 + 3; j--)
                        {
                            child = (TextBlock)GridChildArray(j, i);
                            child1 = (TextBlock)GridChildArray(j - 1, i - 1);
                            child2 = (TextBlock)GridChildArray(j - 2, i - 2);
                            child3 = (TextBlock)GridChildArray(j - 3, i - 3);

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
            }
            return false;
        }



        //public bool WinnerInColumn()
        //{
        //    //for (int i = 0; i < 8; i++)
        //    //{

        //    //    for (int j = 8; j > i; j--)
        //    //    {
        //            //TextBlock child = (TextBlock)GridChildArray(j, b);
        //            if (r8c0.Text == r7c0.Text || r7c0.Text == r6c0.Text || r6c0.Text == r5c0.Text || r5c0.Text == r4c0.Text || r4c0.Text == r3c0.Text || r8c1.Text == r7c1.Text || r7c1.Text == r6c1.Text || r6c1.Text == r5c1.Text || r5c1.Text == r4c1.Text || r4c1.Text == r3c2.Text || r8c2.Text == r7c2.Text || r7c2.Text == r6c2.Text || r6c2.Text == r5c2.Text || r5c2.Text == r4c2.Text || r4c2.Text == r3c2.Text || r8c3.Text == r7c3.Text || r7c3.Text == r6c3.Text || r6c3.Text == r5c3.Text || r5c3.Text == r4c3.Text || r4c3.Text == r3c3.Text || r8c4.Text == r7c4.Text || r7c4.Text == r6c4.Text || r6c4.Text == r5c4.Text || r5c4.Text == r4c4.Text || r4c4.Text == r3c4.Text || r8c5.Text == r7c5.Text || r7c5.Text == r6c5.Text || r6c5.Text == r5c5.Text || r5c5.Text == r4c5.Text || r4c5.Text == r3c5.Text || r8c6.Text == r7c6.Text || r7c6.Text == r6c6.Text /*|| r6c6.Text == r5c7.Text || r5c7.Text == r4c7.Text || r4c7.Text == r3c7.Text*/)
        //            {

        //                if (r7c0.Text == r6c0.Text && r6c0.Text == r5c0.Text || r6c0.Text == r5c0.Text && r5c0.Text == r4c0.Text || r5c0.Text == r4c0.Text && r4c0.Text == r3c0.Text || r3c0.Text == r2c0.Text && r2c0.Text == r1c0.Text || r7c1.Text == r6c1.Text && r6c1.Text == r5c1.Text || r6c1.Text == r5c1.Text && r5c1.Text == r4c1.Text || r5c1.Text == r4c1.Text && r4c1.Text == r3c1.Text || r3c1.Text == r2c1.Text && r2c1.Text == r1c1.Text || r7c2.Text == r6c2.Text && r6c2.Text == r5c2.Text || r6c2.Text == r5c2.Text && r5c2.Text == r4c2.Text || r5c2.Text == r4c2.Text && r4c2.Text == r3c2.Text || r3c2.Text == r2c2.Text && r2c2.Text == r1c2.Text || r7c3.Text == r6c3.Text && r6c3.Text == r5c3.Text || r6c3.Text == r5c3.Text && r5c3.Text == r4c3.Text || r5c3.Text == r4c3.Text && r4c3.Text == r3c3.Text || r3c3.Text == r2c3.Text && r2c3.Text == r1c3.Text || r7c4.Text == r6c4.Text && r6c4.Text == r5c4.Text || r6c4.Text == r5c4.Text && r5c4.Text == r4c4.Text || r5c4.Text == r4c4.Text && r4c4.Text == r3c4.Text || r3c4.Text == r2c4.Text && r2c4.Text == r1c4.Text || r7c5.Text == r6c5.Text && r6c5.Text == r5c5.Text || r6c5.Text == r5c5.Text && r5c5.Text == r4c5.Text || r5c5.Text == r4c5.Text && r4c5.Text == r3c5.Text || r3c5.Text == r2c5.Text && r2c5.Text == r1c5.Text || r7c6.Text == r6c6.Text && r6c6.Text == r5c6.Text || r6c6.Text == r5c6.Text && r5c6.Text == r4c6.Text || r5c6.Text == r4c6.Text && r4c6.Text == r3c6.Text || r3c6.Text == r2c6.Text && r2c6.Text == r1c6.Text || r7c7.Text == r6c7.Text && r6c7.Text == r5c7.Text || r6c7.Text == r5c7.Text && r5c7.Text == r4c7.Text || r5c7.Text == r4c7.Text && r4c7.Text == r3c7.Text || r3c7.Text == r2c7.Text && r2c7.Text == r1c7.Text ||

        //                    r7c1.Text == r6c1.Text && r6c1.Text == r5c1.Text || r7c2.Text == r6c2.Text && r6c2.Text == r5c2.Text || r7c3.Text == r6c3.Text && r6c3.Text == r5c3.Text || r7c4.Text == r6c4.Text && r6c4.Text == r5c4.Text || r7c5.Text == r6c5.Text && r6c5.Text == r5c5.Text || r7c6.Text == r6c6.Text && r6c6.Text == r5c6.Text || r7c7.Text == r6c7.Text && r6c7.Text == r5c7.Text)
        //                {
        //                    return true;
        //                }
        //        //    }
        //        //}
        //    }
        //    return false;
        //}
        //public bool WinnerInRow()
        //{
        //    //for (int i = 0; i < 8; i++)
        //    //{

        //    //    for (int j = 8; j > i; j--)
        //    //    {
        //            //TextBlock child = (TextBlock)GridChildArray(j, b);
        //            if (r8c0.Text == r8c1.Text || r8c1.Text == r8c3.Text || r8c3.Text == r8c4.Text || r8c4.Text == r8c5.Text || r7c0.Text == r7c1.Text || r7c1.Text == r7c2.Text || r7c2.Text == r7c3.Text || r7c3.Text == r7c4.Text || r7c4.Text == r7c5.Text || r6c0.Text == r6c1.Text || r6c1.Text == r6c2.Text || r6c2.Text == r6c3.Text || r6c3.Text == r6c4.Text || r6c4.Text == r6c5.Text || r5c0.Text == r5c1.Text || r5c1.Text == r5c2.Text || r5c2.Text == r5c3.Text || r5c3.Text == r5c4.Text || r5c4.Text == r5c5.Text || r4c0.Text == r4c1.Text || r4c1.Text == r4c2.Text || r4c2.Text == r4c3.Text || r4c3.Text == r4c4.Text || r4c4.Text == r4c5.Text || r3c0.Text == r3c1.Text || r3c1.Text == r3c2.Text || r3c2.Text == r3c3.Text || r3c3.Text == r3c4.Text || r3c4.Text == r3c5.Text || r2c0.Text == r2c1.Text || r2c1.Text == r2c2.Text || r2c2.Text == r2c3.Text || r2c3.Text == r2c4.Text || r2c4.Text == r2c5.Text /*|| r1c0.Text == r1c1.Text || r1c1.Text == r1c2.Text || r1c2.Text == r1c3.Text || r1c3.Text == r1c4.Text || r1c4.Text == r1c5.Text*/)
        //            {

        //                if (r8c1.Text == r8c2.Text && r8c2.Text == r8c3.Text || r8c2.Text == r8c3.Text && r8c3.Text == r8c4.Text || r8c3.Text == r8c4.Text && r8c4.Text == r8c5.Text || r8c4.Text == r8c5.Text && r8c5.Text == r8c6.Text || r8c5.Text == r8c6.Text && r8c6.Text == r8c7.Text || r7c1.Text == r7c2.Text && r7c2.Text == r7c3.Text || r7c2.Text == r7c3.Text && r7c3.Text == r7c4.Text || r7c3.Text == r7c4.Text && r7c4.Text == r7c5.Text || r7c4.Text == r7c5.Text && r7c5.Text == r7c6.Text || r7c5.Text == r7c6.Text && r7c6.Text == r7c7.Text||r6c1.Text == r6c2.Text && r6c2.Text == r6c3.Text || r6c2.Text == r6c3.Text && r6c3.Text == r6c4.Text || r6c3.Text == r6c4.Text && r6c4.Text == r6c5.Text || r6c4.Text == r6c5.Text && r6c5.Text == r6c6.Text || r6c5.Text == r6c6.Text && r6c6.Text == r6c7.Text || r5c1.Text == r5c2.Text && r5c2.Text == r5c3.Text || r5c2.Text == r5c3.Text && r5c3.Text == r5c4.Text || r5c3.Text == r5c4.Text && r5c4.Text == r5c5.Text || r5c4.Text == r5c5.Text && r5c5.Text == r5c6.Text || r5c5.Text == r5c6.Text && r5c6.Text == r5c7.Text || r4c1.Text == r4c2.Text && r4c2.Text == r4c3.Text || r4c2.Text == r4c3.Text && r4c3.Text == r4c4.Text || r4c3.Text == r4c4.Text && r4c4.Text == r4c5.Text || r4c4.Text == r4c5.Text && r4c5.Text == r4c6.Text || r4c5.Text == r4c6.Text && r4c6.Text == r4c7.Text || r3c1.Text == r3c2.Text && r3c2.Text == r3c3.Text || r3c2.Text == r3c3.Text && r3c3.Text == r3c4.Text || r3c3.Text == r3c4.Text && r3c4.Text == r3c5.Text || r3c4.Text == r3c5.Text && r3c5.Text == r3c6.Text || r3c5.Text == r3c6.Text && r3c6.Text == r3c7.Text || r2c1.Text == r2c2.Text && r2c2.Text == r2c3.Text || r2c2.Text == r2c3.Text && r2c3.Text == r2c4.Text || r2c3.Text == r2c4.Text && r2c4.Text == r2c5.Text || r2c4.Text == r2c5.Text && r2c5.Text == r2c6.Text || r2c5.Text == r2c6.Text && r2c6.Text == r2c7.Text || r1c1.Text == r1c2.Text && r1c2.Text == r1c3.Text || r1c2.Text == r1c3.Text && r1c3.Text == r1c4.Text || r1c3.Text == r1c4.Text && r1c4.Text == r1c5.Text || r1c4.Text == r1c5.Text && r1c5.Text == r1c6.Text || r1c5.Text == r1c6.Text && r1c6.Text == r1c7.Text)
        //                {
        //                    return true;
        //                }
        //        //    }
        //        //}
        //    }
        //    return false;
        //}
        //public bool WinnerInDR()
        //{

        //    //for (int i = 0; i < 8; i++)
        //    //{
        //    //    for (int j = 8; j > i; j--)
        //    //    {
        //            //TextBlock child = (TextBlock)GridChildArray(j, b);
        //            if (r4c0.Text == r3c1.Text || r5c0.Text == r4c1.Text || r4c1.Text == r3c2.Text || r4c2.Text == r3c3.Text||r6c0.Text == r5c1.Text ||r5c1.Text == r4c2.Text || r7c0.Text == r6c1.Text || r6c1.Text == r5c2.Text || r5c2.Text == r4c3.Text || r4c3.Text == r3c4.Text || r8c0.Text == r7c1.Text || r7c1.Text == r6c2.Text || r6c2.Text == r5c3.Text /*|| r5c3.Text == r4c4.Text || r4c4.Text == r3c5.Text || r8c1.Text == r7c2.Text || r7c2.Text == r6c3.Text || r6c3.Text == r5c4.Text || r5c4.Text == r4c5.Text || r8c2.Text == r7c3.Text *//*|| r7c3.Text == r6c4.Text || r6c4.Text == r5c5.Text*/ /*|| r8c3.Text == r7c4.Text || r7c4.Text == r6c5.Text || r8c4.Text == r7c5.Text*/)
        //            {

        //                if (r3c1.Text == r2c2.Text && r2c2.Text == r1c3.Text || r4c1.Text == r3c2.Text && r3c2.Text == r2c3.Text || r3c2.Text == r2c3.Text && r2c3.Text == r1c4.Text || r3c3.Text == r2c4.Text && r2c4.Text == r1c5.Text || r5c1.Text == r4c2.Text && r4c2.Text == r3c3.Text || r4c2.Text == r3c3.Text && r3c3.Text == r2c4.Text || r6c1.Text == r5c2.Text && r5c2.Text == r4c3.Text || r5c2.Text == r4c3.Text && r4c3.Text == r3c4.Text || r4c3.Text == r3c4.Text && r3c4.Text == r2c5.Text || r3c4.Text == r2c5.Text && r2c5.Text == r1c6.Text || r7c1.Text == r6c2.Text && r6c2.Text == r5c3.Text || r6c2.Text == r5c3.Text && r5c3.Text == r4c4.Text || r5c3.Text == r4c4.Text && r4c4.Text == r3c5.Text || r4c4.Text == r3c5.Text && r3c5.Text == r2c6.Text || r3c5.Text == r2c6.Text && r2c6.Text == r1c7.Text || r7c2.Text == r6c3.Text && r6c3.Text == r5c4.Text || r6c3.Text == r5c4.Text && r5c4.Text == r4c5.Text || r5c4.Text == r4c5.Text && r4c5.Text == r3c6.Text || r4c5.Text == r3c6.Text && r3c6.Text == r2c7.Text || r7c3.Text == r6c4.Text && r6c4.Text == r5c5.Text || r6c4.Text == r5c5.Text && r5c5.Text == r4c6.Text || r5c5.Text == r4c6.Text && r4c6.Text == r3c7.Text || r7c4.Text == r6c5.Text && r6c5.Text == r5c6.Text || r6c5.Text == r5c6.Text && r5c6.Text == r4c7.Text || r7c5.Text == r6c6.Text && r6c6.Text == r5c7.Text)
        //                {
        //                    return true;
        //                }
        //        //    }
        //        //}
        //    }
        //    return false;
        //}

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            grid1.Background = Brushes.DarkOrange;
            grid1.ShowGridLines = true;
        }
    }
}
