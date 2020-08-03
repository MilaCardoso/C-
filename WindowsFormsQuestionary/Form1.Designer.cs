namespace WindowsFormsQuestionary
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_start = new System.Windows.Forms.Button();
            this.txb_question = new System.Windows.Forms.TextBox();
            this.txb_answer = new System.Windows.Forms.TextBox();
            this.btn_finish = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbl_progress_bar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please answer the questions:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Question:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Answer:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(245, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Open File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(16, 53);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 4;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Visible = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // txb_question
            // 
            this.txb_question.Location = new System.Drawing.Point(93, 93);
            this.txb_question.Name = "txb_question";
            this.txb_question.ReadOnly = true;
            this.txb_question.Size = new System.Drawing.Size(630, 20);
            this.txb_question.TabIndex = 5;
            // 
            // txb_answer
            // 
            this.txb_answer.Location = new System.Drawing.Point(93, 128);
            this.txb_answer.Name = "txb_answer";
            this.txb_answer.Size = new System.Drawing.Size(630, 20);
            this.txb_answer.TabIndex = 6;
            this.txb_answer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_answer_KeyDown);
            // 
            // btn_finish
            // 
            this.btn_finish.Location = new System.Drawing.Point(622, 222);
            this.btn_finish.Name = "btn_finish";
            this.btn_finish.Size = new System.Drawing.Size(75, 23);
            this.btn_finish.TabIndex = 7;
            this.btn_finish.Text = "Finish";
            this.btn_finish.UseVisualStyleBackColor = true;
            this.btn_finish.Visible = false;
            this.btn_finish.Click += new System.EventHandler(this.btn_finish_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(71, 222);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(269, 23);
            this.progressBar1.TabIndex = 8;
            // 
            // lbl_progress_bar
            // 
            this.lbl_progress_bar.AutoSize = true;
            this.lbl_progress_bar.Location = new System.Drawing.Point(12, 227);
            this.lbl_progress_bar.Name = "lbl_progress_bar";
            this.lbl_progress_bar.Size = new System.Drawing.Size(51, 13);
            this.lbl_progress_bar.TabIndex = 9;
            this.lbl_progress_bar.Text = "Progress:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_progress_bar);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btn_finish);
            this.Controls.Add(this.txb_answer);
            this.Controls.Add(this.txb_question);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.TextBox txb_question;
        private System.Windows.Forms.TextBox txb_answer;
        private System.Windows.Forms.Button btn_finish;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lbl_progress_bar;
    }
}

