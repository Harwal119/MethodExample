// Console.WriteLine("Hello, World!");
using RechargeCardApp;

internal class Program
{
     static RechargeCardManager manager = new RechargeCardManager();
    private static void Main(string[] args)
    {
        manager.CreateRechargeCard();
        //System.Console.WriteLine(manager.cards.Count());
        foreach (var card in manager.cards)
        {
            Console.WriteLine($"{card.GetSerialNumber()} {card.GetCardType()} {card.GetCardNumber()} {card.GetCardAmount()}");
        }

    }
}