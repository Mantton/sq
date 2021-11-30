using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;
using System.Threading;

namespace SQ_Term_Project_Internal
{
    class Marketplace
    {
        private static string marketPlaceConnection = "server=159.89.117.198;user=DevOSHT;database=cmp;port=3306;password=Snodgr4ss!";
        private static string localAddress = "server=localhost;user=;database=SQ;port=3306;password=";
        // Get Contracts
        public static List<Contract> getContracts() {
            string query = "select * from Contract;";
            List < Contract > contracts = Repository.LoadData<Contract, dynamic>(query, new { }, marketPlaceConnection);
            return contracts;
        }

        // Fetch Existing Customers
        public static List<Client> getExistingCustomers() {
            string query = "select * from client";
            List <Client> clients = Repository.LoadData<Client, dynamic>(query, new { }, localAddress);
            return clients;
        }

        // Add new Client
        public static void addClient(string name) {
            string sqlClientInsert = "insert into client (clientName) Values (@name);";
            
            Repository.SaveData(sqlClientInsert, new { name }, localAddress);

        }
    }

   
}
