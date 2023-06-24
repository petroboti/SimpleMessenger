// See https://aka.ms/new-console-template for more information
using messengerTest;

Console.WriteLine("Hello, World!");
UserDatabase userDatabase = new UserDatabase();
int Userid = userDatabase.Login("johnsmith@example.com", "Pa$$w0rd123");
RoomDatabase roomDatabase = new RoomDatabase();
Room room = roomDatabase.GetRoom(Userid, 1);
foreach (Message message in room.messages)
{
    Console.WriteLine(message.Content+"\t"+message.UserId);
}
Console.WriteLine(Userid);
Console.WriteLine(userDatabase.GetUserName(Userid));
