using System;
using System.Windows.Forms;

namespace ServiceDesk_Connect
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.Run(new authorization());
        }
    }
}