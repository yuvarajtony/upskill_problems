// word and letters count in a sentance

class Word_count
{
    static void Main(string[] args)
    {
        string word = Console.ReadLine();
        string[] words = word.Split();
        int total_count = 0;

        int count = words.Length;
        Console.WriteLine("words in the sentance: " + count);

        foreach(string w in words)
        {
            total_count += w.Length;
        }
        Console.WriteLine("total letters in the sentance: " + total_count);
    }
}
