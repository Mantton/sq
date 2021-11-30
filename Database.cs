using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.IO;
using System.Threading;


namespace SQ_Term_Project_Internal
{
    class Database
    {
        static string ip;
        static string port;
        static string password;

        static public void SetIP(string newIp)
        {
            ip = newIp;
        }

        static public void SetPort(string newPort)
        {
            port = newPort;
        }

        static public void SetPassword(string newPassword)
        {
            password = newPassword;
        }

        static public int CreateOrder(Contract contract)
        {
            string query = "INSERT INTO omnidb.order (clientName,jobName,quantity,origin,destination,vantype) VALUES " +
                "(" +
                "'" + contract.ContactName + "'," +
                contract.JobName + "," +
                contract.Quantity + "," +
                "'" + contract.Origin + "'," +
                "'" + contract.Destination + "'," +
                contract.Vantype +
                ");";

            return SendQuery(query);
        }

        static public int CreateCustomer(string name)
        {
            string query = "insert into omnidb.client(clientName) values('" + name + "');";

            return SendQuery(query);
        }

        static public int SendQuery(string query)
        {
            string connectionString = "server=" + ip + ";user=root;database=omnidb;port=" + port + ";password=" + password;
            MySqlConnection connection = new MySqlConnection(connectionString);


            //Open the connection and set all necessary objects to send a query
            try
            {
                connection.Open();

            }
            catch (Exception e)
            {
                return -1;
            }

            try
            {
                //Set the query and send it to the database
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                return -2;
            }

            connection.Close();

            return 1;
        }
    }
}
