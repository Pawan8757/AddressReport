using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class DeterminingAddress
    {
    public void AddressEnquiry()
    {
            string[] contact = new string[8];
            Console.WriteLine("Enter the First Name");
            contact[0] = Console.ReadLine();
            Console.WriteLine("Enter the Last Name");
            contact[1] = Console.ReadLine();
            Console.WriteLine("Enter the Address");
            contact[2] = Console.ReadLine();
            Console.WriteLine("Enter the City Name");
            contact[3] = Console.ReadLine();
            Console.WriteLine("Enter the State Name");
            contact[4] = Console.ReadLine();
            Console.WriteLine("Enter the Zip Code");
            contact[5] = Console.ReadLine();
            Console.WriteLine("Enter the Phone Number");
            contact[6] = Console.ReadLine();
            Console.WriteLine("Enter the Email");
            contact[7] = Console.ReadLine();
            
            Console.WriteLine("First Name Last Name Address City Name State Name Zip Code Phone Number Email");

            for(int i = 0; i < contact.Length; i++)
            {
                contact[i] = Console.ReadLine();
            }
            Console.WriteLine("........");
        }
    }
}
