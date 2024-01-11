using CashierApp.Data;
using CashierApp.DataAccessor;
using CashierApp.Forms;
using System.Runtime.CompilerServices;

[assembly:InternalsVisibleTo("CashierAppTests")]

namespace CashierApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm(
                new ItemsDBRepository(
                    new DatabaseAccessor()
                    )));
        }
    }
}