//
// Copyright 2013 KCA Software LLC. All rights reserved.
//

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KCASoft
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SplashScreen.ShowSplashScreen(Strings.S.WAIT_MSG);

            if (!KCASoftCL.ValidateLicense())
            {
                SplashScreen.CloseSplashScreen();

                KCASoftCL.Activate();
                MessageBox.Show(Strings.S.BARCODE_NOT_ENABLED, Strings.S.FREE_EDITION_TITLE);
                return;
            }
            else
            {
                SplashScreen.CloseSplashScreen();
            }

            // Initialize Analytics
            if (KCASoftCL.InitializeAnalytics() == -1)
                return; // something wrong with the initializer

            Application.Run(new MainForm());
        }
    }
}
