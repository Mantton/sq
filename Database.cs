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

        //
        private static void DisplayData(System.Data.DataTable table)
        {
            foreach (System.Data.DataRow row in table.Rows)
            {
                foreach (System.Data.DataColumn col in table.Columns)
                {
                    Console.WriteLine("{0} = {1}", col.ColumnName, row[col]);
                }
                Console.WriteLine("============================");
            }
        }
        //

        static public int SendQuery(string query)
        {
            //string connectionString = "server=" + ip + ";user=root;database=omnicorp;port=" + port + ";password=" + password;
            string connectionString = "server=159.89.117.198;user=DevOSHT;database=cmp;port=3306;password=Snodgr4ss!";
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

                MySqlDataReader rdr = command.ExecuteReader();

                while (rdr.Read())
                {
                    Console.WriteLine(rdr.GetName(0));
                    Console.WriteLine(rdr.GetName(0));
                    Console.WriteLine(rdr.GetName(0));
                    Console.WriteLine(rdr.GetName(0));
                    Console.WriteLine(rdr.GetName(0));
                    Console.WriteLine(rdr.GetName(0));

                }

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
