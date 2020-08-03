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
    public partial class Form1 : Form
    {
        static string datasource = "Data Source=C:\\Users\\Client 0819\\source\\repos\\Shopping\\DataBase.db";
        public SQLiteConnection conn = new SQLiteConnection(datasource);
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShopList_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            SQLCommands mySelect = new SQLCommands();

            DataTable dataTable = new DataTable();

            dataTable = mySelect.FetchShopList();

            double totalPrice = 0;

            foreach (DataRow row in dataTable.Rows)
            {
                listBox1.Items.Add(row[1].ToString());
                //totalPrice = Double.Parse(row[2].ToString()) + totalPrice;
            }

            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns["guid"].Visible = false;
            dataGridView1.Columns["price"].Visible = false;
            dataGridView1.Columns["retailer_name"].Visible = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.Columns["product_name"].Width = dataGridView1.Width - 10;

            label3.Text = totalPrice.ToString();

            string mySQLRetailers = $@"SELECT *
		                     FROM 
		                     retailers";
            SQLiteDataAdapter daRetail = new SQLiteDataAdapter(mySQLRetailers, conn);
            DataTable dtRetail = new DataTable();
            daRetail.Fill(dtRetail);

            comboBox1.DataSource = dtRetail;
            comboBox1.DisplayMember = "retailer_name";
            comboBox1.ValueMember = "guid";

            string mySQLProducts = $@"SELECT *
		                     FROM 
		                     products";
            SQLiteDataAdapter daProducts = new SQLiteDataAdapter(mySQLProducts, conn);
            DataTable dtProducts = new DataTable();
            daProducts.Fill(dtProducts);

            comboBox2.DataSource = dtProducts;
            comboBox2.DisplayMember = "product_name";
            comboBox2.ValueMember = "guid";

            comboBox3.DataSource = dtProducts;
            comboBox3.DisplayMember = "product_name";
            comboBox3.ValueMember = "guid";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SQLCommands myInsert = new SQLCommands();
            
            Guid myNewGuid = Guid.NewGuid();

            myInsert.InsertShopList(myNewGuid, comboBox2.Text.ToString(), comboBox1.Text.ToString());
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            SQLCommands myDelete = new SQLCommands();

            string myRecordSelected = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            myDelete.DeleteItemShopList(myRecordSelected);

            btnShopList_Click(this, new EventArgs());
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemove.Enabled = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
            btnRemove.Enabled = true;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SQLCommands myUpdate = new SQLCommands();

            myUpdate.UpdateProduct(Double.Parse(textBox1.Text), 
                                   comboBox3.SelectedValue.ToString());
        }

        private void btnPurchased_Click(object sender, EventArgs e)
        {

            SQLCommands mySelect = new SQLCommands();

            DataTable dataTable = new DataTable();

            dataTable =  mySelect.FetchPurchased();

            foreach (DataRow row in dataTable.Rows)
            {
                

                Guid myNewGuid = Guid.NewGuid();

                string mySQLAdd = $@"INSERT 
                            INTO    
                            shoppingHistory ('guid','retalier_guid','product_guid','price_paid','shopping_dated')
                            VALUES   ('{myNewGuid}',
                                      '{row["rtlguid"]}',
                                      '{row["prdguid"]}',
                                      '{row["price"]}', 
                                       date())";

                conn.Open();
                SQLiteCommand sqlCmdAdd = new SQLiteCommand(mySQLAdd, conn);
                sqlCmdAdd.ExecuteNonQuery();
                conn.Close();

                //SQLCommands myInsert = new SQLCommands();
                //myInsert.InsertShopHistory(myNewGuid, row["rtlguid"], row["prdguid"], row["price"]);

                SQLCommands myDelete = new SQLCommands();

                string mySQLDel = $@"DELETE 
                            FROM    
                            shopping 
                            WHERE guid = '{ row["shpguid"]}'";

                conn.Open();
                SQLiteCommand sqlCmdDel = new SQLiteCommand(mySQLDel, conn);
                sqlCmdDel.ExecuteNonQuery();
                conn.Close();

                //myDelete.AddDelUpd(mySQLDel);
            }
        }

        private void btnViewShopHist_Click(object sender, EventArgs e)
        {
            frmShoppingHistory formShopHist = new frmShoppingHistory();

            formShopHist.conn2 = conn;
            formShopHist.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            //textBox6 disable
        }

        private void button3_Click(object sender, EventArgs e)
        {

            /*if (textBox6.Text )
            { 
                MessageBox.Show(Please)
            }*/

            SQLCommands myAddRetailer = new SQLCommands();

            Guid myNewGuid = Guid.NewGuid();

            string mySQL = $@"INSERT 
                    INTO    
                    retailers ('guid','retailer_name','retailer_type')
                    VALUES    ('{myNewGuid}',
                               '{textBox6.Text}',
                               '{textBox7.Text}')";
            conn.Open();
            SQLiteCommand sqlCmdAdd = new SQLiteCommand(mySQL, conn);
            sqlCmdAdd.ExecuteNonQuery();
            conn.Close();
            //myAddRetailer.AddDelUpd(mySQL);

            textBox6.Text = "";
            textBox7.Text = "";
            panel1.Visible = false;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            FrmAddProducts addNewProduct = new FrmAddProducts();

            addNewProduct.conn3 = conn;
            addNewProduct.Show();
        }
    }
}
