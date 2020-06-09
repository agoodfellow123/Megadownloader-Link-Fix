using System;

namespace megaConv
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Console.Write("Insert mega link: ");
            try
            {
                string link = Console.ReadLine();
                if (!link.Contains("mega.nz") || !link.Contains("file") && !link.Contains("folder")) { Console.WriteLine("Faulty input!"); Console.ReadLine(); return; }
                while (link.Contains("#")) { link = link.Replace("#", "!"); }
                while (link.Contains("folder/")) { link = link.Replace("folder/", "#F!"); }
                while (link.Contains("file/")) { link = link.Replace("file/", "#!"); }
                System.Windows.Forms.Clipboard.SetText(link);
                Console.WriteLine("Fixed link: " + link + ("\nCopied to clipboard"));
            }
            catch (Exception) { Console.WriteLine("Faulty input!"); }
            Console.ReadLine();
        }
    }
}
