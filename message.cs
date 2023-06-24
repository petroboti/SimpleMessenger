using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace messengerTest
{
    internal class Message
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RoomId { get; set; }
        public string Content { get; set; }

        public Message (int UserId, string Content, int RoomId) {
            this.UserId = UserId;
            this.Content = Content;
        }
    }
}
