using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorlockNet
{
    internal class User
    {
        // Internal State --- ATTRIBUTES
        public int idUsr;
        public string name;
        public string lastName;
        public string tagRfidNmr;
        public bool isUsrActive;
        public string passwordPinPad;


        // Dynamic Behavior ==== Methods --->  actions

        public void readUserRfidTag() 
        {
            // here when the user approach their rfid card:
            // we read this card, get his infos
            // receive this autorization from  the application.
            // call the respective method - class to receive this return
            Console.WriteLine("approach your tag: ");
            // get the tag info here.

            // if tag matcches with user. Grant access and inform

            Console.WriteLine("Access Granted");

            // if not matches inform.

            Console.WriteLine("Tag not recognized, please try again");

        }

        public void readPersonalPin() 
        {
            // here when the user approach their rfid card: and aafter 3 times not recogniized or failed the check
            // ask the user to insert his personal pin on the system.
            // receive this autorization from  the application. (if personal pin is valid - grant access) if not sent message not authorized.
            // call the respective method - class to receive this return


            Console.WriteLine("Please enter your Pin: ");

            // if not valid inform not valid.


        }



    }
}
