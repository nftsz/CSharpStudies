public static class Ex03
{
    public static void Run()
    {
        int currentAssignments = 5;

        int[] sophiaScores = [93, 87, 98, 95, 100];
        int[] nicolasScores = [80, 83, 82, 88, 85];
        int[] zahirahScores = [84, 96, 73, 85, 79];
        int[] jeongScores = [90, 92, 98, 100, 97];

        string[] studentNames = ["Sophia", "Nicolas", "Zahira", "Jeong"];

        int[] studentScores = new int[5];

        Console.WriteLine("Student\t\tGrade\n");

        foreach (string name in studentNames)
        {
            string currentStudent = name;

            if (currentStudent == "Sophia")
            {
                studentScores = sophiaScores;
            }
            else if (name == "Nicolas")
            {
                studentScores = nicolasScores;
            }
            else if (name == "Zahira")
            {
                studentScores = zahirahScores;
            }
            else if (name == "Jeong")
            {
                studentScores = jeongScores;
            }

            int sumAssignmentScores = 0;
            decimal currentStudentGrade = 0;

            foreach (int score in studentScores)
            {
                sumAssignmentScores += score;
            }

            currentStudentGrade = (decimal)(sumAssignmentScores) / currentAssignments;

            Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t?");

        }
    }
}


