using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorlockNet
{
    internal class AdminConsoleView
    {

        // Internal State --- ATTRIBUTES
        public int idUsr;
        public string name;
        public string lastName;
        public string tagRfidNmr;
        public bool isUsrActive;
        public string passwordPinPad;

        // Dynamic Behavior ==== Methods --->  actions

        public void getUserInfo()
        {
            // Print user infos, his satatus, all the infos relative from him registered on the system
            // (maybe we need return this infos ? void can be not valuable)

        }
        public void registerUserInfo()
        {
            // here we can register the user on our system.
            // ask to insert his data, generate an id. 
            // ask to approach a RFID on the sensor
            // ask to a personal pin: (validation only numbers ?)
            // ask if the user can be enabled or not: Yes or No ?
            // Send a message. User registered and enabled on the system / or just registered (bool ?)

        }
        public void unregisterUserInfo() 
        {
            
        }
        public void registerAdminConsole() 
        {
            // here we can register the user on our system.
            // ask to insert his data, generate an id. 
            // ask if the user can be enabled or not: Yes or No ?
            // Send a message. User registered and enabled on the system / or just registered (bool ?)

        }
        public void getLogsApplication() 
        {
            //extract which type of log ?
            // user ? Name, tag, hour tag authorized ?
            // log register ? Users registered, when registered who registered, is enabled and he is a normal user or admin ?
            //devices ? Devices health status, failed tentatives, screeen verbose ? etc
            // export to a PDF ? report


        }

    }
}
