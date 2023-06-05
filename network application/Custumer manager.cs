using networkapplication;

namespace network_application
{
    public class Custumermanager
    {
        List<Custumer> customer = new List<Custumer>();

        public void CreateCustumer(string firstName, string LastName, string email, string phoneNumber, string pin)
        {
            Custumer asd = new ();
            asd.FirstName = firstName;
            asd.LastName = LastName;
            asd.Email = email;
            asd.Pin = pin;
            asd.PhoneNumber = phoneNumber;
            asd.AccountBalance = 0.00;
            customer.Add(asd);
        }
    }
}