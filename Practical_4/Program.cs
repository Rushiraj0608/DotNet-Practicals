using System;

namespace Practical_4
{
    class Program
    {
        static void Main(string[] args)
        {
            InfixClass myclass = new InfixClass();
            String infix = " a+b*c-d";
            String postfix;
            myclass.Infixtopostfix(ref infix, out postfix);
            Console.WriteLine("infix string : " + infix);
            Console.WriteLine("postfix string is : " + postfix);
            Console.Read();

        }
    }
}
