public static class Ex03
{
    public static void Run()
    {
        int currentAssignments = 5;

        int[] sophiaScores = [93, 87, 98, 95, 100];
        int[] nicolasScores = [80, 83, 82, 88, 85];
        int[] zahirahScores = [84, 96, 73, 85, 79];
        int[] jeongScores = [90, 92, 98, 100, 97];

        int sophiaSum = 0;
        int nicolasSum = 0;
        int zahirahSum = 0;
        int jeongSum = 0;

        decimal sophiaScore;
        decimal nicolasScore;
        decimal zahirahScore;
        decimal jeongScore;

        foreach (int scores in sophiaScores)
        {
            sophiaSum += scores;
        }
        
        foreach (int scores in nicolasScores)
        {
            nicolasSum += scores;
        }

        foreach (int scores in zahirahScores)
        {
            zahirahSum += scores;
        }

        foreach (int scores in jeongScores)
        {
            jeongSum += scores;
        }

        sophiaScore = (decimal)sophiaSum / currentAssignments;
        nicolasScore = (decimal)nicolasSum / currentAssignments;
        zahirahScore = (decimal)zahirahSum / currentAssignments;
        jeongScore = (decimal)jeongSum / currentAssignments;

        Console.WriteLine("Student\t\tGrade\n");
        Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA");
        Console.WriteLine("Nicolas:\t" + nicolasScore + "\tB");
        Console.WriteLine("Zahirah:\t" + zahirahScore + "\tB");
        Console.WriteLine("Jeong:\t\t" + jeongScore + "\tA");
    }
}


