namespace SudokuSolver
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSolve = new System.Windows.Forms.Button();
            this.sq33 = new SudokuSolver.SudokuSquare();
            this.sq23 = new SudokuSolver.SudokuSquare();
            this.sq13 = new SudokuSolver.SudokuSquare();
            this.sq32 = new SudokuSolver.SudokuSquare();
            this.sq22 = new SudokuSolver.SudokuSquare();
            this.sq12 = new SudokuSolver.SudokuSquare();
            this.sq31 = new SudokuSolver.SudokuSquare();
            this.sq21 = new SudokuSolver.SudokuSquare();
            this.sq11 = new SudokuSolver.SudokuSquare();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(216, 421);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSolve
            // 
            this.btnSolve.Location = new System.Drawing.Point(135, 421);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(75, 23);
            this.btnSolve.TabIndex = 9;
            this.btnSolve.Text = "Solve";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // sq33
            // 
            this.sq33.Location = new System.Drawing.Point(298, 298);
            this.sq33.Name = "sq33";
            this.sq33.Size = new System.Drawing.Size(117, 117);
            this.sq33.TabIndex = 8;
            // 
            // sq23
            // 
            this.sq23.Location = new System.Drawing.Point(155, 298);
            this.sq23.Name = "sq23";
            this.sq23.Size = new System.Drawing.Size(117, 117);
            this.sq23.TabIndex = 7;
            // 
            // sq13
            // 
            this.sq13.Location = new System.Drawing.Point(12, 298);
            this.sq13.Name = "sq13";
            this.sq13.Size = new System.Drawing.Size(117, 117);
            this.sq13.TabIndex = 6;
            // 
            // sq32
            // 
            this.sq32.Location = new System.Drawing.Point(298, 155);
            this.sq32.Name = "sq32";
            this.sq32.Size = new System.Drawing.Size(117, 117);
            this.sq32.TabIndex = 5;
            // 
            // sq22
            // 
            this.sq22.Location = new System.Drawing.Point(155, 155);
            this.sq22.Name = "sq22";
            this.sq22.Size = new System.Drawing.Size(117, 117);
            this.sq22.TabIndex = 4;
            // 
            // sq12
            // 
            this.sq12.Location = new System.Drawing.Point(12, 155);
            this.sq12.Name = "sq12";
            this.sq12.Size = new System.Drawing.Size(117, 117);
            this.sq12.TabIndex = 3;
            // 
            // sq31
            // 
            this.sq31.Location = new System.Drawing.Point(298, 12);
            this.sq31.Name = "sq31";
            this.sq31.Size = new System.Drawing.Size(117, 117);
            this.sq31.TabIndex = 2;
            // 
            // sq21
            // 
            this.sq21.Location = new System.Drawing.Point(155, 12);
            this.sq21.Name = "sq21";
            this.sq21.Size = new System.Drawing.Size(117, 117);
            this.sq21.TabIndex = 1;
            // 
            // sq11
            // 
            this.sq11.Location = new System.Drawing.Point(12, 12);
            this.sq11.Name = "sq11";
            this.sq11.Size = new System.Drawing.Size(117, 117);
            this.sq11.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 448);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.sq33);
            this.Controls.Add(this.sq23);
            this.Controls.Add(this.sq13);
            this.Controls.Add(this.sq32);
            this.Controls.Add(this.sq22);
            this.Controls.Add(this.sq12);
            this.Controls.Add(this.sq31);
            this.Controls.Add(this.sq21);
            this.Controls.Add(this.sq11);
            this.Name = "Form1";
            this.Text = "Sudoku Solver";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private SudokuSquare sq11;
        private SudokuSquare sq21;
        private SudokuSquare sq31;
        private SudokuSquare sq32;
        private SudokuSquare sq22;
        private SudokuSquare sq12;
        private SudokuSquare sq33;
        private SudokuSquare sq23;
        private SudokuSquare sq13;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSolve;
    }
}

