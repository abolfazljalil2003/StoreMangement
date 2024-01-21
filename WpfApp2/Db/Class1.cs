using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.Db
{
    class Class1
    {
    

        public SQLiteConnection CreateConnection()
        {

            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = new SQLiteConnection("Data Source=database.db; Version = 3; New = True; Compress = True; ");
           // Open the connection:
         try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {

            }
            return sqlite_conn;
        }

        public void CreateTable(SQLiteConnection conn,string table)
        {

            SQLiteCommand sqlite_cmd;
            string Createsql = table;
           // string Createsql1 = "CREATE TABLE SampleTable1 (Col1 VARCHAR(20), Col2 INT)";
           sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = Createsql;
            sqlite_cmd.ExecuteNonQuery();
            conn.Close();

        }

      

        
    }
}
