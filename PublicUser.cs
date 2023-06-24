using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace messengerTest
{
    internal class PublicUser
    {
        private string name { get; set; }
        public string getName(){return name;}
        private int id { get; set; }
        public string getId() { return name; }
        string email { get; set; }
        public string getEmail() { return email; }


        public PublicUser(string name, string email, int id)
        {
            this.name = name;
            this.email = email;
            this.id = id;
            //Console.WriteLine("user sucessfully created");
        }
        public void WriteOut()
        {
            Console.WriteLine(name+";"+ email + ";" + id + ";");
        }

    }
}
