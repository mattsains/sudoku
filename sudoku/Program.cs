using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sudoku
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              Sudoku s=new Sudoku(new byte[]{0,0,0, 0,0,0, 0,0,0,
                                             0,0,0, 0,0,0, 0,0,0,
                                             0,0,0, 0,0,0, 0,0,0,
                                      
                                             0,0,0, 0,0,0, 0,0,0,
                                             0,0,0, 0,0,0, 0,0,0,
                                             0,0,0, 0,0,0, 0,0,0,
                                      
                                             0,0,0, 0,0,0, 0,0,0,
                                             0,0,0, 0,0,0, 0,0,0,
                                             0,0,0, 0,0,0, 0,0,0});
             */

            Sudoku s = new Sudoku(new byte[]{8,0,0, 0,0,0, 0,0,0, //one of the hardest sudokus - unsolvable by deductive methods
                                             0,0,3, 6,0,0, 0,0,0,
                                             0,7,0, 0,9,0, 2,0,0,
                                       
                                             0,5,0, 0,0,7, 0,0,0,
                                             0,0,0, 0,4,5, 7,0,0,
                                             0,0,0, 1,0,0, 0,3,0,
                                       
                                             0,0,1, 0,0,0, 0,6,8,
                                             0,0,8, 5,0,0, 0,1,0,
                                             0,9,0, 0,0,0, 4,0,0});
            Console.WriteLine(s);
            Console.ReadLine();
            Console.Clear();
            Solve(s);
            Console.WriteLine(s);
            Console.ReadLine();
        }
        public static bool Solve(Sudoku s, int begin = 0)
        {
            while (s[begin] != 0) begin++; //skip to the next blank space

            List<byte> possible = s.ValidNums(begin); //get all possibilities for this space

            foreach (byte p in possible)
            {
                s[begin] = p;
                if (s.Complete) return true;
                else Solve(s, begin + 1);
                if (s.Complete) return true;
            }
            // If execution gets here, there is no solution
            s[begin] = 0; //set the current space back to blank
            return false;
        }
    }
}