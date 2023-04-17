using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;

namespace Trainer
{
    class Program
    {

        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            bool found = false;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            Mem c = new Mem();
            c.OpenProcess("FTLGame");

            found = c.OpenProcess("FTLGame");
            if (found)
            {
                Console.WriteLine("success");
                // lets add maybe a green light to the trainer
            }


            Console.WriteLine("hi");
        }



    }
}
