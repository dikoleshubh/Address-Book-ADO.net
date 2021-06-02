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
            addressBookModel.FirstName = "Edugawa";
            addressBookModel.LastName = "Conan";
            addressBookModel.Address = "Raigadh";
            addressBookModel.City = "Raighad";
            addressBookModel.State = "Maharastra";
            addressBookModel.Zip = 423233;
            addressBookModel.PhoneNumber = 823589533;
            addressBookModel.EmailId = "Hakuna@gmail.com";
            addressBookModel.AddressBookName = "AddressBook2";
            addressBookModel.AddressBookType = "Friends";

            repo.AddContact(addressBookModel);

            Console.ReadLine();
        }
        
    }
}
