string decode_this = "12x5y4cd";
Console.WriteLine(multiplyText(decode_this));

static string multiplyText( string original_string )
{
    string final_string = "";
    int multiplier = 0;

    foreach (char c in original_string)
    {
        if (char.IsDigit(c))
        {
            multiplier = multiplier * 10 + int.Parse(c.ToString());
        }
        else
        {
            final_string = final_string + new string(c, multiplier != 0 ? multiplier : 1);
            multiplier = 0;
        }
    }


    return final_string;
}


