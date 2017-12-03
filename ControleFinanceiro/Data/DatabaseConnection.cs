using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace ControleFinanceiro.Data
{
    class DatabaseConnection
    {
        private string server = "tantor.db.elephantsql.com";
        private string user = "afhococs";
        private string password = "R_4HkeBuuK61wN_Fhqut_hFHk_2tKQRl";
        private string database = "afhococs";

        private NpgsqlConnection conn;

        public DatabaseConnection()
        {
            try
            {
                string connectionString = "Server=" + server + ";User Id=" + user + ";Password=" + password + ";Database=" + database + ";";
                conn = new NpgsqlConnection(connectionString);
            }
            catch (Exception e)
            {
                throw;
            }
        }

        private void CreateTable (Table table)
        {
            try
            {

            } catch (Exception e)
            {

            }
        }
    }
}
