using static System.Console;

namespace QueenBacktracking
{
    class Program
    {
        const int n = 8;
        static int[,] board = new int[n, n];

        static void Main(string[] args)
        {
            InitBoard(board);
            Solve(board, 0);
            PrintSolution(board);

            ReadKey(true);
        }

        static void InitBoard(int[,] board)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    board[i, j] = 0;
                }
            }
        }

        /// <summary>
        /// A utility function to print solution
        /// </summary>
        /// <param name="board"></param>
        static void PrintSolution(int[,] board)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (board[i, j] == 1)
                    {
                        BackgroundColor = System.ConsoleColor.Green;
                        ForegroundColor = System.ConsoleColor.Black;
                    }
                    else
                    {
                        BackgroundColor = System.ConsoleColor.Black;
                        ForegroundColor = System.ConsoleColor.White;
                    }
                    Write(" " + board[i, j] + " ");
                }
                WriteLine();
            }
        }

        /// <summary>
        /// A utility function to check if a queen can be placed on board[row, col]. Note that this
        /// function is called when "col" queens are already placeed in columns from 0 to col -1. So we need
        /// to check only left side for attacking queens
        /// </summary>
        /// <param name="board"></param>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <returns></returns>
        static bool IsSafe(int[,] board, int row, int col)
        {
            int i, j;

            // Check this row on left side
            for (i = 0; i < col; i++)
            {
                if (board[row, i] == 1)
                {
                    return false;
                }
            }

            // Check upper diagonal on left side
            for (i = row, j = col; i >= 0 && j >= 0; i--, j--)
            {
                if (board[i, j] == 1)
                {
                    return false;
                }
            }

            // Check lower diagonal on left side
            for (i = row, j = col; j >= 0 && i < n; i++, j--)
            {
                if (board[i, j] == 1)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// A recursive utility function to solve N Queen problem
        /// </summary>
        /// <param name="board"></param>
        /// <param name="col"></param>
        /// <returns></returns>
        static bool Solve(int[,] board, int col)
        {
            // base case: If all queens are placed then return true
            if (col >= n)
            {
                return true;
            }

            // Consider this column and try placing this queen in all rows one by one
            for (int i = 0; i < n; i++)
            {
                // Check if queen can be placed on board[i, col]
                if (IsSafe(board, i, col))
                {
                    // Place this queen in board[i, col]
                    board[i, col] = 1;

                    // recur to place rest of the queens
                    if (Solve(board, col + 1) == true)
                    {
                        return true;
                    }

                    // If placing queen in board[i, col] doesn't lead to a solution then remove queen from board[i,col]
                    board[i, col] = 0; // BACKTRACK
                }
            }

            // If queen can not be place in any row in this colum col, then return false
            return false;
        }
    }
}
