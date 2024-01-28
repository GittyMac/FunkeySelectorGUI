using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace FunkeySelector
{
    static class CustomF
    {
        public static uint WM_COPYDATA = 0x004A;

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);

        [StructLayout(LayoutKind.Sequential)]
        public struct COPYDATASTRUCT
        {
            public IntPtr dwData;
            public int cbData;
            public IntPtr lpData;
        }

        // The FunkeyIDs and other information about funkeys can be found in RadicaGame/data/system/funkeys.rdf
        public static void SetFunkey(string funkeyID)
        {
            if (Program.IsMBMode)
                SendFunkeyViaMB(funkeyID);
            else
                File.WriteAllText("customF.txt", $"funkeyCodeNum={funkeyID}");
            TriggerFunkeySelectionMod();
        }

        public static void SetFunkeyFromFile(string filename)
        {
            if (Program.IsMBMode)
                SendFunkeyViaMB(File.ReadAllText(filename).Replace("funkeyCodeNum=", ""));
            else
                File.Copy(filename, "customF.txt", true);
            TriggerFunkeySelectionMod();
        }

        public static void TriggerFunkeySelectionMod()
        {
            if (Program.IsMBMode) return;

            Process[] processes = Process.GetProcessesByName("UBFunkeys");
            if (processes.Length == 0) return;
            // Close the main window to trigger the mod
            processes[0].CloseMainWindow();
        }

        public static void SendFunkeyViaMB(string funkeyID) 
        {
            string idtosend = "FFFFFFFF" + funkeyID;

            //Tries to find an instance of U.B. Funkeys
            IntPtr gamePtr = IntPtr.Zero;
            if (Process.GetProcessesByName("UBFunkeys").Length > 0)
                gamePtr = FindWindow("TMainForm", "U.B. Funkeys");
            else if (Process.GetProcessesByName("OpenFK").Length > 0)
                gamePtr = FindWindow(null, "OpenFK");

            if (gamePtr == IntPtr.Zero)
            {
                MessageBox.Show("There is no instance of U.B. Funkeys currently running.", "FunkeySelectorGUI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                IntPtr ptrCopyData = IntPtr.Zero;
                try
                {
                    COPYDATASTRUCT copyData = new COPYDATASTRUCT
                    {
                        dwData = new IntPtr(238164658), //A strange data type that's required for the game to switch the Bitty.
                        cbData = idtosend.Length + 1,
                        lpData = Marshal.StringToHGlobalAnsi(idtosend)
                    };

                    ptrCopyData = Marshal.AllocCoTaskMem(Marshal.SizeOf(copyData));
                    Marshal.StructureToPtr(copyData, ptrCopyData, false);

                    SendMessage(gamePtr, WM_COPYDATA, IntPtr.Zero, ptrCopyData);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "FunkeySelectorGUI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (ptrCopyData != IntPtr.Zero)
                        Marshal.FreeCoTaskMem(ptrCopyData);
                }
            }
        }
    }
}
