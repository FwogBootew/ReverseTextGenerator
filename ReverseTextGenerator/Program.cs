using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReverseTextGenerator
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            RunProgram();
        }

        //Methods

        static void RunProgram()
        {
            Console.WriteLine(Lang["Title"]);
            Console.WriteLine(Lang["Prompt"]);
            string product = ReverseMessage(Console.ReadLine());
            Console.Clear();
            Console.WriteLine(Lang["Title"]);
            Console.WriteLine(string.Format(Lang["Result"], ReverseMessage(product), product));
            Console.WriteLine(Lang["KeyPrompt"]);
            Clipboard.SetText(product);
            Console.ReadKey();
            Console.Clear();
            RunProgram();
        }

        static string ReverseMessage(string message)
        {
            char[] msgChars = message.ToCharArray();
            Array.Reverse(msgChars);
            string reversedMsg = "";
            foreach (var Char in msgChars)
            {
                reversedMsg += Char;
            }
            return reversedMsg;
        }

        //Data

        static Dictionary<string, string> Lang = new Dictionary<string, string>
        {
            {"Title", "Reverse Text Generator."},
            {"Prompt", "Please input text to reverse, and press enter."},
            {"Result", "Reversed text {0} to {1}. Set clipboard text to product."},
            {"KeyPrompt", "Press any key to reverse more text."}
        };
    }
}
