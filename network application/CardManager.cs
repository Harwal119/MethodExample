namespace network_application
{
    public class CardManager
    {
        List<Card> asd = new List<Card>();

        public void GetCards(double amount)
        {
          Card adf =new Card();
          adf.Amount = amount;
          adf.SerialNumber =  GeneratSerialNumber();
          adf.pin =  GeneratPin();
        }
        private string GeneratSerialNumber()
        {
          Random rand = new Random();
          string  num = (rand.Next(1000, 9999)).ToString();
          return "S/N" + num;
        }
          private string GeneratPin()
          {
            Random rand = new Random();
            int  num = (rand.Next(1000, 9999));
            return "Pin" + num;
          }

          private string GeneratAmount()
          {
            Random rand = new Random();
            int  num = (rand.Next(1000, 9999));
            return "Pin" + num;
          }
    }
}