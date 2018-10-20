using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_SimpleCalculator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           

            // Add three font files to the private collection.
            // privateFontCollection.AddFontFile(path);
            //privateFontCollection.AddFontFile("D:\\systemroot\\Fonts\\CourBI.ttf");
            //privateFontCollection.AddFontFile("D:\\systemroot\\Fonts\\TimesBD.ttf");


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CalculatorForm());
        }

        
    }
}
