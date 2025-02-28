using System;
using System.Data;
using System.Data.SQLite;

namespace Acquisti
{
    public class DatabaseHelper
    {
        private static string connectionString = "Data Source=clienti.db;Version=3;";

        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(connectionString);
        }

        public static void InitializeDatabase()
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string sql = @"
                CREATE TABLE IF NOT EXISTS Clienti (
                    ID INTEGER PRIMARY KEY AUTO_INCREMENT,
                    Nome VARCHAR(255) NOT NULL,
                    Cognome VARCHAR(255) NOT NULL,
                    Email VARCHAR(255) NOT NULL,
                    Telefono VARCHAR(20) NOT NULL
                );

                CREATE TABLE IF NOT EXISTS Aquisti (
                    ID INTEGER PRIMARY KEY AUTO_INCREMENT,
                    ClienteID INTEGER NOT NULL,
                    Prodotto VARCHAR(255) NOT NULL,
                    Prezzo REAL NOT NULL,
                    DataAcquisto DATE NOT NULL,
                    FOREIGN KEY (ClienteID) REFERENCES Clienti(ID) ON DELETE CASCADE
                );
            ";
                SQLiteCommand command = new SQLiteCommand(sql, conn);
                command.ExecuteNonQuery();
            }
        }
    }
}