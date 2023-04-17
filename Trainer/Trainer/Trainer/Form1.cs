using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;



namespace Trainer
{
    public partial class Form1 : Form
    {

        public const string WINDOW_NAME = "Robs Trainer 1.0";

        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);

       

        public static RECT rect;

        public struct RECT
        {
            public int left, top, right, bottom;
        }

        bool show = true;


        public static void AddScrap()
        {
            Mem c = new Mem();
            c.OpenProcess("FTLGame");
            c.WriteMemory("base+0051348C,4d4", "int", "99999");

        }

        public static void AddFuel()
        {

            Mem c = new Mem();
            c.OpenProcess("FTLGame");
            c.WriteMemory("base+0051348C,494", "int", "9999");
        }

        public static void AddMissile()
        {
            Mem c = new Mem();
            c.OpenProcess("FTLGame");
            c.WriteMemory("base+0051348C,48,1E8","int","9999");


        }

        public static void AddDrone()
        {
            Mem c = new Mem();
            c.OpenProcess("FTLGame");
            c.WriteMemory("base+0051348C,800", "int", "9999");


        }






        public Form1()
        {

           
            InitializeComponent();

            //Transparent
            this.BackColor = Color.Wheat;
            this.TransparencyKey = Color.Wheat;

            //Borderless
            this.FormBorderStyle = FormBorderStyle.None;

            // Make the windoes start in top left corner
            this.StartPosition = FormStartPosition.Manual;

            //top most
            this.TopMost = true;

            CheckForIllegalCrossThreadCalls = false;

            Thread MenuVisable = new Thread(ShowHideMenu);
            MenuVisable.Start();
        }


        void ShowHideMenu()
        {
            while (true)
            {
                
                if(GetAsyncKeyState(Keys.Insert) < 0 && show == true) // hide
                {
                    this.Hide();
                    show = false;
                    Thread.Sleep(20);
                }
                else if(GetAsyncKeyState(Keys.Insert) < 0 && show == false)
                {
                    this.Show();
                    show = true;
                    Thread.Sleep(20);
                }
                else if(GetAsyncKeyState(Keys.Delete) < 0)
                {
                    Environment.Exit(0);
                    Application.Exit();
                }

                Thread.Sleep(70);
            }

        }
        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Does when clicked
           
        }

 

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //Add Scrap Function
        private void button1_Click(object sender, EventArgs e)
        {
            Form1.AddScrap();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            // end all threads made
            Environment.Exit(0);
            Application.Exit();
        }

        //Add Fuel Function
        private void button2_Click(object sender, EventArgs e)
        {       
            Form1.AddFuel();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }






        private void button3_Click_1(object sender, EventArgs e)
        {
            Form1.AddMissile();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddDrone();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
