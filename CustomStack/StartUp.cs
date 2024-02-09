using System.Runtime.Intrinsics.X86;

namespace CustomStack;

public class StartIp
{
    static void Main()
    {
        CustomStack<string> stack = new(new List<string>());

        string[] separators = { " ", ", " };
        string input;
        while ((input = Console.ReadLine()) != "END")
        {
            string[] tokens = input
                .Split(separators, StringSplitOptions.RemoveEmptyEntries);

            string command = tokens[0];
            if (command == "Push")
            {
                for (int i = 1; i < tokens.Length; i++)
                {
                    stack.Push(tokens[i]);
                }
            }
            else if (command == "Pop")
            {
                try
                {
                    stack.Pop();
                }
                catch (Exception ex) 
                {
                    Console.WriteLine("No elements");
                }
            }
        }

        foreach (string token in stack)
        {
            Console.WriteLine(token);
        }
        foreach (string token in stack)
        {
            Console.WriteLine(token);
        }
    }
}