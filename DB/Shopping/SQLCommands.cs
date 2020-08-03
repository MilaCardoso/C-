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

        public void AddDelUpd (string mySQL)
        {
            conn.Open();
            SQLiteCommand sqlCmd = new SQLiteCommand(mySQL, conn);
            sqlCmd.ExecuteNonQuery();
            conn.Close();
        }

        public DataTable Select(string mySQL)
        {
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(mySQL, conn);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            return dataTable;
        }

    }
}
