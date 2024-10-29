using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorlockNet
{
    internal class ReadCard
    {
        // Internal State --- ATTRIBUTES


        //Here we need to receive and store the infos from the rfid Tag
        public int readRfidCardUsr;
        public bool isValidatedRfid;

        // Dynamic Behavior ==== Methods --->  actions

        //here we need to read the card and matches if this tag is from the user or not. If yes we return a bool if is validated or not 
        public void readRfidCard() 
        {
            
        }
    }
}
