using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
namespace SudokuSolver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            squares = new List<SudokuSquare>() { sq11, sq21, sq31, sq12, sq22, sq32, sq13, sq23, sq33 };
        }
        List<SudokuSquare> squares;

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (SudokuSquare square in squares)
                square.Reset();
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            //turn the board into a sudoku object
            byte[] values = new byte[81];
            for (byte i = 0; i < 9; i++)
                for (byte j = 0; j < 9; j++)
                    values[(i % 3) * 3 + (i / 3) * 27 + (j % 3) + (j / 3) * 9] = squares[i][j % 3, j / 3];
            //I have actually seen worse for loops

            Sudoku s = new Sudoku(values);
            //Attempt to solve the sudoku
            //The worst case for this algorithm is when the input sudoku is not valid, so test for that first
            if (s.SlowVerify() && Sudoku.Solve(s))
            {
                //turn a sudoku back into the board's format.
                for (byte i = 0; i < 9; i++)
                    for (byte j = 0; j < 9; j++)
                    {
                        squares[i][j % 3, j / 3] = s[(i % 3) * 3 + (i / 3) * 27 + (j % 3) + (j / 3) * 9];
                        Debug.Print("[" + i + "][" + (j % 3) + "," + (j / 3) + "]=>" + ((i % 3) * 3 + (i / 3) * 27 + (j % 3) + (j / 3) * 9));
                    }
            }
            else
            {
                MessageBox.Show("There are conflicting numbers in this sudoku.", "Unsolveable sudoku", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //put in some test data
            squares[0][0, 2] = 2;
            squares[0][1, 0] = 7;
            squares[0][1, 2] = 6;
            squares[0][2, 2] = 9;
            squares[1][0, 0] = 3;
            squares[1][1, 0] = 1;
            squares[2][1, 0] = 9;
            squares[2][2, 1] = 5;
            squares[2][2, 2] = 7;
            squares[3][0, 1] = 8;
            squares[3][0, 2] = 4;
            squares[3][2, 0] = 7;
            squares[4][0, 0] = 5;
            squares[4][1, 2] = 7;
            squares[4][2, 2] = 6;
            squares[5][0, 2] = 9;
            squares[5][2, 0] = 2;
            squares[6][1, 2] = 1;
            squares[6][2, 1] = 3;
            squares[7][0, 1] = 8;
            squares[7][1, 1] = 6;
            squares[7][2, 1] = 1;
            squares[7][2, 2] = 3;
            squares[8][0, 0] = 3;
            squares[8][0, 1] = 2;
            squares[8][2, 2] = 6;
        }
    }
}