using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQ_Term_Project_Internal
{
    class Contract
    {
        private string contactName;
        private string jobName;
        private string quantity;
        private string origin;
        private string destination;
        private string vanType;

        Contract() { }
        Contract(string ContactName, string JobName, string Quantity, string Origin, string Destination, string VanType)
        {
            this.contactName = ContactName;
            this.jobName = JobName;
            this.quantity = Quantity;
            this.origin = Origin;
            this.destination = Destination;
            this.vanType = VanType;
        }

        public string ContactName
        {
            get { return contactName; }
            set { contactName = value; }
        }

        public string JobName
        {
            get { return jobName; }
            set { jobName = value; }
        }

        public string Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public string Origin
        {
            get { return origin; }
            set { origin = value; }
        }

        public string Destination
        {
            get { return destination; }
            set { destination = value; }
        }

        public string Vantype
        {
            get { return vanType; }
            set { vanType = value; }
        }
    }
}
