using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWork_11._0
{
    public class Department
    {
        public string Name { get; set; }
        public List<Client> Clients { get; set; } = new List<Client>();
    }

    public class Client
    {
        public string LastName { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string PhoneNumber { get; set; }
        public string Passport { get; set; }
    }

    public class Manager
    {
        public void AddClient(Department department, string lastname, string name, string middlename, string phoneNumber, string passport)
        {
            Client newClient = new Client
            {
                LastName = lastname,
                Name = name,
                MiddleName = middlename,
                PhoneNumber = phoneNumber,
                Passport = passport
            };
            department.Clients.Add(newClient);
        }

        public void ChangeClientData(Client client, string lastname, string name, string middlename, string phoneNumber, string passport)
        {
            client.LastName = lastname;
            client.Name = name;
            client.MiddleName = middlename;
            client.PhoneNumber = phoneNumber;
            client.Passport = passport;
        }
    }
}
