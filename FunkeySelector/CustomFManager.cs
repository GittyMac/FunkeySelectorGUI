using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace FunkeySelector
{
    class CustomFManager
    {
        public void setFunkey(string funkeyCodeNum) //This is the code to switch Funkeys, funkeyCodeNum is the code defined in funkeys.rdf.
        {
            using (StreamWriter writetext = new StreamWriter("customF.txt"))
            {
                writetext.Write("funkeyCodeNum=" + funkeyCodeNum); //Creates the customF.txt
            }
            if (Properties.Settings.Default.wineCompat == false) //Checks if Wine/Mono compatibility is not enabled.
            {
                Process[] pname = Process.GetProcessesByName("UBFunkeys");
                if (pname.Length == 0) //Prevents crashing if UBFunkeys.exe isn't running.
                {
                }
                else Process.GetProcessesByName("UBFunkeys")[0].CloseMainWindow(); //Closes the game to trigger the mod.
            }
            //It saves a lot of time to have a simple function to call rather than individual statements.
        }

        public void changeToNoHub() //This will change the main.swf to the No Hub mod.
        {

        }

        public void changeToHub() //This will change the main.swf to the default Hub mode.
        {

        }
    }
}
