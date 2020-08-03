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

namespace Shopping
{
    public partial class FrmAddProducts : Form
    {
        public SQLiteConnection conn3;
        public FrmAddProducts()
        {
            InitializeComponent();
        }

        private void frmAddProducts_Load(object sender, EventArgs e)
        {
            string mySQL = $@"SELECT  product_name,
                                      price
                                FROM  products";
            SQLiteDataAdapter Da = new SQLiteDataAdapter(mySQL, conn3);
            DataTable dataTable = new DataTable();
            Da.Fill(dataTable);
            Da.Dispose();

            dtGridViProducts.DataSource = dataTable;
            dtGridViProducts.RowHeadersVisible = false;
            dtGridViProducts.ColumnHeadersVisible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text != "" && numUpDownProdPrice.Text != "")
            {
                SQLCommands myAddRetailer = new SQLCommands();

                Guid myNewGuid = Guid.NewGuid();

                string mySQL = $@"INSERT 
                                    INTO    
                                    products ('guid','product_name','price')
                                    VALUES    ('{myNewGuid}',
                                               '{txtProductName.Text}',
                                               '{numUpDownProdPrice.Text}')";

                conn3.Open();
                SQLiteCommand sqlCmdAdd = new SQLiteCommand(mySQL, conn3);
                sqlCmdAdd.ExecuteNonQuery();
                conn3.Close();

                //myAddRetailer.AddDelUpd(mySQL);

                txtProductName.Text = "";
                numUpDownProdPrice.Text = "";
                panel1.Visible = false;
            } else {
                    MessageBox.Show("Please complete the field information!");
            }
        }

        public void FetchProducts()
        {
            if (txtProductName.Text != "" && numUpDownProdPrice.Text != "")
            {
                SQLCommands myAddRetailer = new SQLCommands();

                Guid myNewGuid = Guid.NewGuid();

                string mySQL = $@"INSERT 
                                    INTO    
                                    products ('guid','product_name','price')
                                    VALUES    ('{myNewGuid}',
                                               '{txtProductName.Text}',
                                               '{numUpDownProdPrice.Text}')";

                conn3.Open();
                SQLiteCommand sqlCmdAdd = new SQLiteCommand(mySQL, conn3);
                sqlCmdAdd.ExecuteNonQuery();
                conn3.Close();

                //myAddRetailer.AddDelUpd(mySQL);

                txtProductName.Text = "";
                numUpDownProdPrice.Text = "";
                panel1.Visible = false;
            }
            else
            {
                MessageBox.Show("Please complete the field information!");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //FetchProducts();
        }
    }
}
