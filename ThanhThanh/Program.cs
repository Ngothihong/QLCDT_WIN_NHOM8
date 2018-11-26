using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using System.IO;
using System.Text;

namespace ThanhThanh
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
            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            Application.Run(new Form1());

        }
        static void ghifile()
        {
            Int64 x;

            try
            {
                //Open the File
                StreamWriter sw = new StreamWriter("C:\\Test1.txt", true, Encoding.ASCII);

                //Writeout the numbers 1 to 10 on the same line.
                for (x = 0; x < 10; x++)
                {
                    sw.Write(x);
                }

                //close the file
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
     
    }
}
