using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Threading;

namespace desk
{
    static class Program
    {
        [DllImport("user32.dll")]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        static Mutex mutex = new Mutex(true, "{ca34a70a-3cfa-4b42-8f12-58cef9d6b8d8}");

        [STAThread]
        static void Main()
        {
            if (mutex.WaitOne(TimeSpan.Zero, true))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
                mutex.ReleaseMutex();
            }
            else
            {
                // Bring existing instance to the front
                IntPtr hWnd = FindWindow(null, "Personalization");
                if (hWnd != IntPtr.Zero)
                {
                    SetForegroundWindow(hWnd);
                }
            }
        }
    }
}