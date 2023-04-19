﻿using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Collections;

namespace StockS.Logic
{
    public class AppDatabase
    {
        private SQLiteConnection _connection;
        public AppDatabase(string path)
        {
            _connection = new SQLiteConnection("DataSource="+path);

        }
        public void Open() { _connection.Open(); }
        public void Close() { _connection.Close(); }

        public SQLiteDataReader GetData(string sql)
        {
            SQLiteCommand cmd = _connection.CreateCommand();
            cmd.CommandText = sql;
            SQLiteDataReader rdr = cmd.ExecuteReader();
            return rdr;
        }
        public string InsertData(string sql)
        {
            SQLiteCommand cmd = _connection.CreateCommand();
            cmd.CommandText = sql;
            int bum =cmd.ExecuteNonQuery();
            return "Good. " + bum;
        }
        public string[] GetAllTables()
        {
            
            DataTable dbSchema = _connection.GetSchema("Tables");
            string[] tableNames = new string[dbSchema.Rows.Count];
            for (int i =0; i < dbSchema.Rows.Count; i++)
            {
                tableNames[i] = dbSchema.Rows[i]["TABLE_NAME"].ToString();
            }

            return tableNames;
        }
    }
}
