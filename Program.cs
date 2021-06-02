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
            //addressBookModel.FirstName = "Edugawa";
            //addressBookModel.LastName = "Conan";
            //addressBookModel.Address = "Raigadh";
            //addressBookModel.City = "Raighad";
            //addressBookModel.State = "Maharastra";
            //addressBookModel.Zip = 423233;
            //addressBookModel.PhoneNumber = 823589533;
            //addressBookModel.EmailId = "Hakuna@gmail.com";
            //addressBookModel.AddressBookName = "AddressBook2";
            //addressBookModel.AddressBookType = "Friends";

            //repo.AddContact(addressBookModel);

            //AddressBookModel addressBookModel1 = new AddressBookModel();
            //addressBookModel.FirstName = "Edsfsdgdugawa";
            //addressBookModel.LastName = "Cofgnan";
            //addressBookModel.Address = "Raidsfgadh";
            //addressBookModel.City = "Raighasdfadd";
            //addressBookModel.State = "Maharastra";
            //addressBookModel.Zip = 423233;
            //addressBookModel.PhoneNumber = 823589533;
            //addressBookModel.EmailId = "Hasaretkuna@gmail.com";
            //addressBookModel.AddressBookName = "AddrrteasdessBook2";
            //addressBookModel.AddressBookType = "Frieretertnds";
            //repo.EditContactUsingPersonName(addressBookModel1);

            Console.ReadLine();
        }
        public static void AddNewContactDetails()
        {
            AddressBookRepo repository = new AddressBookRepo();
            AddressBookModel model = new AddressBookModel();
            model.FirstName = "Richa";
            model.LastName = "Sharma";
            model.Address = "Karauli";
            model.City = "Karauli";
            model.State = "Rajasthan";
            model.Zip = 555666;
            model.PhoneNumber = 8411563241;
            model.EmailId = "Richas@gmail.com";
            model.AddressBookName = "Ritika";
            model.AddressBookType = "Friend";
            Console.WriteLine(repository.AddDataToTable(model) ? "Record inserted successfully\n" : "Failed");
        }

    }
}
