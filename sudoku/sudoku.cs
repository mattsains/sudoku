using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sudoku
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
