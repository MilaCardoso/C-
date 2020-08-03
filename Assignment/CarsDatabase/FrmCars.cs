using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Globalization;
using System.Text.RegularExpressions;



namespace Assignment
{
    public partial class FrmCars : Form
    {
     
        public SQLiteConnection conn;
        private DataTable dataTable;
        private int currentPage = 1;
        private int totalPages;
        private bool checkUpdate = false;
        private bool cancelButton = false;
        public FrmCars()
        {
            CreateConnection();
            InitializeComponent();
        }

        private void CreateConnection()
        {
            string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string databaseName = "/hire.db";
            conn = new SQLiteConnection("Data Source= "+projectPath +databaseName);
        }

        private void FrmTaskA_Load(object sender, EventArgs e)
        {
            FetchRecords();

            FetchRecordByPage(currentPage);
        }

        public void FetchRecords()
        {
            try
            {
                string mySQL = $@"SELECT * 
                    FROM 
                  tblCar ";

                conn.Open();
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(mySQL, conn);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataAdapter.Dispose();
                conn.Close();

                totalPages = dataTable.Rows.Count;

                UpdatePagination();
            } catch
            {
                MessageBox.Show("Oops! Something went wrong! \n Help us improve your experience by sending an error report");
            }
        }
        private void FetchRecordByPage(int recornNumber)
        {
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                DataRow row = dataTable.Rows[i];

                if (recornNumber == i + 1)
                {
                    textBoxVehicleRegNo.Text   = row["VehicleRegNo"].ToString();
                    textBoxMake.Text           = row["Make"].ToString();
                    textBoxEngineSize.Text     = row["EngineSize"].ToString();                  

                    var date = row["DateRegistered"].ToString();
                    var parsedDate = DateTime.ParseExact(date, "yyyy-MM-dd", 
                                     System.Globalization.CultureInfo.InvariantCulture);
                    var formattedDate = parsedDate.ToString("dd/MM/yyyy", 
                                        System.Globalization.CultureInfo.InvariantCulture);

                    textBoxDateRegistered.Text = formattedDate.ToString();

                    textBoxRentalPerDay.Text = "\u20AC" + row["RentalPerDay"].ToString();

                    if (row["Available"].ToString() == "1")
                    {
                        checkBoxAvailable.Checked = true;
                    }
                    else
                    {
                        checkBoxAvailable.Checked = false;
                    }
                    break;
                }
            }
        }
        private void btnFirst_Click(object sender, EventArgs e)
        {
            currentPage = 1;

            FetchRecordByPage(currentPage);

            UpdatePagination();
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage = currentPage - 1;

                FetchRecordByPage(currentPage);

                UpdatePagination();
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage = currentPage + 1;

                FetchRecordByPage(currentPage);

                UpdatePagination();
            }
        }
        private void btnLast_Click(object sender, EventArgs e)
        {
            currentPage = totalPages;

            FetchRecordByPage(currentPage);

            UpdatePagination();
        }
        private void UpdatePagination()
        {
            textBoxPagination.Text = (currentPage + " of " + totalPages);
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateRecord();
        }
        private void UpdateRecord()
        {
            checkUpdate = true;

            if (CheckFields() && !cancelButton)
            {
                int iCheckBoxAvailable = 0;

                if (checkBoxAvailable.Checked)
                {
                    iCheckBoxAvailable = 1;
                }

                try
                {
                    string formattedDate = FormatDateToDataBase(textBoxDateRegistered.Text);

                    string mySQL = $@"UPDATE  
                          tblCar 
                        SET Make                = '{textBoxMake.Text}',
                      EngineSize                = '{textBoxEngineSize.Text}',
                  DateRegistered                = '{formattedDate}',
                    RentalPerDay                = '{Double.Parse(textBoxRentalPerDay.Text.Replace("€", ""))}',
                       Available                = '{iCheckBoxAvailable}'
                           WHERE   VehicleRegNo = '{textBoxVehicleRegNo.Text}' ";

                    conn.Open();
                    SQLiteCommand sqlUpd = new SQLiteCommand(mySQL, conn);
                    sqlUpd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Record Updated!");

                    TextBoxOriginalColor();

                    FetchRecords();
                    FetchRecordByPage(currentPage);
                    UpdatePagination();
                } catch
                {
                    MessageBox.Show("Oops! Something went wrong! \n Help us improve your experience by sending an error report");
                }
            }
        }

        private void TextBoxOriginalColor()
        {
            textBoxVehicleRegNo.BackColor   = Color.White;
            textBoxMake.BackColor           = Color.White;
            textBoxEngineSize.BackColor     = Color.White;
            textBoxDateRegistered.BackColor = Color.White;
            textBoxRentalPerDay.BackColor   = Color.White;
        }

        private void AddMode(bool isAdd)
        {
            CleanForm();
            btnUpdate.Visible         = !isAdd;
            btnAdd.Visible            = !isAdd;
            btnDelete.Visible         = !isAdd;
            btnSearch.Visible         = !isAdd;
            btnCancel.Visible         = !isAdd;
            btnExit.Visible           = !isAdd;
            btnFirst.Visible          = !isAdd;
            btnPrevious.Visible       = !isAdd;
            textBoxPagination.Visible = !isAdd;
            btnNext.Visible           = !isAdd;
            btnLast.Visible           = !isAdd;
            btnCancelAdd.Visible      = isAdd;
            btnAddInsert.Visible      = isAdd;
        }

        private void CleanForm()
        {
            textBoxVehicleRegNo.Text   = "";
            textBoxMake.Text           = "";
            textBoxEngineSize.Text     = "";
            textBoxDateRegistered.Text = "";
            textBoxRentalPerDay.Text   = "";
            checkBoxAvailable.Checked  = false;
            textBoxVehicleRegNo.Focus();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddMode(true);
        }
        private void btnAddInsert_Click(object sender, EventArgs e)
        {
            if (CheckFields() && !cancelButton)
            {
                int iCheckBoxAvailable = 0;

                if (checkBoxAvailable.Checked)
                {
                    iCheckBoxAvailable = 1;
                }

                try
                {
                    string formattedDate = FormatDateToDataBase(textBoxDateRegistered.Text);

                    string mySQL = $@"INSERT 
                        INTO    
                      tblCar   ('VehicleRegNo',
                                'Make',
                                'EngineSize', 
                                'DateRegistered', 
                                'RentalPerDay', 
                                'Available')
                      VALUES   ('{textBoxVehicleRegNo.Text}',
                                '{textBoxMake.Text}',
                                '{textBoxEngineSize.Text}',
                                '{formattedDate}',
                                '{Double.Parse(textBoxRentalPerDay.Text.Replace("€", ""))}',
                                '{iCheckBoxAvailable}')";

                    conn.Open();
                    SQLiteCommand sqlAdd = new SQLiteCommand(mySQL, conn);
                    sqlAdd.ExecuteNonQuery();
                    conn.Close();

                    textBoxVehicleRegNo.BackColor = Color.White;
                    textBoxMake.BackColor = Color.White;
                    textBoxEngineSize.BackColor = Color.White;
                    textBoxDateRegistered.BackColor = Color.White;
                    textBoxRentalPerDay.BackColor = Color.White;

                    MessageBox.Show("Record added!");

                    AddMode(false);
                    FetchRecords();
                    currentPage = totalPages;
                    FetchRecordByPage(currentPage);
                    UpdatePagination();
                } catch
                {
                    MessageBox.Show("Oops! Something went wrong! \n Help us improve your experience by sending an error report");
                }
            }
        }
        private bool CheckFields()
        {
            if (textBoxVehicleRegNo.Text == "")
            {
                textBoxVehicleRegNo.BackColor = Color.Red;
                MessageBox.Show("Vehicle registration number is required!");
                return false;
            } else
            { if (!checkUpdate)
                {
                    try
                    {
                        string mySQL = $@"SELECT *                   
                                FROM 
                              tblCar
                               WHERE   VehicleRegNo =  '{textBoxVehicleRegNo.Text}'";

                        conn.Open();
                        SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(mySQL, conn);
                        DataSet dataSet = new DataSet();
                        dataAdapter.Fill(dataSet);
                        dataAdapter.Dispose();
                        conn.Close();

                        int i = dataSet.Tables[0].Rows.Count;
                        if (i > 0)
                        {
                            textBoxVehicleRegNo.BackColor = Color.Red;
                            MessageBox.Show("Vehicle registration already exist!");
                            return false;
                        }
                    } catch
                    {
                        MessageBox.Show("Oops! Something went wrong! \n Help us improve your experience by sending an error report");
                    }
                }
              }

            if (textBoxMake.Text == "")
            {
                textBoxMake.BackColor = Color.Red;
                MessageBox.Show("Make is required!");
                return false;
            }

            if (textBoxEngineSize.Text == "")
            {
                textBoxEngineSize.BackColor = Color.Red;
                MessageBox.Show("Engine Size is required!");
                return false;
            }

            Regex regex = new Regex(@"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$");

            bool isValid = regex.IsMatch(textBoxDateRegistered.Text.Trim());

            DateTime dt;
            isValid = DateTime.TryParseExact(textBoxDateRegistered.Text, "dd/MM/yyyy", new CultureInfo("en-GB"), DateTimeStyles.None, out dt);

            if (!isValid)
            {
                textBoxDateRegistered.BackColor = Color.Red;
                MessageBox.Show("Date Registered invalid!");
                return false;
            }

            var rentalPerDayText = textBoxRentalPerDay.Text.Replace("€", "");

            Double distance;
            if (!Double.TryParse(rentalPerDayText, out distance))
            {
                textBoxRentalPerDay.BackColor = Color.Red;
                MessageBox.Show("Rental Per Day is a numeric field!");
                return false;
            }

            if (distance == 0)
            {
                textBoxRentalPerDay.BackColor = Color.Red;
                MessageBox.Show("Rental Per Day should be higher than 0!");
                return false;
            }

            return true;
        }

        private String FormatDateToDataBase(string dateTextBox)
        {
            var parsedDate = DateTime.ParseExact(dateTextBox, "dd/MM/yyyy",
                             System.Globalization.CultureInfo.InvariantCulture);
            var formattedDate = parsedDate.ToString("yyyy-MM-dd",
                                System.Globalization.CultureInfo.InvariantCulture);

            return formattedDate;
        }
        private void btnCancelAdd_Click(object sender, EventArgs e)
        {
            AddMode(false);
            FetchRecords();
            FetchRecordByPage(currentPage);
            UpdatePagination();
            TextBoxOriginalColor();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteRecord();
        }
        private void DeleteRecord()
        {
            DialogResult result = MessageBox.Show("Do you want delete this record?", "Confirmation", 
                                  MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string mySQL = $@"DELETE 
                            FROM    
                          tblCar 
                           WHERE   VehicleRegNo = '{textBoxVehicleRegNo.Text}' ";

                    conn.Open();
                    SQLiteCommand sqlDel = new SQLiteCommand(mySQL, conn);
                    sqlDel.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Record deleted!");

                    currentPage = 1;
                    FetchRecords();
                    FetchRecordByPage(currentPage);
                    UpdatePagination();
                } catch
                {
                    MessageBox.Show("Oops! Something went wrong! \n Help us improve your experience by sending an error report");
                }
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            FrmSearch formSearch = new FrmSearch();

            formSearch.conn = conn;

            formSearch.Show();

            this.Enabled = false;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            cancelButton = true;

            FetchRecords();

            FetchRecordByPage(currentPage);

            UpdatePagination();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

            this.Dispose();
        }
    }
}