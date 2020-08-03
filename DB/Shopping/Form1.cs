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
            string mySQL = $@"SELECT  shopping.guid, product_name, price, retailer_name
		            FROM 
		            shopping
		            LEFT JOIN products ON products.guid = shopping.item_to_buy_guid
		            LEFT JOIN retailers ON retailers.guid = shopping.retailer_guid";
            SQLiteDataAdapter Da = new SQLiteDataAdapter(mySQL, conn);
            DataTable dataTable = new DataTable();
            Da.Fill(dataTable);

            double totalPrice = 0;

            foreach (DataRow row in dataTable.Rows)
            {
                listBox1.Items.Add(row[1].ToString());
                totalPrice = Double.Parse(row[2].ToString()) + totalPrice;
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

            string mySQL = $@"INSERT 
                    INTO    
                    shopping ('guid','item_to_buy_guid','retailer_guid')
                    VALUES   ('" + myNewGuid.ToString() + "','" + comboBox2.SelectedValue.ToString()
                                 + "','" + comboBox1.SelectedValue.ToString() + "');";

            myInsert.AddDelUpd(mySQL);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            SQLCommands myDelete = new SQLCommands();

            string myRecordSelected = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            string mySQL = $@"DELETE 
                    FROM    
                    shopping 
                    WHERE shopping.guid = '{ myRecordSelected}' ";

            myDelete.AddDelUpd(mySQL);

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

            string mySQL = $@"UPDATE  
                    products
                    SET price = '{Double.Parse(textBox1.Text)}'
                    WHERE guid = '{comboBox3.SelectedValue.ToString()}' ";

            myUpdate.AddDelUpd(mySQL);
        }

        private void btnPurchased_Click(object sender, EventArgs e)
        {
            string mySQL = $@"SELECT  shopping.guid AS shpguid, retailers.guid AS rtlguid, products.guid AS prdguid, price 
		            FROM 
		            shopping
		            LEFT JOIN products ON products.guid = shopping.item_to_buy_guid
		            LEFT JOIN retailers ON retailers.guid = shopping.retailer_guid";
            SQLiteDataAdapter Da = new SQLiteDataAdapter(mySQL, conn);
            DataTable dataTable = new DataTable();
            Da.Fill(dataTable);

            foreach (DataRow row in dataTable.Rows)
            {
                SQLCommands myInsert = new SQLCommands();

                Guid myNewGuid = Guid.NewGuid();

                string mySQLAdd = $@"INSERT 
                            INTO    
                            shoppingHistory ('guid','retalier_guid','product_guid','price_paid','shopping_dated')
                            VALUES   ('{myNewGuid}',
                                      '{row["rtlguid"]}',
                                      '{row["prdguid"]}',
                                      '{row["price"]}', 
                                       date())";

                myInsert.AddDelUpd(mySQLAdd);

                SQLCommands myDelete = new SQLCommands();

                string mySQLDel = $@"DELETE 
                            FROM    
                            shopping 
                            WHERE guid = '{ row["shpguid"]}'";

                myDelete.AddDelUpd(mySQLDel);

            }
        }

        private void btnViewShopHist_Click(object sender, EventArgs e)
        {
            Form2 formShopHist = new Form2();

            formShopHist.conn2 = conn;
            formShopHist.Show();



        }

    }
}
