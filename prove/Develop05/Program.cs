using System;

/* 
I exceeded requirements for this assignment by adding prizes when someone reaches 1000, 2500, and 5000 points.
These prizes are pictures and animations that display whenever someone has points equal to or exceeding their 
required points.
*/
class Program
{
    static void Main(string[] args)
    {
        string choice = "";
        GoalManager myManager = new GoalManager();

        while (choice != "7")
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to the Goal Manager!");
            Console.WriteLine();
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create New Goal\n2. View Goals\n3. Save Current Goals\n4. Load Goals From File\n5. Record Event\n6. View Total Score\n7. Quit");
            Console.Write("Choose an option from the menu: ");
            choice = Console.ReadLine();
            Console.WriteLine();

            if (choice == "1")
            {
            myManager.CreateGoal();
            }

            else if (choice == "2")
            {
                myManager.DisplayGoals();
            }

            else if (choice == "3")
            {
                myManager.SaveGoals();
            }

            else if (choice == "4")
            {
                myManager.LoadGoals();
                myManager.DisplayGoals();
            }

            else if (choice == "5")
            {
                myManager.RecordGoalEvent();
            }

            else if (choice == "6")
            {
                myManager.DisplayScore();
            }
            
            else if (choice == "7")
            {
             Console.WriteLine("Goodbye");   
            }

            else
            {
                Console.WriteLine("Please choose an option from the menu.");
            }
        }
    }
}