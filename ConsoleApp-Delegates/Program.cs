using System;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using static Program.displayClass;

namespace Program
{

    public delegate string delegateConsoleReader();

    public class displayClass
    { 
        public static void Main()
        {
            ConsoleReader reader = new ConsoleReader();
            //displayClass display = new displayClass();
            delegateConsoleReader dOnWord = new delegateConsoleReader(reader.onWord);
            delegateConsoleReader dOnNumber = new delegateConsoleReader(reader.onNumber);
            delegateConsoleReader dOnJunk = new delegateConsoleReader(reader.onJunk);
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
        public string onWord();
        public string onNumber();
        public string onJunk();

        public void run(string str, delegateConsoleReader onWord, delegateConsoleReader onNumber, delegateConsoleReader onJunk);
    }

    public class ConsoleReader : IconsoleReader
    {

        public string onWord()
        {
            return "Inside onWord";
        }

        public  string onNumber()
        {
            return "Inside onNumber";
        }

        public  string onJunk()
        {
            return "Inside onJunk";
        }

        public void run(string str, delegateConsoleReader dOnWord, delegateConsoleReader dOnNumber, delegateConsoleReader dOnJunk)
        {

            if (str.All(char.IsLetter))
            {
                Console.WriteLine(dOnWord.Invoke());
            }
            else if (str.All(char.IsDigit))
            {
                Console.WriteLine(dOnNumber.Invoke());
            }
            else if (str.All(char.IsLetterOrDigit))
            {
                Console.WriteLine(dOnWord.Invoke());
            }
            else
            {
                Console.WriteLine(dOnJunk.Invoke());
            }
        }

    }

}
