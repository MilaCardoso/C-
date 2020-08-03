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
    public partial class Form2 : Form
    {
        public SQLiteConnection conn2;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string mySQL = $@"SELECT  products.product_name,
                    products.price,
		            retailers.retailer_name,
                    shopping_dated
                    FROM shoppingHistory 
                    LEFT JOIN products  ON shoppingHistory.product_guid = products.guid
                    LEFT JOIN retailers ON shoppingHistory.retalier_guid = retailers.guid";
            SQLiteDataAdapter Da = new SQLiteDataAdapter(mySQL, conn2);
            DataTable dataTable = new DataTable();
            Da.Fill(dataTable);
            Da.Dispose();

            dataGridView1.DataSource = dataTable;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnHeadersVisible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

    }
}
