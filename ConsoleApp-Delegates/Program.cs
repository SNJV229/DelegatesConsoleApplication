using System;
using System.Data;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using static Program.firstClass;

namespace Program
{

    public delegate void delegateConsoleReader(string str);

    public class firstClass
    { 
        public static void Main()
        {
            ConsoleReader reader = new ConsoleReader();
            IconsoleReader display = new displayClass();
            //displayClass display = new displayClass();
            delegateConsoleReader dOnWord = new delegateConsoleReader(display.onWord);
            delegateConsoleReader dOnNumber = new delegateConsoleReader(display.onNumber);
            delegateConsoleReader dOnJunk = new delegateConsoleReader(display.onJunk);
            string str;
            while (true)
            {
                str = Console.ReadLine();
                reader.run(str, dOnWord, dOnNumber, dOnJunk);
            }
        }
    }

    public interface IconsoleReader
    {
        public void onWord(string str);
        public void onNumber(string str);
        public void onJunk(string str);

    }

    public class ConsoleReader
    {

        public void run(String str, delegateConsoleReader dOnWord, delegateConsoleReader dOnNumber, delegateConsoleReader dOnJunk)
        {
                if (str.All(char.IsLetter))
                {
                    dOnWord(str);
                }
                else if (str.All(char.IsDigit))
                {
                    dOnNumber(str);
                }
                else if (str.All(char.IsLetterOrDigit))
                {
                    dOnWord(str);
                }
                else
                {
                    dOnJunk(str);
                }
        }

    }

    public class displayClass : IconsoleReader
    {
        public void onWord(string str)
        {
            Console.WriteLine("Inside onWord"); 
        }

        public void onNumber(string str)
        {
            Console.WriteLine("Inside onNumber"); 
        }

        public void onJunk(string str)
        {
            Console.WriteLine("Inside onJunk");
        }
    }

}
