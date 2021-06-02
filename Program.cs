using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace AddressBookADonet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Database Project with ADO.NET");
            AddressBookRepo repo = new AddressBookRepo();
            AddressBookModel addressBookModel = new AddressBookModel();
            repo.CheckConnection();
            repo.GetAllContact();
            
            Console.WriteLine(repo.EditContactUsingName("Cha", "arma", "k21") ? "Update done successfully\n" : "Update failed");

            repo.AddContact(addressBookModel);

            Console.ReadLine();
        }
        
    }
}
