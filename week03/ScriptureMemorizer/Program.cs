using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        Reference reference = new Reference("Jeremiah", 29, 11);
        Scripture scripture = new Scripture(reference, "For I know the plans I have for you, says the Lord. They are plans for good and not for evil, to give you a future and a hope.");

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            Console.Write("Press the ENTER key to hide words or type 'Quit' to exit: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);

            if (scripture.AreAllWordsHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                break;
            }
        }
    }
}
