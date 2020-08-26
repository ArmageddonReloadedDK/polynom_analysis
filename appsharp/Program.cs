using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appsharp
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>

        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 forma = new Form1();
            Application.Run(forma);

        }

    }

    public static class callback
    {
        public delegate void callbackevent(string s1, string s2, string s3, string s4);
        public static callbackevent callbackeventHandler;
        public delegate void calltext();
        public static calltext calltext1;
        public static calltext calltext2;
        public static calltext calltext3;
        public static calltext calltext4;
        public static string get1 { get; set; }
        public static string get2 { get; set; }
        public static string get3 { get; set; }
        public static string get4 { get; set; }

        public static Boolean flag { get; set; }

    } 

}