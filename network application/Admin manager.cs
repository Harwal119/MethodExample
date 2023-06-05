using networkapplication;

namespace network_application
{
    public class Adminmanager
    {
        // Admin[] list = new Admin[2];
        List<Admin> admin = new List<Admin>();

        public void CreateAdmin(string firstName, string LastName, string email, string phoneNumber, string pin )
        {
            Admin asd = new ();
            asd.FirstName = firstName;
            asd.LastName = LastName;
            asd.Email = email;
            asd.Pin = pin;
            asd.PhoneNumber = phoneNumber;
            asd.StaffNumber = GenerateStaffNumber();
            admin.Add(asd);

                // for(int i = 0; i < list.Length; i++)
                // {
                //    if(list[i] == null)
                //    {
                //     list[i] = admin;
                //     break;
                //    }
                // }
        }
          private string GenerateStaffNumber()
          {
            Random rand = new Random();
            int num = (rand.Next(1000, 9999));
            return "CLH/ADM/" + num;
          }

    }
}