using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Chess


#region todo 
    // Need to create peices
    //Give them an image and properites how to move 
    //Give Index of where they start
    //
#endregion
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool PlayerOneTurn; // If false, second players turn.
        private bool GameOver;
        ChessPieces[,] PiecePlacement;
        public MainWindow()
        {
            //Console.OutputEncoding = Encoding.UTF8;
            InitializeComponent();
            CreateBoard();
        }

        private void CreateBoard()
        {
            PiecePlacement = new ChessPieces[8, 8];

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    PiecePlacement[i, j] = new ChessPieces();

                    if (i == 1)
                    {
                        PiecePlacement[i, j] = new Pawn();
                    }

                }
            }
            
            PlayerOneTurn = true;

            GameOver = false;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //if (GameOver)
            //{
            //    NewGame();
            //    return;
            //}
            // cast the sender to a button
            var button = (Button)sender;

            // Find the buttons in the array
            var column = Grid.GetColumn(button);
            var row = Grid.GetRow(button);

            button.Content = PlayerOneTurn ? "O" : "X"; //  1/2  OK!

            PlayerOneTurn ^= true;
        }
    }
}
