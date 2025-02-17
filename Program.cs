class Program
{
    static int CountWords(string sentence)
    {
        if (sentence == "")
            return 0;

        string[] words = sentence.Split(' ');
        return words.Length;
    }

    static void Main()
    {
        Console.WriteLine(CountWords("Just an example here move along"));
        Console.WriteLine(CountWords("This is a test"));
        Console.WriteLine(CountWords("What an easy task, right"));
    }
}
