using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuestBookLibrary.Models;

// Capture the information about each guest (assumption is at least one guest and unknown maximum)
// Info to capture: First name, last name, message to the host
// Once done, loop through each guest and print their info

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<GuestModel> guests = new List<GuestModel>(); // this will hold all of the guests (can be one or more guests)
            string moreGuestsComing = "";

            do
            {
                GuestModel guest = new GuestModel(); // holds one guest

                Console.Write("What is your first name: ");
                guest.FirstName = Console.ReadLine();

                // Assuming that name given is correct

                Console.Write("What is your last name: ");
                guest.LastName = Console.ReadLine();

                // Same assumption

                Console.Write("What is your message to the host: ");
                guest.MessageToHost = Console.ReadLine();

                Console.Write("Are more guests coming (yes/no): ");
                moreGuestsComing = Console.ReadLine();

                guests.Add(guest); // add the guest to the guests list

                Console.Clear();
            }
            while (moreGuestsComing.ToLower() == "yes");

            foreach (GuestModel guest in guests)
            {
                Console.WriteLine(guest.GuestInfo);
            }

            Console.ReadLine();
        }
    }
}
