public class Cards
{

    public int card1;
    public int card2;
    public Cards()
    {
    }
    
    public void ranCard()
    {
        Random random_card = new Random();
        card1 = random_card.Next(1, 13); //This is the first card
        card1 = card2;
        card2 = random_card.Next(1, 13);//This one will be the next
    }

    public int Compare_Card(char answer)
    {
        if ((card1 < card2) & (answer == 'h'))
        {
            return 100;
        }
        else if ((card1 > card2) & (answer == 'l'))
        {
            return 100;
        }
        else if (card1 == card2)
        {
            return 0;
        }
        else
        {
            return -75;
        }
    }
}