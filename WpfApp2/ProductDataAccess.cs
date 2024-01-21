using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcces.Models;
using WpfApp2.Db;
using System.Data.SQLite;

namespace DataAcces
{
    public class ProductDataAccess
    {
        public ObservableCollection<product> Products { get; set; } = new ObservableCollection<product>();
        public ProductDataAccess()
        {
            Class1 conn = new Class1();
            conn.CreateTable(conn.CreateConnection(), "CREATE TABLE  IF NOT EXISTS product (Name VARCHAR(20), Id INTEGER PRIMARY KEY,Price INT,AvilebleCount INT)");
            ReedProducts(conn.CreateConnection());

        }
        private void ReedProducts(SQLiteConnection conn)
        {

            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM product";

            sqlite_datareader = sqlite_cmd.ExecuteReader();

            while (sqlite_datareader.Read())
            {
                
                Products.Add(new product() {
                    Name = sqlite_datareader.GetString(0),
                    Id = sqlite_datareader.GetInt32(1),
                    Price = sqlite_datareader.GetInt32(2),
                    AvilebleCount = sqlite_datareader.GetInt32(3)

                });
            }
            conn.Close();

          
        }
        
        public void Removeproduct(int  id)
        {
            product temp=Products.First(p => p.Id == id);
            Products.Remove(temp);
        }
        public void EditeProduct(product pr)
        {
            product temp = Products.First(p => p.Id ==pr.Id);
            int index=Products.IndexOf(temp);
            Products[index] = pr;
        }
        public int GetNextId()
        {
            int index=Products.Any()? Products.Max(p => p.Id)+1 :1;
            return index;
        }
        public int AddProduct(int Id,string Name,decimal Price,int AvilebleCount)
        {
            Class1 con = new Class1();
            SQLiteConnection conn = con.CreateConnection();
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "INSERT INTO product (Name,Price,AvilebleCount) VALUES('"+Name+"','"+Price+"','"+AvilebleCount+"'); ";
            int ok=sqlite_cmd.ExecuteNonQuery();

            return ok;
        }

    }
}
