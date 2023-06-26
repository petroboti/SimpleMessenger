using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace messengerTest
{
    internal class Menu
    {
        UserDatabase userDatabase;
        RoomDatabase roomDatabase;
        enum State { LoggedOut,LoggedIn,RoomsList,Room,FriendsList,Friend}
        State state;
        int userid;
        string username;
        public Menu() {
            userDatabase = new UserDatabase();
            roomDatabase = new RoomDatabase();
            state = State.LoggedOut;
        }

        public void StartMenu()
        {
            Console.Clear();
            switch (state)
            {
                case State.LoggedOut:
                    userid = LogIn();
                    if (userid == 0)
                    {
                        Console.WriteLine("Not valid email or password");
                    }
                    else
                    {
                        state = State.LoggedIn;
                    }

                    break; 
                case State.LoggedIn:
                    Console.WriteLine("-Logged in as "+username+"-");
                    Console.WriteLine("1: Show Group chats");
                    Console.WriteLine("2: Show Friend chats");
                    Console.WriteLine("3: Logout");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            state = State.RoomsList;
                            break;
                        case "2":
                            state = State.FriendsList;
                            break;
                        case "3":
                            username = "";
                            userid = 0;
                            state = State.LoggedOut;
                            break;
                    }   
                    break;
                case State.RoomsList:
                    break;
                case State.Room:
                    break;
                case State.FriendsList:
                    break;
                case State.Friend:
                    break;
            }
            
        }

        public void ShowCurrentMenuPoints()
        {

        }

        public int LogIn() //token login needed
        {
            Console.WriteLine("-Login-");
            Console.WriteLine("Email:");
            string a = Console.ReadLine();
            Console.WriteLine("Password:");
            string b = Console.ReadLine();

            int Userid = userDatabase.Login(a, b);
            username = userDatabase.GetUserName(Userid);
            return Userid;
        }

        public void LogOut() { }

        public void ShowRooms() { }
        public void ShowRoom() { }
        public void ShowFriends() { }
        public void ShowFriend() { }

        public void GoBack() { }

    }
}
