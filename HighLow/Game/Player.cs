public class Player
{
    char hi_lo;
    char answer;
    int score = 300;

    public Player()
    {

    }

    public void player_guess()
    {
        Cards deck = new Cards();

        Console.WriteLine("Would you like to play? (y/n)");
        answer = Console.ReadLine()[0];



        while (answer == 'y')
        {
            deck.ranCard();
            Console.WriteLine($"Your current score is {score}");
            Console.WriteLine($"The card is {deck.card1}");
            Console.WriteLine("High or Low? (h/l)");
            hi_lo = Console.ReadLine()[0];

            Console.WriteLine($"The next card is {deck.card2}");
            score += deck.Compare_Card(hi_lo);
            Console.WriteLine($"Your score is {score}");
            Console.WriteLine("");

            Console.WriteLine("Play again? (y/n) ");
            answer = Console.ReadLine()[0];
            Console.WriteLine("");
            
            if (answer == 'n')
            {
                Console.WriteLine("Thanks for playing!");
            }
            else if (score <= 0)
            {
                Console.WriteLine("You lost");
            }
            else if (answer != 'y' || answer != 'n')
            {
                Console.WriteLine("Please enter (y/n)");
            }
        }

    }
}