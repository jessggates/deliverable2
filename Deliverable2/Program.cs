{
    Console.WriteLine("Welcome to the COIN FLIP CHALLENGE!");
    Console.WriteLine("What is your name? ");
    string name = Console.ReadLine();
    Console.WriteLine("Welcome " + name + "! " + "Do you want to do the COIN FLIP CHALLENGE? yes/no");
    string answer = Console.ReadLine();

    if (answer == "yes")
    {
        for (int x = 5; x >= 1; x--)
        {
            Random random = new Random();
            int test = random.Next(0, 2);
            Console.WriteLine("Heads or Tails?");
            string coinChoice = Console.ReadLine();
            if (test == 0 && coinChoice.ToLower() == "heads")
            {
                Console.WriteLine("Correct!");
            }
            else if (test == 1 && coinChoice.ToLower() == "tails")
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Wrong!");
            }
        }
    }
    else
    {
        Console.WriteLine("You are a coward " + name + "! ");
    }
}