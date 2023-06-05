namespace RechargeCardApp
{
    public class RechargeCard
    {
        private string serialNumber;
        private string cardType;
        private int cardNumber;
        private decimal cardAmount;


        public void SetSerialNumber()
        {
            string serialNumber =  GenerateSerialNumber();
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

        
     public void SetCardNumber()
        {
            int cardNumber = GeneratCardNumber();
            this.cardNumber = cardNumber;
        }

        public int GetCardNumber()
        {
            return cardNumber;
        }

        public void SetCardAmount(decimal cardAmount)
        {
            this.cardAmount = cardAmount;
        }

        public decimal GetCardAmount()
        {
            return cardAmount;
        }
        public string GenerateSerialNumber()
        {
            Random rand = new Random();
            string num = rand.Next(1000,9999).ToString();
            return "S/N" + num;
        }
        public int GeneratCardNumber()
        {
            Random random = new Random();
            int k = random.Next(10000,999999);
            return k;
            // 08164800162
        }

    }

        
    
}