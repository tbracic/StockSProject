using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockS.Logic
{
    internal class trash
    {
        /*private SQLiteDB connection;
        private SQLiteConnection sqlitebd { get; set; }
        public static SQLiteDB Instance { 
            get { if (instance == null) { instance = new SQLiteDB(); } return instance; }
        }
        public SQLiteDB() { }
        public void Connection()
        {
            sqlitebd = new SQLiteConnection("Data Source=db.db; Version = 3; New = True; Compress = True; ");
            try { sqlitebd.Open(); }
            catch(Exception ex)
            {
                
            }
            
           
        }
        public void Disconnect()
        {
            if (sqlitebd.State != System.Data.ConnectionState.Closed) {
                try { sqlitebd.Close(); }
                catch (Exception ex) { }
            }
            
        }
        public int insert(string querry)
        {
            SQLiteCommand command = new SQLiteCommand(querry,sqlitebd);
            return command.ExecuteNonQuery();
        }
        public SQLiteDataReader getDataReader(string querry)
        {
            SQLiteCommand sqlcmd;
            SQLiteDataReader datar;
            sqlcmd = sqlitebd.CreateCommand();
            sqlcmd.CommandText = querry;
            datar =  sqlcmd.ExecuteReader();
            return datar;
        }
        public Object getValue(string querry) 
        {
            SQLiteCommand command = new SQLiteCommand(querry, sqlitebd);
            return command.ExecuteScalar();
        }*/
    }
}
