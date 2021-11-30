using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQ_Term_Project_Internal
{
    class Program
    {
        static void Main(string[] args)
        {
            // Repo Test

            var contracts = Marketplace.getContracts();
            
            for (int i = 0; i < contracts.Count; i++) {
                Contract contract = contracts[i];
                Console.WriteLine(contract.Origin);
            }
           
        }
    }
}
