using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookADonet
{
    public class AddressBookModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public long Zip { get; set; }
        public long PhoneNumber { get; set; }
        public string EmailId { get; set; }
        public string AddressBookType { get; set; }
        public string AddressBookName { get; set; }

    }

}
