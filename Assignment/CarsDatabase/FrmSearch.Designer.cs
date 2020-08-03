namespace Assignment
{
    partial class FrmSearch
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
            this.panelSearch = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.panelSearchFilter = new System.Windows.Forms.Panel();
            this.cboValueAvailable = new System.Windows.Forms.ComboBox();
            this.cboOperator = new System.Windows.Forms.ComboBox();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.cboField = new System.Windows.Forms.ComboBox();
            this.labelValue = new System.Windows.Forms.Label();
            this.labelOperator = new System.Windows.Forms.Label();
            this.labelField = new System.Windows.Forms.Label();
            this.panelSearchDtGr = new System.Windows.Forms.Panel();
            this.dataGridViewSearch = new System.Windows.Forms.DataGridView();
            this.panelSearch.SuspendLayout();
            this.panelSearchFilter.SuspendLayout();
            this.panelSearchDtGr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.btnClose);
            this.panelSearch.Controls.Add(this.btnRun);
            this.panelSearch.Controls.Add(this.panelSearchFilter);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(0, 0);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(800, 172);
            this.panelSearch.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(408, 102);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 46);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(408, 56);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(90, 46);
            this.btnRun.TabIndex = 5;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // panelSearchFilter
            // 
            this.panelSearchFilter.Controls.Add(this.cboValueAvailable);
            this.panelSearchFilter.Controls.Add(this.cboOperator);
            this.panelSearchFilter.Controls.Add(this.textBoxValue);
            this.panelSearchFilter.Controls.Add(this.cboField);
            this.panelSearchFilter.Controls.Add(this.labelValue);
            this.panelSearchFilter.Controls.Add(this.labelOperator);
            this.panelSearchFilter.Controls.Add(this.labelField);
            this.panelSearchFilter.Location = new System.Drawing.Point(57, 56);
            this.panelSearchFilter.Name = "panelSearchFilter";
            this.panelSearchFilter.Size = new System.Drawing.Size(320, 81);
            this.panelSearchFilter.TabIndex = 0;
            // 
            // cboValueAvailable
            // 
            this.cboValueAvailable.FormattingEnabled = true;
            this.cboValueAvailable.Location = new System.Drawing.Point(214, 46);
            this.cboValueAvailable.Name = "cboValueAvailable";
            this.cboValueAvailable.Size = new System.Drawing.Size(100, 21);
            this.cboValueAvailable.TabIndex = 4;
            this.cboValueAvailable.Visible = false;
            // 
            // cboOperator
            // 
            this.cboOperator.FormattingEnabled = true;
            this.cboOperator.Location = new System.Drawing.Point(134, 45);
            this.cboOperator.Name = "cboOperator";
            this.cboOperator.Size = new System.Drawing.Size(65, 21);
            this.cboOperator.TabIndex = 2;
            // 
            // textBoxValue
            // 
            this.textBoxValue.Location = new System.Drawing.Point(214, 46);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(100, 20);
            this.textBoxValue.TabIndex = 3;
            // 
            // cboField
            // 
            this.cboField.FormattingEnabled = true;
            this.cboField.Location = new System.Drawing.Point(12, 46);
            this.cboField.Name = "cboField";
            this.cboField.Size = new System.Drawing.Size(101, 21);
            this.cboField.TabIndex = 1;
            this.cboField.SelectedIndexChanged += new System.EventHandler(this.cboField_SelectedIndexChanged);
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Location = new System.Drawing.Point(211, 20);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(34, 13);
            this.labelValue.TabIndex = 2;
            this.labelValue.Text = "Value";
            // 
            // labelOperator
            // 
            this.labelOperator.AutoSize = true;
            this.labelOperator.Location = new System.Drawing.Point(133, 20);
            this.labelOperator.Name = "labelOperator";
            this.labelOperator.Size = new System.Drawing.Size(48, 13);
            this.labelOperator.TabIndex = 1;
            this.labelOperator.Text = "Operator";
            // 
            // labelField
            // 
            this.labelField.AutoSize = true;
            this.labelField.Location = new System.Drawing.Point(20, 20);
            this.labelField.Name = "labelField";
            this.labelField.Size = new System.Drawing.Size(29, 13);
            this.labelField.TabIndex = 0;
            this.labelField.Text = "Field";
            // 
            // panelSearchDtGr
            // 
            this.panelSearchDtGr.Controls.Add(this.dataGridViewSearch);
            this.panelSearchDtGr.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSearchDtGr.Location = new System.Drawing.Point(0, 178);
            this.panelSearchDtGr.Name = "panelSearchDtGr";
            this.panelSearchDtGr.Size = new System.Drawing.Size(800, 272);
            this.panelSearchDtGr.TabIndex = 1;
            // 
            // dataGridViewSearch
            // 
            this.dataGridViewSearch.AllowDrop = true;
            this.dataGridViewSearch.AllowUserToOrderColumns = true;
            this.dataGridViewSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearch.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSearch.Name = "dataGridViewSearch";
            this.dataGridViewSearch.ReadOnly = true;
            this.dataGridViewSearch.Size = new System.Drawing.Size(800, 272);
            this.dataGridViewSearch.TabIndex = 0;
            // 
            // FrmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelSearchDtGr);
            this.Controls.Add(this.panelSearch);
            this.Name = "FrmSearch";
            this.Text = "Task A Search - Camila Cardoso - 13/12/2019";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSearch_FormClosing);
            this.Load += new System.EventHandler(this.FrmSearch_Load);
            this.panelSearch.ResumeLayout(false);
            this.panelSearchFilter.ResumeLayout(false);
            this.panelSearchFilter.PerformLayout();
            this.panelSearchDtGr.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Panel panelSearchDtGr;
        private System.Windows.Forms.DataGridView dataGridViewSearch;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Panel panelSearchFilter;
        private System.Windows.Forms.ComboBox cboField;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.Label labelOperator;
        private System.Windows.Forms.Label labelField;
        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.ComboBox cboOperator;
        private System.Windows.Forms.ComboBox cboValueAvailable;
    }
}