using System.ComponentModel.DataAnnotations.Schema;

public class GoalManager
{
    private int _totalScore;
    private List<Goal> _goals = new List<Goal>();

    public List<Goal> CreateGoal()
    {
        string goalChoice = "";
        
        while (goalChoice != "1" && goalChoice != "2" && goalChoice != "3")
        {
            Console.WriteLine("1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal");
            Console.Write("Which type of goal would you like to create? ");
            goalChoice = Console.ReadLine();

            if (goalChoice == "1")
            {
                Console.Write("What is the name of your goal? ");
                string name = Console.ReadLine();

                Console.Write("Please give a short description of it: ");
                string description = Console.ReadLine();

                Console.Write("How many points will this goal be worth? ");
                int points = int.Parse(Console.ReadLine());

                SimpleGoal simple = new SimpleGoal(name, description, points);
                _goals.Add(simple);
            }

            else if (goalChoice == "2")
            {
                Console.Write("What is the name of your goal? ");
                string name = Console.ReadLine();

                Console.Write("Please give a short description of it: ");
                string description = Console.ReadLine();   

                Console.Write("How many points will each completion be worth? ");
                int points = int.Parse(Console.ReadLine());

                EternalGoal eternal = new EternalGoal(name, description, points);
                _goals.Add(eternal);
            }

            else if (goalChoice == "3")
            {
                Console.Write("What is the name of your goal? ");
                string name = Console.ReadLine();

                Console.Write("Please give a short description of it: ");
                string description = Console.ReadLine(); 

                Console.Write("How many times do you want to complete this goal? ");
                int timesToComplete = int.Parse(Console.ReadLine());

                Console.Write("How many points will each completion be worth? ");
                int points = int.Parse(Console.ReadLine());

                Console.Write("How many bonus points will the full completion be worth? ");
                int bonusPoints = int.Parse(Console.ReadLine());

                ChecklistGoal checklist = new ChecklistGoal(name, description, points, bonusPoints, timesToComplete);
                _goals.Add(checklist);
            }
            else
            {
                Console.WriteLine("Please choose an option from the menu.");
                Console.WriteLine();
            }
        }
        Console.WriteLine("Your goal has been created!");
        return _goals;
    }
    public void SaveGoals()
    {
        Console.Write("Enter the name you want your file saved as: ");
        string filename = Console.ReadLine();
        
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Goal g in _goals)
            {
                outputFile.WriteLine(g.SaveGoal());
            }
        }
        Console.WriteLine("Your goals have been saved.");
    }

    public List<Goal> LoadGoals()
    {
        Console.Write("Enter the name of the file you want loaded: ");
        string filename = Console.ReadLine();
        
        _goals.Clear();

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            if (parts[0] == "ChecklistGoal")
            {
                string goalName = parts[1];
                string desc = parts[2];
                int goalPoints = int.Parse(parts[3]);
                int bonus = int.Parse(parts[4]);
                bool isComplete = bool.Parse(parts[5]);
                int complete = int.Parse(parts[6]);
                int completed = int.Parse(parts[7]);
                int earned = int.Parse(parts[8]);

                ChecklistGoal checklist = new ChecklistGoal(goalName, desc, goalPoints, bonus, complete);
                checklist.SetIsComplete(isComplete);
                checklist.SetTimesCompleted(completed);
                checklist.SetEarnedPoints(earned);
                
                _goals.Add(checklist);
            }

            else if (parts[0] == "EternalGoal")
            {
                string goalName = parts[1];
                string desc = parts[2];
                int goalPoints = int.Parse(parts[3]);
                bool isComplete = bool.Parse(parts[4]);
                int completed = int.Parse(parts[5]);
                int earned = int.Parse(parts[6]);

                EternalGoal eternal = new EternalGoal(goalName, desc, goalPoints);
                eternal.SetTimesCompleted(completed);
                eternal.SetEarnedPoints(earned);
                
                _goals.Add(eternal);
            }

            else if (parts[0] == "SimpleGoal")
            {
                string goalName = parts[1];
                string desc = parts[2];
                int goalPoints = int.Parse(parts[3]);
                bool isComplete = bool.Parse(parts[4]);
                int earned = int.Parse(parts[5]);

                SimpleGoal simple = new SimpleGoal(goalName, desc, goalPoints);
                simple.SetIsComplete(isComplete);
                simple.SetEarnedPoints(earned);

                _goals.Add(simple);
            }
        }
        return _goals;
    }

    public void GetScore()
    {
        int score = 0;
        foreach (Goal goal in _goals)
        {
            score += goal.GetEarnedPoints();
        }
        _totalScore = score;
    }

    public void DisplayGoals()
    {
        int i = 0;

        foreach (Goal myGoal in _goals)
        {   
            i += 1;
            Console.WriteLine($"{i}. {myGoal.DisplayGoal()}");
        }

        if (_goals.Count() == 0)
        {
            Console.WriteLine("You don't have any current goals.");
        }
    }
    public void DisplayScore()
    {
        GetScore();
        Console.WriteLine($"You have {_totalScore} total points");
        Thread.Sleep(1000);
        ShowPrize();
    }

    public void RecordGoalEvent()
    {
        DisplayGoals();

        Console.Write("Which goal would you like to record? ");
        int userGoal = int.Parse(Console.ReadLine());

        _goals[userGoal-1].RecordEvent();
        DisplayScore();
    }

    public void ShowPrize()
    {
        if (_totalScore >= 5000)
        {
            Console.WriteLine("Congratulations, you reached 5000 points!");
            Thread.Sleep(300);
            FireworksPrize();

        }
        else if (_totalScore >= 2500)
        {
            Console.WriteLine("Congratulations, you reached 2500 points!");
            Thread.Sleep(300);
            BallPrize();

        }
        else if (_totalScore >= 1000)
        {
            Console.WriteLine("Congratulations, you reached 1000 points!");
            Thread.Sleep(300);
            CherryPrize();
        }
        else
        {
            Console.WriteLine("You haven't earned a prize yet, but keep completing goals!");
        }
        Thread.Sleep(1000);
    }

    private void CherryPrize()
    {
        Console.WriteLine("You earned some cherries!");
        Thread.Sleep(1000);
        Console.Clear();

        Console.WriteLine("   /");
        Console.WriteLine("  /\\");
        Console.WriteLine(" /  \\");
        Console.WriteLine("### ###");
        Console.WriteLine("### ###");

        Thread.Sleep(2000);
    }

    private void BallPrize()
    {
        Console.WriteLine("You earned a bouncy ball!");
        Thread.Sleep(1000);

        for (int i = 0; i < 3; i++)
        {
            Console.Clear();
            Console.WriteLine("°");
            Thread.Sleep(500);

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("°");
            Thread.Sleep(500);

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("°");
            Thread.Sleep(500);

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("°");
            Thread.Sleep(500);
        }
    }

    private void FireworksPrize()
    {
        Console.WriteLine("You earned fireworks!");
        Thread.Sleep(1000);

        for (int i = 0; i < 5; i++)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("  *  ");
            Console.WriteLine();
            Console.WriteLine();
            Thread.Sleep(500);
                
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(" \\|/ ");
            Console.WriteLine(" -*- ");
            Console.WriteLine(" /|\\ ");
            Console.WriteLine();
            Thread.Sleep(500);
                
            Console.Clear();
            Console.WriteLine("  |  ");
            Console.WriteLine("\\   /");
            Console.WriteLine("- * -");
            Console.WriteLine("/   \\");
            Console.WriteLine("  |  ");
            Thread.Sleep(500);
            }        
    }
}