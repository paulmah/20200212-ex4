using System;

namespace CSharp_Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string someInput = getInput();
            someInput = frontSadFace(someInput);
            someInput = endSmileyFace(someInput);
            Console.WriteLine(someInput);
        }
        static string getInput()
        {
            Console.WriteLine("enter some random txt");
            string someInput1 = Console.ReadLine();
            return someInput1;
        }

        static string frontSadFace( string outputLine )
//3456789012345678901234567890123456789012345678901234567890
        {
            outputLine = ":("+outputLine;
            return outputLine;

        }
        static string endSmileyFace( string outputLine )
        {
            outputLine = outputLine+"):";
            return outputLine;
        }

    }

}
