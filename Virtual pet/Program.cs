using System.Text.RegularExpressions;

Pet myPet = new Pet("Malcomb", "Ginger");
game_function();

void game_function()
{
    Console.WriteLine($"Welcome!");
    bool isRunning = true;

    while (isRunning == true)
    {
        Console.WriteLine("What would you like to do today?");
        myPet.show_stats();
        Console.WriteLine("1.Rest\n2.Eat\n3.Play\n4.Quit game");

        string game_function_input = Console.ReadLine();

        switch (game_function_input)
        {
            case "1":
                myPet.rest();
                break;
            case "2":
                myPet.eat();
                break;
            case "3":
                myPet.play();
                break;
            case "4":
                isRunning = false;
                break;
            default:
                Console.WriteLine("Invalid input");
                break;
        }
        
    }
}

public class Pet
{
    Random rand = new Random();
    private string Name, Colour;
    private int Hunger = 100;
    private int Energy = 50;
    private int Happiness = 50;
    public Pet(string name, string colour)
    {
        Name = string.IsNullOrWhiteSpace(name) ? "Soot" : name; Colour = string.IsNullOrWhiteSpace(colour) ? "Black" : colour;
    }
    public void show_stats()
    {
        Console.WriteLine($"Energy: {Energy} \nHunger: {Hunger}\nHappiness: {Happiness}");
    }
    public void rest()
    {
        int dice_roll = rand.Next(7); // 1 to 6 die thrown
        if (dice_roll == 1)
        {
            Console.WriteLine($"{Name} did not sleep very well...");
            Energy += 10;
        }
        else if (dice_roll < 5)
        {
            Console.WriteLine($"{Name} got a good rest.");
            Energy += 50;
        }
        else
        {
            Console.WriteLine($"{Name} got a great rest!");
            Energy += 80;
        }
        if (Energy > 100)
        {
            Energy = 100;
        }
    }

    public void eat()
    {
        Hunger += 30;
    }

    public void play()
    {
        int dice_roll = rand.Next(7);
        if (dice_roll == 1)
        {
            Console.WriteLine($"{Name} did not really enjoy that...");
            Happiness -= 5;
            Energy -= 40;
            Hunger -= 20;
        }
        else if (dice_roll < 5)
        {
            Console.WriteLine($"{Name} liked that.");
            Happiness += 20;
            Energy -= 30;
            Hunger -= 20;
        }
        else
        {
            Console.WriteLine($"{Name} really enjoyed that!");
            Happiness += 40;
            Energy -= 20;
            Hunger -= 10;
        }
    }

}

