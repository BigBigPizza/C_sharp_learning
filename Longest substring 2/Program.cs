string input_string = "abcabcbb";

Console.WriteLine(longest_unique_substring(input_string));
Console.WriteLine(longest_unique_substring("dvdf"));
Console.WriteLine(longest_unique_substring("abba"));
Console.WriteLine(longest_unique_substring("au"));
Console.WriteLine(longest_unique_substring("pwwkew"));

static int longest_unique_substring(string full_string)
{
    string longest_sub = "";
    int longest_sub_count = 0;

    foreach (char c in full_string)
    {
        if (longest_sub.Contains(c))
        {
            longest_sub = longest_sub.Split(c)[1];
        }
        else
        {
            longest_sub += c;
        }
        longest_sub_count = longest_sub_count > longest_sub.Length ? longest_sub_count : longest_sub.Length;
    }

    return longest_sub_count;
}
