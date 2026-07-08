


static void start_user_interface()
{
    Console.WriteLine("This program works by guessing a random number that you pick.");
    Console.WriteLine("\nIn response to the computer's guess, respond with 'too high' or 'too low' or 'correct' if it guessed your number");
    Console.WriteLine("Are you ready to start? (y/n): ");

    string? user_y_n;
    user_y_n = Console.ReadLine();

    if (user_y_n.ToLower() == "y")
    {
        number_guesser_main();
        start_user_interface();
    }
    else
    {
        Console.WriteLine("Quitting...");
    }
}

static int get_new_guess(int lower_bound, int upper_bound)
{
    Random rand = new Random();
    int computer_guess = rand.Next(lower_bound, upper_bound);
    return computer_guess;
}

static string get_user_response(int guess_value)
{
    string? user_response = null;

    Console.WriteLine($"I guess {guess_value}");
    Console.WriteLine("\nWas this value too high, too low or was it correct?");

    do
    {
        user_response = Console.ReadLine();
    } while (user_response == null);

    return user_response.ToLower();
}

static void number_guesser_main()
{
    int low_guess_range = 0;
    int high_guess_range = 100;
    int computer_guess = get_new_guess(low_guess_range, high_guess_range);

    string response = get_user_response(computer_guess);

    do
    {
        if (response == "too high")
        {
            high_guess_range = computer_guess;
            computer_guess = get_new_guess(low_guess_range, high_guess_range);
        }
        else if (response == "too low")
        {
            low_guess_range = computer_guess;
            computer_guess = get_new_guess(low_guess_range, high_guess_range);
        }
        else
        {
            Console.WriteLine("Your input was invalid, try again.");
        }
        response = get_user_response(computer_guess);

    } while (response != "correct");

    Console.WriteLine($"The number was {computer_guess}!");


}

start_user_interface();
