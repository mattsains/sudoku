using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SudokuSolver
{
    public partial class SudokuSquare : UserControl
    {
        public SudokuSquare()
        {
            InitializeComponent();
            inputs = new List<TextBox>() { txt11, txt21, txt31, txt12, txt22, txt32, txt13, txt23, txt33 };
        }

        List<TextBox> inputs;

        /// <summary>
        /// Returns the number in any block
        /// </summary>
        /// <param name="x">x coordinate of the block</param>
        /// <param name="y">y coordinate of the block</param>
        /// <returns>The </returns>
        public byte this[int x, int y]
        {
            get
            {
                if (inputs[y * 3 + x].Text == "") return 0;
                else return byte.Parse(inputs[y * 3 + x].Text);
            }
            set
            {
                inputs[y * 3 + x].Text = value == 0 ? "" : value.ToString();
            }
        }
        /// <summary>
        /// Blanks out this square
        /// </summary>
        public void Reset()
        {
            foreach (TextBox t in inputs)
                t.Text = "";
        }

        private void txt_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            byte val;
            if (!byte.TryParse(((TextBox)sender).Text, out val) || val > 9 || val<1)
                ((TextBox)sender).Text = "";
        }
    }
}
