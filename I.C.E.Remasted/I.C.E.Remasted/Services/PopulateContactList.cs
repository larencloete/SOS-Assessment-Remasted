using I.C.E.Remasted.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace I.C.E.Remasted.Services
{
    public class PopulateContactList
    {
        public ObservableCollection<Contacts> ContactList { get; set; } 

        public PopulateContactList()
        {
            ContactList = new ObservableCollection<Contacts>();

            ContactList.Add(new Contacts()
            {
                Name = "Allen",
                Number = 0828961497
            });

            ContactList.Add(new Contacts()
            {

                Name = "Okuhle",
                Number = 0605745166
            });

            ContactList.Add(new Contacts()
            {

                Name = "Naylen",
                Number = 0796233526
            });

            ContactList.Add(new Contacts()
            {

                Name = "laren",
                Number = 0624590591
            });

            ContactList.Add(new Contacts()
            {

                Name = "Kai",
                Number = 0728822013
            });

            ContactList.Add(new Contacts()
            {

                Name = "",
                Number = 0
            });

            ContactList.Add(new Contacts()
            {

                Name = "",
                Number = 0
            });

            ContactList.Add(new Contacts()
            {

                Name = "",
                Number = 0
            });

            ContactList.Add(new Contacts()
            {

                Name = "",
                Number = 0
            });

            ContactList.Add(new Contacts()
            {

                Name = "",
                Number = 0
            });

            ContactList.Add(new Contacts()
            {

                Name = "",
                Number = 0
            });

            ContactList.Add(new Contacts()
            {

                Name = "",
                Number = 0
            });

            ContactList.Add(new Contacts()
            {

                Name = "",
                Number = 0
            });

            ContactList.Add(new Contacts()
            {

                Name = "",
                Number = 0
            });

            ContactList.Add(new Contacts()
            {

                Name = "",
                Number = 0
            });

        }
    }
    
}
