namespace ListyIterator;

public class StartUp
{
    static void Main()
    {
        string[] firstLine = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries);

        ListyIterator<string> listy = new(firstLine.Skip(1).ToList());

        string input;
        while ((input = Console.ReadLine()) != "END")
        {
            string[] tokens = input
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string command = tokens[0];

            if (command == "Move")
            {
                Console.WriteLine(listy.Move());
            }
            else if (command == "Print")
            {
                try
                {
                    listy.Print();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Invalid Operation!");
                }
            }
            else if (command == "PrintAll")
            {
                try
                {
                    listy.PrintAll();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Invalid Operation!");
                }
            }
            else if (command == "HasNext")
            {
                Console.WriteLine(listy.HasNext());
            }
        }
    }
}