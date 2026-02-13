// number of assignments per student
int examAssignments = 5;

int[] sophiaScores = [93, 87, 98, 95, 100, 94, 90];
int[] nicolasScores = [80, 83, 82, 88, 85, 90];
int[] zahirahScores = [84, 96, 73, 85, 79, 89, 89, 89];
int[] jeongScores = [90, 92, 98, 100, 97, 96];
int[] beckyScores = [92, 91, 90, 91, 92, 92, 92];
int[] chrisScores = [84, 86, 88, 90, 92, 94, 96, 98];
int[] ericScores = [80, 90, 100, 80, 90, 100, 80, 90];
int[] gregorScores = [91, 91, 91, 91, 91, 91, 91];

string[] studentNames = ["Sophia", "Nicolas", "Zahira", "Jeong",
                                "Becky", "Chris", "Eric", "Gregor"];

// will store the current student's grades in the loop
int[] studentScores = new int[5];

string currentStudentLetterGrade = "";

Console.WriteLine("Student\t\tGrade\n");

// iterate through each student
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
    else if (name == "Becky")
    {
        studentScores = beckyScores;
    }
    else if (name == "Chris")
    {
        studentScores = chrisScores;
    }
    else if (name == "Eric")
    {
        studentScores = ericScores;
    }
    else if (name == "Gregor")
    {
        studentScores = gregorScores;
    }
    else
    {
        continue;
    }

    int sumAssignmentScores = 0;
    decimal currentStudentGrade = 0;
    int gradedAssignments = 0;

    // calculate the total score
    foreach (int score in studentScores)
    {
        gradedAssignments++;

        if (gradedAssignments <= examAssignments)
        {
            sumAssignmentScores += score;
        }
        else
        {
            sumAssignmentScores += score / 10;
        }
    }

    // compute the final average
    currentStudentGrade = (decimal)sumAssignmentScores / examAssignments;

    if (currentStudentGrade >= 97)
    {
        currentStudentLetterGrade = "A+";
    }
    else if (currentStudentGrade >= 93)
    {
        currentStudentLetterGrade = "A";
    }
    else if (currentStudentGrade >= 90)
    {
        currentStudentLetterGrade = "A-";
    }
    else if (currentStudentGrade >= 87)
    {
        currentStudentLetterGrade = "B+";
    }
    else if (currentStudentGrade >= 83)
    {
        currentStudentLetterGrade = "B";
    }
    else if (currentStudentGrade >= 80)
    {
        currentStudentLetterGrade = "B-";
    }
    else if (currentStudentGrade >= 77)
    {
        currentStudentLetterGrade = "C+";
    }
    else if (currentStudentGrade >= 73)
    {
        currentStudentLetterGrade = "C";
    }
    else if (currentStudentGrade >= 70)
    {
        currentStudentLetterGrade = "C-";
    }
    else if (currentStudentGrade >= 67)
    {
        currentStudentLetterGrade = "D+";
    }
    else if (currentStudentGrade >= 63)
    {
        currentStudentLetterGrade = "D";
    }
    else if (currentStudentGrade >= 60)
    {
        currentStudentLetterGrade = "D-";
    }
    else
    {
        currentStudentLetterGrade = "F";
    }

    Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();


