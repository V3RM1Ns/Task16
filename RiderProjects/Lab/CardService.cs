namespace Lab;

public class CardService:ICardService
{
    private List<Card> _cards = new();

    public void AddCard(Card card)
    {
        _cards.Add(card);
    }
}