using Save_load_file;

class Program
{
    static void Main()
    {
        JsonSaveAndWrite manager = new JsonSaveAndWrite();

        User Dan = new User { Name = "Dan", Balance = 15, Games = "Dark Souls 2" };
        User Ben = new User { Name = "Ben", Balance = 15.89, Games = "Hollow Knight, Sekiro" };
        string user = "Dan";

        JsonSaveAndWrite.SaveUserData(Dan);

        User? LoadedUser = JsonSaveAndWrite.RetriveUserData(user);

        if(LoadedUser != null)
        {
            Console.WriteLine($"Name: {LoadedUser.Name}");
            Console.WriteLine($"Balance: {LoadedUser.Balance}");
            Console.WriteLine($"Games: {LoadedUser.Games}");
        }
    }
}

