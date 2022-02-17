using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Console = Colorful.Console;
using System.Configuration;

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Debug.WriteLine("Write something to the output window...");
            Console.WriteLine("Hello world!");
            Console.WriteLine("Program has finished. Press enter to quit.", Color.Aquamarine);

            string greeting = Properties.Settings.Default.GreetingMessage;
            Console.WriteLine(greeting);

            if(Properties.Settings.Default.InAGoodMood)
                Console.WriteLine(Properties.Settings.Default.AngryMessage);

            string tiredMessage = ConfigurationManager.AppSettings["tiredMessage"];
            Console.WriteLine(tiredMessage);


            Console.ReadKey();            
        }
    }
}
