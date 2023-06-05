namespace Cards
{
    public class ReachargedCard
    {
        private string serialNumber;
        private string cardType;
        private int cardPin;
        private decimal cardAmount;
        private string companyName; 
        private DateTime dateCreated;
        
        public ReachargedCard(string serialNumber,string cardType,int cardAmount)
        {
            this.serialNumber = serialNumber;
            this.cardType = cardType;
            this.cardAmount = cardAmount;
        }

        public ReachargedCard()
        {
        }

        public void SetSerialNumber(string serialNumber)
        {
            this.serialNumber = serialNumber;
        }

        public string GetSerialNumber()
        {
            return serialNumber;
        }

        public void SetCardType(string cardType)
        {
            this.cardType = cardType;
        }

        public string GetCardType()
        {
            return cardType;
        }

        public void SetCardAmount(decimal SetCardAmount)
        {
            this.cardAmount = cardAmount;
        }

        public decimal GetCardAmount()
        {
            return cardAmount;
        }

        public decimal  GenerateCardAmount()
        {
            Random random = new Random();
            decimal g = random.Next(100,999);
            return g;
        }
    }
}