using System;

public class Program
{
    public static string playerTurn = "X";
    public static string[][] board = new string[][]
    {
new string[] {" ", " ", " "},
new string[] {" ", " ", " "},
new string[] {" ", " ", " "}
    };


    public static void Main()
    {
        do
        {
            DrawBoard();
            GetInput();

        } while (!CheckForWin() && !CheckForTie());

        // leave this command at the end so your program does not close automatically
        Console.ReadLine();
    }

    public static void GetInput()
    {
        Console.WriteLine("Player " + playerTurn);
        Console.WriteLine("Enter Row:");
        int row = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Column:");
        int column = int.Parse(Console.ReadLine());
        PlaceMark(row, column);

        if (CheckForWin())
        {
            DrawBoard();
            Console.WriteLine("Player " + playerTurn + " Won!");
            return;
        }
        else if (CheckForTie())
        {
            DrawBoard();
            Console.WriteLine("It's a Tie!");
            return;
        }

        playerTurn = (playerTurn == "X") ? "O" : "X";
    }

    public static void PlaceMark(int row, int column)

    {
        // your code goes here
        // board[row][column] = "X";
        board[row][column] = playerTurn;
    }

    public static bool CheckForWin()
    {
        //// your code goes here
        //if (HorizontalWin())
        //{
        // Console.WriteLine("Player " + playerTurn + " Won!");
        // return true;
        //}
        //else if (VerticalWin())
        //{
        // Console.WriteLine("Player " + playerTurn + " Won!");
        // return true;
        //}
        //else if (DiagonalWin())
        //{
        // Console.WriteLine("Player " + playerTurn + " Won!");
        // return true;
        //}
        //else
        //{
        // return false;
        //}

        return (HorizontalWin() || VerticalWin() || DiagonalWin());
    }

    public static int SlotsAvailable()
    {
        int openSlots = 0;

        foreach (var row in board)
        {
            foreach (var column in row)
            {
                if (column != "X" && column != "O")
                {

                    openSlots++;
                }
            }
        }

        return openSlots;
    }
    public static bool CheckForTie()
    {
        bool tie = false;

        tie = (SlotsAvailable() == 0) ? true : false;

        return tie;
    }

    public static bool HorizontalWin()
    {
        // your code goes here

        // Top horizontal row
        if (board[0][0] == playerTurn && board[0][1] ==
        playerTurn && board[0][2] == playerTurn
        ||
        // Middle horizontal row
        board[1][0] == playerTurn && board[1][1] ==
        playerTurn && board[1][2] == playerTurn
        ||
        //Bottom horizontal row
        board[2][0] == playerTurn && board[2][1] ==
        playerTurn && board[2][2] == playerTurn)

        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool VerticalWin()
    {
        // your code goes here

        // Left vertical row
        if (board[0][0] == playerTurn && board[1][0] ==
        playerTurn && board[2][0] == playerTurn
        // Middle vertical row
        || board[0][1] == playerTurn && board[1][1] ==
        playerTurn && board[2][1] == playerTurn
        // Right vertical row
        || board[0][2] == playerTurn && board[1][2] ==
        playerTurn && board[2][2] == playerTurn)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool DiagonalWin()
    {
        // your code goes here
        // Diagonal from top left to bottom right
        if (board[0][0] == playerTurn && board[1][1] ==
        playerTurn && board[2][2] == playerTurn
        // Diagonal from bottom left to top right
        || board[2][0] == playerTurn && board[1][1] ==
        playerTurn && board[0][2] == playerTurn)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static void DrawBoard()
    {
        Console.WriteLine(" 0 1 2");
        Console.WriteLine("0 " + String.Join("|", board[0]));
        Console.WriteLine(" -----");
        Console.WriteLine("1 " + String.Join("|", board[1]));
        Console.WriteLine(" -----");
        Console.WriteLine("2 " + String.Join("|", board[2]));
    }

}