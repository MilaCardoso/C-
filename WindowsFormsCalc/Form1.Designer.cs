namespace WindowsFormsCalc
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
            this.n1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.n2 = new System.Windows.Forms.Button();
            this.n3 = new System.Windows.Forms.Button();
            this.n4 = new System.Windows.Forms.Button();
            this.n6 = new System.Windows.Forms.Button();
            this.n8 = new System.Windows.Forms.Button();
            this.n9 = new System.Windows.Forms.Button();
            this.n5 = new System.Windows.Forms.Button();
            this.n7 = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // n1
            // 
            this.n1.Location = new System.Drawing.Point(18, 85);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(55, 45);
            this.n1.TabIndex = 0;
            this.n1.Text = "1";
            this.n1.UseVisualStyleBackColor = true;
            this.n1.Click += new System.EventHandler(this.n1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // n2
            // 
            this.n2.Location = new System.Drawing.Point(79, 85);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(55, 45);
            this.n2.TabIndex = 2;
            this.n2.Text = "2";
            this.n2.UseVisualStyleBackColor = true;
            this.n2.Click += new System.EventHandler(this.n2_Click);
            // 
            // n3
            // 
            this.n3.Location = new System.Drawing.Point(140, 85);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(55, 45);
            this.n3.TabIndex = 3;
            this.n3.Text = "3";
            this.n3.UseVisualStyleBackColor = true;
            // 
            // n4
            // 
            this.n4.Location = new System.Drawing.Point(18, 136);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(55, 45);
            this.n4.TabIndex = 4;
            this.n4.Text = "4";
            this.n4.UseVisualStyleBackColor = true;
            // 
            // n6
            // 
            this.n6.Location = new System.Drawing.Point(140, 136);
            this.n6.Name = "n6";
            this.n6.Size = new System.Drawing.Size(55, 45);
            this.n6.TabIndex = 6;
            this.n6.Text = "6";
            this.n6.UseVisualStyleBackColor = true;
            // 
            // n8
            // 
            this.n8.Location = new System.Drawing.Point(79, 187);
            this.n8.Name = "n8";
            this.n8.Size = new System.Drawing.Size(55, 45);
            this.n8.TabIndex = 8;
            this.n8.Text = "8";
            this.n8.UseVisualStyleBackColor = true;
            // 
            // n9
            // 
            this.n9.Location = new System.Drawing.Point(140, 187);
            this.n9.Name = "n9";
            this.n9.Size = new System.Drawing.Size(55, 45);
            this.n9.TabIndex = 9;
            this.n9.Text = "9";
            this.n9.UseVisualStyleBackColor = true;
            // 
            // n5
            // 
            this.n5.Location = new System.Drawing.Point(79, 136);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(55, 45);
            this.n5.TabIndex = 10;
            this.n5.Text = "5";
            this.n5.UseVisualStyleBackColor = true;
            // 
            // n7
            // 
            this.n7.Location = new System.Drawing.Point(18, 187);
            this.n7.Name = "n7";
            this.n7.Size = new System.Drawing.Size(55, 45);
            this.n7.TabIndex = 11;
            this.n7.Text = "7";
            this.n7.UseVisualStyleBackColor = true;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(201, 85);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(55, 45);
            this.add.TabIndex = 12;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(201, 136);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(55, 45);
            this.minus.TabIndex = 13;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(201, 187);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(55, 45);
            this.multiply.TabIndex = 14;
            this.multiply.Text = "X";
            this.multiply.UseVisualStyleBackColor = true;
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(201, 238);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(55, 45);
            this.divide.TabIndex = 15;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            // 
            // C
            // 
            this.C.Location = new System.Drawing.Point(140, 238);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(55, 45);
            this.C.TabIndex = 16;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = true;
            // 
            // equal
            // 
            this.equal.Location = new System.Drawing.Point(18, 238);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(116, 45);
            this.equal.TabIndex = 17;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 315);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.C);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.add);
            this.Controls.Add(this.n7);
            this.Controls.Add(this.n5);
            this.Controls.Add(this.n9);
            this.Controls.Add(this.n8);
            this.Controls.Add(this.n6);
            this.Controls.Add(this.n4);
            this.Controls.Add(this.n3);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.n1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button n1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button n2;
        private System.Windows.Forms.Button n3;
        private System.Windows.Forms.Button n4;
        private System.Windows.Forms.Button n6;
        private System.Windows.Forms.Button n8;
        private System.Windows.Forms.Button n9;
        private System.Windows.Forms.Button n5;
        private System.Windows.Forms.Button n7;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button C;
        private System.Windows.Forms.Button equal;
    }
}

