using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUITest
{
    internal static class Program
    {
        static Form1 form;
        static Timer timer;

        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Console.WriteLine("aaa");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form = new Form1();
            Application.Run(form);

            timer = new Timer();
            timer.Tick += new EventHandler(loop);
            timer.Interval = 1000;

            timer.Start();
            Console.WriteLine("kajkaj");

            Application.DoEvents();

        }

        public static void loop(Object myObject,EventArgs myEventArgs)
        {
            form.Refresh();
            form.x += 10;
            Console.WriteLine(form.x);
            if (form.x > 500) timer.Stop();
        }
    }
}
