using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace ProzorovaEvgeniaOOP
{
    public class DBConnector
    {
        private static SqlConnection? connector;
        public DBConnector(string server, string database)
        {
            string connectionString = $"Server={server};Database={database};Trusted_Connection=True;";
            connector = new SqlConnection(connectionString);
            connector?.Open();
        }

        public Account? SelectAccount(string column, string value)
        {
            Account? account = null;
            SqlCommand cmd = new SqlCommand($"SELECT * FROM Users WHERE {column}=N\'{value}\';", connector);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        account =  new Account((int)reader.GetValue(0), (string)reader.GetValue(1), (string)reader.GetValue(2));
                    }
                }
            }
            return account;
        }

        public bool CheckAccount(string column, string value)
        {
            bool isExists = false;
            SqlCommand cmd = new SqlCommand($"SELECT * FROM Users WHERE {column}=N\'{value}\';", connector);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    return true;
                }
            }
            return isExists;
        }

        public Account InsertAccount(string name, string password)
        {
            SqlCommand cmd = new SqlCommand($"INSERT Users VALUES (N\'{name}\', N\'{password}\');", connector);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand($"SELECT id FROM Users WHERE [Name] = N\'{name}\';", connector);
            int id = 0;
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    id = (int)reader.GetValue(0);
                }
            }
            return new Account(id, name, password);
        }

        public void InsertMatrix(int accountId, string matrix, string result)
        {
            SqlCommand cmd = new SqlCommand($"INSERT Matrices VALUES (N'{accountId}', N\'{matrix}\', N'{result}');", connector);
            cmd.ExecuteNonQuery();
        }
    }
}
