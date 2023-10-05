List<string> toDos = new List<string>();

while (true)
{
    Console.WriteLine("Hello!");
    Console.WriteLine("[S]ee all TODOs");
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit");

    string userChoice = Console.ReadLine();
    Console.WriteLine(userChoice);

    if (userChoice == "S" || userChoice == "s")
    {
        if (toDos.Count == 0)
        {
            Console.WriteLine("To Do List is empty");
        }
        else
        {
            for (int i = 0; i < toDos.Count; i++)
            {
                Console.WriteLine($"{i+1}. {toDos[i]}");
            }
        }
    }
    else if (userChoice == "A" || userChoice == "a")
    {
        while (true)
        {
            Console.WriteLine("Enter the TODO description:");
            string description = Console.ReadLine();
            bool inList = toDos.Contains(description);
            if (inList)
            {
                Console.WriteLine("The description must be unique.");
            }
            else
            {
                Console.WriteLine($"TODO successfully added: {description}");
                toDos.Add(description);
                break;
            }
        }
    }
    else if (userChoice == "R" || userChoice == "r")
    {
        if (toDos.Count() == 0)
        {
            Console.WriteLine("To Do List is empty");
        }
        else
        {
            Console.WriteLine("Select the index of the TODO you want to remove:");
            for (int i = 0; i < toDos.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {toDos[i]}");
            }

            int indexToDelete = int.Parse(Console.ReadLine());
            Console.WriteLine($"TODO removed: {toDos[indexToDelete-1]}");
            toDos.RemoveAt(indexToDelete-1);
        }
    }
    else if (userChoice == "E" || userChoice == "e")
    {
        break;
    }
    else
    {
        Console.WriteLine("Invalid choice");
    }
}