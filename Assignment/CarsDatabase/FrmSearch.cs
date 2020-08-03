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

namespace Assignment
{
    public partial class FrmSearch : Form
    {
        public SQLiteConnection conn;
        private DataTable dataTable;
        private string mySQLCondition = "";
        public FrmSearch()
        {
            InitializeComponent();
        }
        private void FrmSearch_Load(object sender, EventArgs e)
        {
            ComboBoxField();

            ComboBoxOperator();

            ComboBoxValueAvailable();
        }
        private void ComboBoxField()
        {
            cboField.Items.Add("Make");
            cboField.Items.Add("EngineSize");
            cboField.Items.Add("RentalPerDay");
            cboField.Items.Add("Available");
        }
        private void ComboBoxOperator()
        {
            cboOperator.Items.Add("=");
            cboOperator.Items.Add("<");
            cboOperator.Items.Add(">");
            cboOperator.Items.Add("<=");
            cboOperator.Items.Add(">=");
        }
        private void ComboBoxValueAvailable()
        {
            cboValueAvailable.Items.Add("Yes");
            cboValueAvailable.Items.Add("No");
        }
        private void buttonRun_Click(object sender, EventArgs e)
        {

            if(!CheckMandatoryFields())
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }

            CheckComboBoxField();

            SelectTblCarFilter();

            AvailableCheckBox();
        }

        private bool CheckMandatoryFields(){

            if (cboField.Text != "Available")
            {
                if (cboField.Text == "" || cboOperator.Text == "" || textBoxValue.Text == "")
                {
                    return false;
                }
            } else
            {
                if (cboField.Text == "" || cboOperator.Text == "" || cboValueAvailable.Text == "")
                {
                    return false;
                }
            }
            return true;
        }
        private void CheckComboBoxField()
        {
            if (cboField.Text == "Make")
            {
                mySQLCondition = cboField.Text + " " + "LIKE '%" + textBoxValue.Text + "%'";
            }

            if (cboField.Text == "EngineSize")
            {
                mySQLCondition = cboField.Text + " " + cboOperator.Text + " " + "'" + textBoxValue.Text + "'";
            }

            if (cboField.Text == "RentalPerDay")
            {
                Double.Parse(textBoxValue.Text);
                mySQLCondition = cboField.Text + " " + cboOperator.Text + " " + textBoxValue.Text;
            }

            if (cboField.Text == "Available")
            {
                int availableValue = 0;
                if (cboValueAvailable.Text == "Yes")
                {
                    availableValue = 1;
                }
                mySQLCondition = "Available = " + availableValue;
            }

        }
        private void SelectTblCarFilter()
        {
            try
            {
                string mySQL = $@"SELECT *  
                    FROM 
                  tblCar
                   WHERE   " + mySQLCondition +
              " ORDER BY   VehicleRegNo ; ";

                conn.Open();
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(mySQL, conn);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataAdapter.Dispose();
                conn.Close();

                dataGridViewSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewSearch.DataSource = dataTable;
                dataGridViewSearch.AllowUserToAddRows = false;
                dataGridViewSearch.Columns["uid"].Visible = false;
                dataGridViewSearch.Columns[5].DefaultCellStyle.Format = "c";

                AvailableCheckBox();
            } catch
            {
                MessageBox.Show("Oops! Something went wrong! \n Help us improve your experience by sending an error report");
            }
        }
        private void AvailableCheckBox()
        {
            foreach (DataGridViewRow row in dataGridViewSearch.Rows)
            {
                DataGridViewCheckBoxCell cell = new DataGridViewCheckBoxCell();
                row.Cells[6] = cell;
                row.Cells[6].ReadOnly = true;
            }
        }
        private void cboField_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeComboBoxOperator();
        }
        private void ChangeComboBoxOperator()
        {
            if (cboField.Text == "Available" || cboField.Text == "Make")
            {
                cboOperator.Enabled = false;
                cboOperator.Text = "=";
            }
            else
            {
                cboOperator.Enabled = true;
            }

            if (cboField.Text == "Available")
            {
                textBoxValue.Visible = false;
                cboValueAvailable.Visible = true;
            }
            else
            {
                textBoxValue.Visible = true;
                cboValueAvailable.Visible = false;
            }
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            Application.OpenForms["FrmCars"].Enabled = true;
        }

        private void FrmSearch_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms["FrmCars"].Enabled = true;
        }
    }
}
