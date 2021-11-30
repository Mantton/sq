using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQ_Term_Project_Internal
{
    public class Client
    {
        private int clientID;
        private string clientName;

        public int ClientID
        {
            get { return clientID; }
            set { clientID = value; }
        }

        public string ClientName
        {
            get { return clientName; }
            set { clientName = value; }
        }

    }
}
