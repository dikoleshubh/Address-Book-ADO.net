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
            Console.WriteLine(repo.DeleteContact("cha", "arma") ? "Deleted Contact successfully\n" : "Update failed");
            repo.RetrieveContactFromCityOrStateName();
        }
        public static void AddNewContactDetails()
        {
            AddressBookRepo repository = new AddressBookRepo();
            AddressBookModel model = new AddressBookModel();
            model.FirstName = "Cha";
            model.LastName = "arma";
            model.Address = "KWSD";
            model.City = "Ksad";
            model.State = "Rsthan";
            model.Zip = 555666;
            model.PhoneNumber = 8411563241;
            model.EmailId = "sadasf@gmail.com";
            model.AddressBookName = "Rasasda";
            model.AddressBookType = "Frasdasd";
            Console.WriteLine(repository.AddDataToTable(model) ? "Record inserted successfully\n" : "Failed");
        }

    }
}
