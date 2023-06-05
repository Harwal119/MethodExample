// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using Cards;

ReachargedCard card = new ReachargedCard();
card.SetCardType("MTN");
card.SetSerialNumber("agdfjfh6474746");
// card.SetCardAmount();
Console.WriteLine($"SerialNumber:{card.GetSerialNumber()},CardType:{card.GetCardType()},cardPin:{card.GetCardAmount()}");
