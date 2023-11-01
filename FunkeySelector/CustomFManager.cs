using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace FunkeySelector
{
    static class CustomF
    {
        // The FunkeyIDs and other information about funkeys can be found in RadicaGame/data/system/funkeys.rdf
        public static void SetFunkey(string funkeyID)
        {
            File.WriteAllText("customF.txt", $"funkeyCodeNum={funkeyID}");
            TriggerFunkeySelectionMod();
        }

        public static void SetFunkeyFromFile(string filename)
        {
            File.Copy(filename, "customF.txt", true);
            TriggerFunkeySelectionMod();
        }

        public static void TriggerFunkeySelectionMod()
        {
            if (Properties.Settings.Default.wineCompat == true) return;

            Process[] processes = Process.GetProcessesByName("UBFunkeys");
            if (processes.Length == 0) return;
            // Close the main window to trigger the mod
            processes[0].CloseMainWindow();
        }
    }
}
