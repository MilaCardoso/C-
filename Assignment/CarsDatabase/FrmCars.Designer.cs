namespace Assignment
{
    partial class FrmCars
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
            this.components = new System.ComponentModel.Container();
            this.lblBowmanCarHire = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.textBoxPagination = new System.Windows.Forms.TextBox();
            this.lblVehicleRegNo = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblEngineSize = new System.Windows.Forms.Label();
            this.lblDateRegistered = new System.Windows.Forms.Label();
            this.lblRentalPerDay = new System.Windows.Forms.Label();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.textBoxVehicleRegNo = new System.Windows.Forms.TextBox();
            this.textBoxMake = new System.Windows.Forms.TextBox();
            this.textBoxEngineSize = new System.Windows.Forms.TextBox();
            this.textBoxDateRegistered = new System.Windows.Forms.TextBox();
            this.textBoxRentalPerDay = new System.Windows.Forms.TextBox();
            this.checkBoxAvailable = new System.Windows.Forms.CheckBox();
            this.colorDialogDelete = new System.Windows.Forms.ColorDialog();
            this.toolTipFrmCars = new System.Windows.Forms.ToolTip(this.components);
            this.btnAddInsert = new System.Windows.Forms.Button();
            this.btnCancelAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBowmanCarHire
            // 
            this.lblBowmanCarHire.AutoSize = true;
            this.lblBowmanCarHire.BackColor = System.Drawing.Color.Transparent;
            this.lblBowmanCarHire.Font = new System.Drawing.Font("Lucida Sans", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBowmanCarHire.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblBowmanCarHire.Location = new System.Drawing.Point(266, 39);
            this.lblBowmanCarHire.Name = "lblBowmanCarHire";
            this.lblBowmanCarHire.Size = new System.Drawing.Size(281, 33);
            this.lblBowmanCarHire.TabIndex = 0;
            this.lblBowmanCarHire.Text = "Bowman Car Hire";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Black;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUpdate.Location = new System.Drawing.Point(655, 82);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(85, 46);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.toolTipFrmCars.SetToolTip(this.btnUpdate, "Do you want to Update the record?");
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Black;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAdd.Location = new System.Drawing.Point(655, 134);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 46);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.toolTipFrmCars.SetToolTip(this.btnAdd, "Do you want to Add a new record?");
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Black;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDelete.Location = new System.Drawing.Point(655, 186);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 46);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.toolTipFrmCars.SetToolTip(this.btnDelete, "Do you want to Delete the record?");
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Black;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSearch.Location = new System.Drawing.Point(655, 238);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 46);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Search";
            this.toolTipFrmCars.SetToolTip(this.btnSearch, "Do you want to Search records?");
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Black;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.Location = new System.Drawing.Point(655, 290);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 46);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.toolTipFrmCars.SetToolTip(this.btnCancel, "Do you want to Cancel?");
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExit.Location = new System.Drawing.Point(655, 342);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 46);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Exit";
            this.toolTipFrmCars.SetToolTip(this.btnExit, "Do you want to exit the program?");
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.Black;
            this.btnFirst.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFirst.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnFirst.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFirst.Location = new System.Drawing.Point(224, 406);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(66, 25);
            this.btnFirst.TabIndex = 7;
            this.btnFirst.Text = "First";
            this.toolTipFrmCars.SetToolTip(this.btnFirst, "Do you want to go to the first record?");
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.Black;
            this.btnPrevious.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPrevious.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPrevious.Location = new System.Drawing.Point(296, 406);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(66, 25);
            this.btnPrevious.TabIndex = 8;
            this.btnPrevious.Text = "Previous";
            this.toolTipFrmCars.SetToolTip(this.btnPrevious, "Do you want to return a record?");
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.Black;
            this.btnLast.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLast.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnLast.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLast.Location = new System.Drawing.Point(503, 406);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(66, 25);
            this.btnLast.TabIndex = 11;
            this.btnLast.Text = "Last";
            this.toolTipFrmCars.SetToolTip(this.btnLast, "Do you want to go to the last record?");
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Black;
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNext.Location = new System.Drawing.Point(431, 407);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(66, 24);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = "Next";
            this.toolTipFrmCars.SetToolTip(this.btnNext, "Do you want to go to the next record?");
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // textBoxPagination
            // 
            this.textBoxPagination.Location = new System.Drawing.Point(368, 410);
            this.textBoxPagination.Name = "textBoxPagination";
            this.textBoxPagination.Size = new System.Drawing.Size(57, 20);
            this.textBoxPagination.TabIndex = 9;
            this.textBoxPagination.Text = "1 of 15";
            this.textBoxPagination.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipFrmCars.SetToolTip(this.textBoxPagination, "Number of the records");
            // 
            // lblVehicleRegNo
            // 
            this.lblVehicleRegNo.AutoSize = true;
            this.lblVehicleRegNo.BackColor = System.Drawing.Color.Transparent;
            this.lblVehicleRegNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleRegNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblVehicleRegNo.Location = new System.Drawing.Point(132, 134);
            this.lblVehicleRegNo.Name = "lblVehicleRegNo";
            this.lblVehicleRegNo.Size = new System.Drawing.Size(197, 16);
            this.lblVehicleRegNo.TabIndex = 12;
            this.lblVehicleRegNo.Text = "Vehicle registration number";
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.BackColor = System.Drawing.Color.Transparent;
            this.lblMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMake.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblMake.Location = new System.Drawing.Point(283, 166);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(46, 16);
            this.lblMake.TabIndex = 13;
            this.lblMake.Text = "Make";
            // 
            // lblEngineSize
            // 
            this.lblEngineSize.AutoSize = true;
            this.lblEngineSize.BackColor = System.Drawing.Color.Transparent;
            this.lblEngineSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEngineSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblEngineSize.Location = new System.Drawing.Point(239, 195);
            this.lblEngineSize.Name = "lblEngineSize";
            this.lblEngineSize.Size = new System.Drawing.Size(90, 16);
            this.lblEngineSize.TabIndex = 14;
            this.lblEngineSize.Text = "Engine Size";
            // 
            // lblDateRegistered
            // 
            this.lblDateRegistered.AutoSize = true;
            this.lblDateRegistered.BackColor = System.Drawing.Color.Transparent;
            this.lblDateRegistered.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateRegistered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblDateRegistered.Location = new System.Drawing.Point(207, 231);
            this.lblDateRegistered.Name = "lblDateRegistered";
            this.lblDateRegistered.Size = new System.Drawing.Size(122, 16);
            this.lblDateRegistered.TabIndex = 15;
            this.lblDateRegistered.Text = "Date Registered";
            // 
            // lblRentalPerDay
            // 
            this.lblRentalPerDay.AutoSize = true;
            this.lblRentalPerDay.BackColor = System.Drawing.Color.Transparent;
            this.lblRentalPerDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentalPerDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblRentalPerDay.Location = new System.Drawing.Point(216, 268);
            this.lblRentalPerDay.Name = "lblRentalPerDay";
            this.lblRentalPerDay.Size = new System.Drawing.Size(113, 16);
            this.lblRentalPerDay.TabIndex = 16;
            this.lblRentalPerDay.Text = "Rental Per Day";
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.BackColor = System.Drawing.Color.Transparent;
            this.lblAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblAvailable.Location = new System.Drawing.Point(255, 299);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(74, 16);
            this.lblAvailable.TabIndex = 17;
            this.lblAvailable.Text = "Available";
            // 
            // textBoxVehicleRegNo
            // 
            this.textBoxVehicleRegNo.Location = new System.Drawing.Point(345, 130);
            this.textBoxVehicleRegNo.Name = "textBoxVehicleRegNo";
            this.textBoxVehicleRegNo.Size = new System.Drawing.Size(102, 20);
            this.textBoxVehicleRegNo.TabIndex = 1;
            this.toolTipFrmCars.SetToolTip(this.textBoxVehicleRegNo, "Vehicle number registration should be unique");
            // 
            // textBoxMake
            // 
            this.textBoxMake.Location = new System.Drawing.Point(345, 162);
            this.textBoxMake.Name = "textBoxMake";
            this.textBoxMake.Size = new System.Drawing.Size(246, 20);
            this.textBoxMake.TabIndex = 2;
            this.toolTipFrmCars.SetToolTip(this.textBoxMake, "Make of the vehicle");
            // 
            // textBoxEngineSize
            // 
            this.textBoxEngineSize.Location = new System.Drawing.Point(345, 195);
            this.textBoxEngineSize.Name = "textBoxEngineSize";
            this.textBoxEngineSize.Size = new System.Drawing.Size(114, 20);
            this.textBoxEngineSize.TabIndex = 3;
            this.toolTipFrmCars.SetToolTip(this.textBoxEngineSize, "Size of the Engine");
            // 
            // textBoxDateRegistered
            // 
            this.textBoxDateRegistered.Location = new System.Drawing.Point(345, 227);
            this.textBoxDateRegistered.Name = "textBoxDateRegistered";
            this.textBoxDateRegistered.Size = new System.Drawing.Size(91, 20);
            this.textBoxDateRegistered.TabIndex = 4;
            this.toolTipFrmCars.SetToolTip(this.textBoxDateRegistered, "Date should have this format: dd/MM/yyyy");
            // 
            // textBoxRentalPerDay
            // 
            this.textBoxRentalPerDay.Location = new System.Drawing.Point(345, 262);
            this.textBoxRentalPerDay.Name = "textBoxRentalPerDay";
            this.textBoxRentalPerDay.Size = new System.Drawing.Size(91, 20);
            this.textBoxRentalPerDay.TabIndex = 5;
            this.toolTipFrmCars.SetToolTip(this.textBoxRentalPerDay, "Rental per day should be higher than 0");
            // 
            // checkBoxAvailable
            // 
            this.checkBoxAvailable.AutoSize = true;
            this.checkBoxAvailable.Location = new System.Drawing.Point(345, 301);
            this.checkBoxAvailable.Name = "checkBoxAvailable";
            this.checkBoxAvailable.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAvailable.TabIndex = 6;
            this.toolTipFrmCars.SetToolTip(this.checkBoxAvailable, "If vehicle is available mark in checkbox");
            this.checkBoxAvailable.UseVisualStyleBackColor = true;
            // 
            // btnAddInsert
            // 
            this.btnAddInsert.BackColor = System.Drawing.Color.Black;
            this.btnAddInsert.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddInsert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnAddInsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddInsert.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddInsert.Location = new System.Drawing.Point(351, 355);
            this.btnAddInsert.Name = "btnAddInsert";
            this.btnAddInsert.Size = new System.Drawing.Size(85, 46);
            this.btnAddInsert.TabIndex = 18;
            this.btnAddInsert.Text = "Add";
            this.toolTipFrmCars.SetToolTip(this.btnAddInsert, "Do you want to Add a new record?");
            this.btnAddInsert.UseVisualStyleBackColor = false;
            this.btnAddInsert.Visible = false;
            this.btnAddInsert.Click += new System.EventHandler(this.btnAddInsert_Click);
            // 
            // btnCancelAdd
            // 
            this.btnCancelAdd.BackColor = System.Drawing.Color.Black;
            this.btnCancelAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancelAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnCancelAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancelAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAdd.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCancelAdd.Location = new System.Drawing.Point(462, 355);
            this.btnCancelAdd.Name = "btnCancelAdd";
            this.btnCancelAdd.Size = new System.Drawing.Size(85, 46);
            this.btnCancelAdd.TabIndex = 19;
            this.btnCancelAdd.Text = "Cancel";
            this.toolTipFrmCars.SetToolTip(this.btnCancelAdd, "Do you want to Cancel?");
            this.btnCancelAdd.UseVisualStyleBackColor = false;
            this.btnCancelAdd.Visible = false;
            this.btnCancelAdd.Click += new System.EventHandler(this.btnCancelAdd_Click);
            // 
            // FrmCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Assignment.Properties.Resources.peter_broomfield_m3m_lnR90uM_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelAdd);
            this.Controls.Add(this.btnAddInsert);
            this.Controls.Add(this.checkBoxAvailable);
            this.Controls.Add(this.textBoxRentalPerDay);
            this.Controls.Add(this.textBoxDateRegistered);
            this.Controls.Add(this.textBoxEngineSize);
            this.Controls.Add(this.textBoxMake);
            this.Controls.Add(this.textBoxVehicleRegNo);
            this.Controls.Add(this.lblAvailable);
            this.Controls.Add(this.lblRentalPerDay);
            this.Controls.Add(this.lblDateRegistered);
            this.Controls.Add(this.lblEngineSize);
            this.Controls.Add(this.lblMake);
            this.Controls.Add(this.lblVehicleRegNo);
            this.Controls.Add(this.textBoxPagination);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblBowmanCarHire);
            this.Name = "FrmCars";
            this.Text = "Task A - Camila Cardoso - 13/12/2019";
            this.Load += new System.EventHandler(this.FrmTaskA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBowmanCarHire;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox textBoxPagination;
        private System.Windows.Forms.Label lblVehicleRegNo;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblEngineSize;
        private System.Windows.Forms.Label lblDateRegistered;
        private System.Windows.Forms.Label lblRentalPerDay;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.TextBox textBoxVehicleRegNo;
        private System.Windows.Forms.TextBox textBoxMake;
        private System.Windows.Forms.TextBox textBoxEngineSize;
        private System.Windows.Forms.TextBox textBoxDateRegistered;
        private System.Windows.Forms.TextBox textBoxRentalPerDay;
        private System.Windows.Forms.CheckBox checkBoxAvailable;
        private System.Windows.Forms.ColorDialog colorDialogDelete;
        private System.Windows.Forms.ToolTip toolTipFrmCars;
        private System.Windows.Forms.Button btnAddInsert;
        private System.Windows.Forms.Button btnCancelAdd;
    }
}

