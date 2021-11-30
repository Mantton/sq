using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Data;
using Dapper;
namespace SQ_Term_Project_Internal
{
    public class Repository
    {
        /**
        * @brief L
        * @param sql the SQL Query to Run
        * @param parameters Parameters to Populate the query with
        * @param connectionString The Database Connection String
        *
        */
        public static List<T> LoadData<T, U>(string sql, U parameters, string connectionString)
        {
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                List<T> rows = connection.Query<T>(sql, parameters).ToList();
                return rows;

            }
        }

        /**
        * @brief L
        * @param sql the SQL Query to Run
        * @param parameters Parameters to Populate the query with
        * @param connectionString The Database Connection String
        *
        */
        public static void SaveData<T>(string sql, T parameters, string connectionString)
        {
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                var affectedRows = connection.Execute(sql, parameters);
                
                // TODO Log This information
            }
        }

    }
}
