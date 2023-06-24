using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace messengerTest
{
    internal class Room
    {
        int id;
        string name = "name";
        PublicUser[] users;
        public List<Message> messages;

        public Room(int id, List<Message> messages) // messages will be null on init
        {
            this.id = id;
            this.messages = messages;
        }

    }
}
