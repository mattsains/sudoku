using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SudokuSolver
{
    class Sudoku
    {
        private byte[,] board = new byte[9, 9];
        /// <summary>
        /// Access the Sudoku grid as a flat array
        /// </summary>
        /// <param name="i">index of element</param>
        /// <returns>A byte. Zero represents unfilled</returns>
        public byte this[int i]
        {
            get { return board[i / 9, i % 9]; }
            set { board[i / 9, i % 9] = value; }
        }
        /// <summary>
        /// Access the Sudoku grid
        /// </summary>
        /// <param name="r">row index</param>
        /// <param name="c">column index</param>
        /// <returns>A byte. Zero represents unfilled</returns>
        public byte this[int r, int c]
        {
            get { return board[r, c]; }
            set { board[r, c] = value; }
        }
        /// <summary>
        /// Calculates the numbers which could fit in the sudoku grid at a position
        /// </summary>
        /// <param name="i">The position</param>
        /// <returns>A list of possibilities</returns>
        public List<byte> ValidNums(int i)
        {
            return ValidNums(i / 9, i % 9);
        }
        /// <summary>
        /// Calculates the numbers which could fit in the sudoku grid at a position
        /// </summary>
        /// <param name="left">The column index</param>
        /// <param name="top">The row index</param>
        /// <returns>A list of possibilities</returns>
        public List<byte> ValidNums(int left, int top)
        {
            List<byte> output = new List<byte>(9);
            for (byte i = 1; i < 10; i++) output.Add(i);

            //check for rows and columns
            for (byte i = 0; i < 9; i++)
            {
                if (output.Contains(board[left, i]))
                    output.Remove(board[left, i]);
                if (output.Contains(board[i, top]))
                    output.Remove(board[i, top]);
            }
            //check in the cell
            for (int i = (left / 3) * 3; i < (left / 3) * 3 + 3; i++)
            {
                for (int j = (top / 3) * 3; j < (top / 3) * 3 + 3; j++)
                    if (output.Contains(board[i, j]))
                        output.Remove(board[i, j]);
            }
            return output;
        }
        /// <summary>
        /// Verifies every number in the sudoku.
        /// Ignores blank spaces
        /// Pretty slow process
        /// </summary>
        /// <returns>true if the board is valid, false otherwise</returns>
        public bool SlowVerify()
        {
            for (byte i=0; i<9;i++)
                for (byte j=0; j<9;j++)
                    if (this[i, j] != 0)
                    {
                        //temporarily remove this element
                        byte temp = this[i, j];
                        this[i, j] = 0;
                        //see if it belongs in its place
                        bool valid = this.ValidNums(i, j).Contains(temp);
                        //put it back
                        this[i, j] = temp;
                        if (!valid) return false;
                    }
            return true;
        }
        /// <summary>
        /// Load up a bunch of bytes into the sudoku grid
        /// </summary>
        /// <param name="values">A byte array, along and down</param>
        public Sudoku(byte[] values)
        {
            for (byte i = 0; i < 9 * 9; i++)
            {
                this[i] = values[i];
            }
        }
        /// <summary>
        /// Create a clone of a Sudoku grid
        /// </summary>
        /// <param name="s">The grid to clone</param>
        public Sudoku(Sudoku s)
        {
            for (byte i = 0; i < 9 * 9; i++)
                this[i] = s[i];
        }
        /// <summary>
        /// Are there no blanks in this sudoku?
        /// </summary>
        public bool Complete
        {
            get
            {
                for (byte i = 0; i < 9 * 9; i++)
                    if (this[i] == 0)
                        return false;
                return true;
            }
        }
        /// <summary>
        /// Solves the sudoku given. 
        /// </summary>
        /// <param name="s"></param>
        /// <param name="begin">Internal use only</param>
        /// <returns>Whether the sudoku was solved</returns>
        public static bool Solve(Sudoku s, int begin = 0)
        {
            while (s[begin] != 0) begin++; //skip to the next blank space

            List<byte> possible = s.ValidNums(begin); //get all possibilities for this space

            //start exploring the solution tree recursively
            //you would expect this to take forever, but as we step deeper into the tree, the number of possibilities rapidly decreases
            foreach (byte p in possible)
            {
                s[begin] = p;
                if (s.Complete) return true; //if adding this valid number completes the tree, it is solved
                else Solve(s, begin + 1); //Start exploring the solution tree
                if (s.Complete) return true; //if one of the children of this branch was a solution, it is solved
                //otherwise try another branch
            }
            // If execution gets here, there is no solution
            s[begin] = 0; //set the current space back to blank
            return false;
        }
        /// <summary>
        /// Turns a Sudoku grid into a string
        /// </summary>
        /// <returns>A string representation of the grid</returns>
        public override string ToString()
        {
            string output = "";
            for (int i = 0; i < 9; i++)
            {
                for (byte j = 0; j < 9; j++)
                {
                    if (this[i, j] != 0) output += this[i, j];
                    else output += "-";
                    output += " ";
                    if (j % 3 == 2) output += " ";
                }
                output += "\n\r";
                if (i % 3 == 2) output += "\n\r";
            }
            return output;
        }
    }
}
