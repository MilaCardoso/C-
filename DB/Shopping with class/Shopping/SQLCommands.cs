using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace Shopping
{
    class SQLCommands
    {
        static string datasource = "Data Source=C:\\Users\\Client 0819\\source\\repos\\Shopping\\DataBase.db";
        public SQLiteConnection conn = new SQLiteConnection(datasource);

        string mySQL;

        public DataTable FetchShopList()
        {
            string mySQL = $@"SELECT  shopping.guid, product_name, price, retailer_name
		            FROM 
		            shopping
		            LEFT JOIN products ON products.guid = shopping.item_to_buy_guid
		            LEFT JOIN retailers ON retailers.guid = shopping.retailer_guid
                    ORDER BY product_name";

            DataTable dataTable = new DataTable();

            dataTable = GetRecords(mySQL);

            return dataTable;
        }

        public DataTable FetchPurchased()
        {
            string mySQL = $@"SELECT  shopping.guid AS shpguid, retailers.guid AS rtlguid, products.guid AS prdguid, price 
		            FROM 
		            shopping
		            LEFT JOIN products ON products.guid = shopping.item_to_buy_guid
		            LEFT JOIN retailers ON retailers.guid = shopping.retailer_guid
                    ORDER BY products.price";

            DataTable dataTable = new DataTable();

            dataTable = GetRecords(mySQL);

            return dataTable;
        }

        public DataTable GetRecords(string mySQL)
        {
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(mySQL, conn);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            return dataTable;
        }

        public void InsertShopList(Guid guiShop, string guidProduct, string guiRetailer)
        {
            string mySQL = $@"INSERT 
                    INTO    
                    shopping ('guid','item_to_buy_guid','retailer_guid')
                    VALUES   ('" + guiShop + "','" + guidProduct
                                 + "','" + guiRetailer + "');";

            conn.Open();
            SQLiteCommand sqlCmd = new SQLiteCommand(mySQL, conn);
            sqlCmd.ExecuteNonQuery();
            conn.Close();
        }

        public void DeleteItemShopList(string myRedordDelete)
        {
            string mySQL = $@"DELETE 
                    FROM    
                    shopping 
                    WHERE shopping.guid = '{ myRedordDelete}' ";

            conn.Open();
            SQLiteCommand sqlCmd = new SQLiteCommand(mySQL, conn);
            sqlCmd.ExecuteNonQuery();
            conn.Close();
        }

        public void UpdateProduct(double myprice, string myRedordUpdate)
        {

            string mySQL = $@"UPDATE  
                    products
                    SET price = '{myprice}'
                    WHERE guid = '{myRedordUpdate}' "; 

            conn.Open();
            SQLiteCommand sqlCmd = new SQLiteCommand(mySQL, conn);
            sqlCmd.ExecuteNonQuery();
            conn.Close();
        }

        /*public void InsertShopHistory(Guid myNewGuid, string myRtlGuid, 
                                      string myPrdGuid, Double myPrice)
        {
            string mySQLAdd = $@"INSERT 
                            INTO    
                            shoppingHistory ('guid','retalier_guid','product_guid','price_paid','shopping_dated')
                            VALUES   ('{myNewGuid}',
                                      '{myRtlGuid}',
                                      '{myPrdGuid}',
                                      '{myPrice}', 
                                       date())";

            conn.Open();
            SQLiteCommand sqlCmd = new SQLiteCommand(mySQL, conn);
            sqlCmd.ExecuteNonQuery();
            conn.Close();
        }*/
    }
}
