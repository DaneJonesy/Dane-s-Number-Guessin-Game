
    class Program
{ 
    static void Main(string[] args)
{
    Random r = new Random();
    int num = r.Next(1, 101);
    bool win = false;

    do
    {
        Console.WriteLine("Guess a number between 1 - 100");
        string s = Console.ReadLine();

        int i = int.Parse(s);

        if (i > num)
        {
            Console.WriteLine("Your number is to high!");
        }

        else if (i < num)
        {
            Console.WriteLine("Your number is to low!");
        }

        else if (i == num)
        {
            Console.WriteLine("You got it!");
            win = true;
        }
    } while (win == false);
}
}
