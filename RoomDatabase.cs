using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace messengerTest
{
    internal class RoomDatabase
    {
        SqlConnection conn;
        public RoomDatabase()
        {
            conn = new SqlConnection("Data Source=DESKTOP-N3G2RBD;Initial Catalog=UserDatabase;Integrated Security=True");
            conn.Open();
        }
        
        public Room GetRoom(int UserId,int RoomId)
        {
            String querry = "SELECT * FROM RoomDatabase WHERE RoomId = '"+RoomId+"'";
            SqlCommand command = new SqlCommand(querry, conn);
            SqlDataReader reader = command.ExecuteReader();
            Room room;
            List<Message> messages = new List<Message>();
            while (reader.Read())
            {
                Message m = new Message(reader.GetInt32(1), reader.GetString(3),reader.GetInt32(0));
                messages.Add(m);
            }
            room = new Room(RoomId, messages);

            reader.Close();
            command.Dispose();
            conn.Close();
            
            return room;
        }
        public Room GetRooms(int UserId)
        {
            String querry = "SELECT * FROM RoomDatabase";
            SqlCommand command = new SqlCommand(querry, conn);
            SqlDataReader reader = command.ExecuteReader();
            Room room;
            List<Message> messages = new List<Message>();
            while (reader.Read())
            {
                Message m = new Message(reader.GetInt32(1), reader.GetString(3), reader.GetInt32(0));
                messages.Add(m);
                
            }
            room = new Room(messages[0].RoomId, messages);

            reader.Close();
            command.Dispose();
            conn.Close();

            return room;
        }

    }
}
