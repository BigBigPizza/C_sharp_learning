string[] directions = { "Left 5", "Up 2", "right 2", "Down 1" };


int x_final = 0;
int y_final = 0;

foreach (string pair in directions)
{
    string[] splits = pair.Split(' ');
    string direction = splits[0].ToLower();
    int magnitude = int.Parse(splits[1]);

    int x_value = 0;
    int y_value = 0;

    switch (direction)
    {
        case "left":
            x_value = -1;
            break;
        case "right":
            x_value = 1;
            break;
        case "up":
            y_value = 1;
            break;
        case "down":
            y_value = -1;
            break;
        default:
            Console.WriteLine("A directional value was incorrect");
            break;

    }

    x_final += x_value * magnitude;
    y_final += y_value * magnitude;


}

Console.WriteLine("The final position is " + x_final + "x " + y_final + "y");