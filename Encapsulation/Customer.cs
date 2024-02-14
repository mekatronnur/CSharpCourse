using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Customer
    {
        private string _name;
        public int Id { get; set; }
        public string Name
        {

            get
            {
                return "Mrs." +  _name;
            }

            set
            {
                _name = value;
            }
        }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }

    }
}
