namespace RechargeCardApp
{
    public class RechargeCardManager
    {
        // declaring an array of recharge card :
    //    public Recharge[] cards =new Recharge[10];
        public List<RechargeCard> cards =new List<RechargeCard>();
        //passing an instance of RechargeCard as a parameter of the method: 
        public void AddRechargeCardToList(RechargeCard  rechargeCard )
        {
          cards.Add(rechargeCard);
        }
        

        public void CreateRechargeCard()
        {

            // RechargeCard rechargeCard = new RechargeCard();
            // rechargeCard.SetSerialNumber();
            // rechargeCard.SetCardType("MTN");
            // rechargeCard.SetCardAmount(200.00M);
            // rechargeCard.SetCardNumber();

            //call the method that add card to list
            // AddRechargeCardToList(rechargeCard);

            
            
            Console.Write("Enter amount of card Number You want:");
            int amount = int.Parse(Console.ReadLine());
            for(int i=0; i < amount; i++)
            {
                RechargeCard rechargeCard = new RechargeCard();
                rechargeCard.SetSerialNumber();
                rechargeCard.SetCardType("MTN");
                rechargeCard.SetCardAmount(200.00M);
                rechargeCard.SetCardNumber();

                //call the method that add card to list
                cards.Add(rechargeCard);
            }
        }

    }
}