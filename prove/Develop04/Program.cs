using System;
/* 
I exceeded requirements for this assignment by adding a new class/activity that has the user picture
an image and reflect on the different aspects of their image. I also created a subclass called PromptActivity
that holds the common member variables and methods for the three activities that use lists.
*/
class Program
{
    static void Main(string[] args)
    {
        int choice = 10;

        while (choice != 5)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Midfulness Program!");
            Console.WriteLine("\nPlease choose an activity from the menu:");

            Console.WriteLine("1. Breathing Actvity \n2. Reflection Activity \n3. Listing Activity \n4. Imagery Activity \n5. Quit");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                BreathingActivity breathing = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly.\nClear your mind and focus on your breathing.");

                breathing.DisplayBreatheMessage();
            }

            else if (choice == 2)
            {
                ReflectionActivity reflection = new ReflectionActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience.\nThis will help you recognize the power you have and how you can use it in other aspects of your life.");

                reflection.DisplayMessages();
            }

            else if (choice == 3)
            {
                ListingActivity listing = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

                listing.GetAnswers();
            }

            else if (choice == 4)
            {
                ImageryActivity imagery = new ImageryActivity("Imagery Activity", "This activity will help you clear your mind by having you focus on a simple image and describe it.");

                imagery.DisplayImages();    
            }

            else if (choice != 5)
            {
                Console.WriteLine("That is not a valid option");
                Thread.Sleep(1000);
            }
        }

    }
}