using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using TaskManager.TaskDatabase;
using DevExpress.Xpo.DB;
using DevExpress.Xpo;

namespace TaskManager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DevExpress.Skins.SkinManager.EnableFormSkins();

            ConnectionHelper.Connect(AutoCreateOption.None);
            XpoDefault.Session = new Session();

            Application.Run(new Form1());
        }
    }
}