namespace SudokuSolver
{
    partial class SudokuSquare
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt11 = new System.Windows.Forms.TextBox();
            this.txt21 = new System.Windows.Forms.TextBox();
            this.txt31 = new System.Windows.Forms.TextBox();
            this.txt32 = new System.Windows.Forms.TextBox();
            this.txt22 = new System.Windows.Forms.TextBox();
            this.txt12 = new System.Windows.Forms.TextBox();
            this.txt33 = new System.Windows.Forms.TextBox();
            this.txt23 = new System.Windows.Forms.TextBox();
            this.txt13 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt11
            // 
            this.txt11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt11.Location = new System.Drawing.Point(0, 0);
            this.txt11.MaxLength = 1;
            this.txt11.Name = "txt11";
            this.txt11.Size = new System.Drawing.Size(35, 35);
            this.txt11.TabIndex = 0;
            this.txt11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt11.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txt11.Enter += new System.EventHandler(this.txt_Enter);
            // 
            // txt21
            // 
            this.txt21.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt21.Location = new System.Drawing.Point(41, 0);
            this.txt21.MaxLength = 1;
            this.txt21.Name = "txt21";
            this.txt21.Size = new System.Drawing.Size(35, 35);
            this.txt21.TabIndex = 1;
            this.txt21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt21.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txt21.Enter += new System.EventHandler(this.txt_Enter);
            // 
            // txt31
            // 
            this.txt31.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt31.Location = new System.Drawing.Point(82, 0);
            this.txt31.MaxLength = 1;
            this.txt31.Name = "txt31";
            this.txt31.Size = new System.Drawing.Size(35, 35);
            this.txt31.TabIndex = 2;
            this.txt31.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt31.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txt31.Enter += new System.EventHandler(this.txt_Enter);
            // 
            // txt32
            // 
            this.txt32.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt32.Location = new System.Drawing.Point(82, 41);
            this.txt32.MaxLength = 1;
            this.txt32.Name = "txt32";
            this.txt32.Size = new System.Drawing.Size(35, 35);
            this.txt32.TabIndex = 5;
            this.txt32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt32.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txt32.Enter += new System.EventHandler(this.txt_Enter);
            // 
            // txt22
            // 
            this.txt22.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt22.Location = new System.Drawing.Point(41, 41);
            this.txt22.MaxLength = 1;
            this.txt22.Name = "txt22";
            this.txt22.Size = new System.Drawing.Size(35, 35);
            this.txt22.TabIndex = 4;
            this.txt22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt22.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txt22.Enter += new System.EventHandler(this.txt_Enter);
            // 
            // txt12
            // 
            this.txt12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt12.Location = new System.Drawing.Point(0, 41);
            this.txt12.MaxLength = 1;
            this.txt12.Name = "txt12";
            this.txt12.Size = new System.Drawing.Size(35, 35);
            this.txt12.TabIndex = 3;
            this.txt12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt12.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txt12.Enter += new System.EventHandler(this.txt_Enter);
            // 
            // txt33
            // 
            this.txt33.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt33.Location = new System.Drawing.Point(82, 82);
            this.txt33.MaxLength = 1;
            this.txt33.Name = "txt33";
            this.txt33.Size = new System.Drawing.Size(35, 35);
            this.txt33.TabIndex = 8;
            this.txt33.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt33.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txt33.Enter += new System.EventHandler(this.txt_Enter);
            // 
            // txt23
            // 
            this.txt23.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt23.Location = new System.Drawing.Point(41, 82);
            this.txt23.MaxLength = 1;
            this.txt23.Name = "txt23";
            this.txt23.Size = new System.Drawing.Size(35, 35);
            this.txt23.TabIndex = 7;
            this.txt23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt23.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txt23.Enter += new System.EventHandler(this.txt_Enter);
            // 
            // txt13
            // 
            this.txt13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt13.Location = new System.Drawing.Point(0, 82);
            this.txt13.MaxLength = 1;
            this.txt13.Name = "txt13";
            this.txt13.Size = new System.Drawing.Size(35, 35);
            this.txt13.TabIndex = 6;
            this.txt13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt13.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txt13.Enter += new System.EventHandler(this.txt_Enter);
            // 
            // SudokuSquare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt33);
            this.Controls.Add(this.txt23);
            this.Controls.Add(this.txt13);
            this.Controls.Add(this.txt32);
            this.Controls.Add(this.txt22);
            this.Controls.Add(this.txt12);
            this.Controls.Add(this.txt31);
            this.Controls.Add(this.txt21);
            this.Controls.Add(this.txt11);
            this.Name = "SudokuSquare";
            this.Size = new System.Drawing.Size(117, 117);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt11;
        private System.Windows.Forms.TextBox txt21;
        private System.Windows.Forms.TextBox txt31;
        private System.Windows.Forms.TextBox txt32;
        private System.Windows.Forms.TextBox txt22;
        private System.Windows.Forms.TextBox txt12;
        private System.Windows.Forms.TextBox txt33;
        private System.Windows.Forms.TextBox txt23;
        private System.Windows.Forms.TextBox txt13;


    }
}
