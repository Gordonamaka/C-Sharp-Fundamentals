/* 
This C# console application is designed to:
- Use arrays to store student names and assignment scores.
- Use a `foreach` statement to iterate through the student names as an outer program loop.
- Use an `if` statement within the outer loop to identify the current student name and access that student's assignment scores.
- Use a `foreach` statement within the outer loop to iterate though the assignment scores array and sum the values.
- Use an algorithm within the outer loop to calculate the average exam score for each student.
- Use an `if-elseif-else` construct within the outer loop to evaluate the average exam score and assign a letter grade automatically.
- decimalegrate extra credit scores when calculating the student's final score and letter grade as follows:
    - detects extra credit assignments based on the number of elements in the student's scores array.
    - divides the values of extra credit assignments by 10 before adding extra credit scores to the sum of exam scores.
- use the following report format to report student grades: 

    Student         Grade

    Sophia:         92.2    A-
    Andrew:         89.6    B+
    Emma:           85.6    B
    Logan:          91.2    A-
*/

decimal examAssignments = 5.0m;

string[] studentNames = ["Sophia", "Andrew", "Emma", "Logan"];

decimal[] sophiaScores = [90, 86, 87, 98, 100, 94, 90];
decimal[] andrewScores = [92, 89, 81, 96, 90, 89];
decimal[] emmaScores = [90, 85, 87, 98, 68, 89, 89, 89];
decimal[] loganScores = [90, 95, 87, 88, 96, 96];

decimal[] studentScores = new decimal[10];

string currentStudentLetterGrade;

// display the header row for scores/grades
// Console.Clear();
Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\n");

/*
The outer foreach loop is used to:
- iterate through student names 
- assign a student's grades to the studentScores array
- sum assignment scores (inner foreach loop)
- calculate numeric and letter grade
- write the score report information
*/
foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;

    else if (currentStudent == "Andrew")
        studentScores = andrewScores;

    else if (currentStudent == "Emma")
        studentScores = emmaScores;

    else if (currentStudent == "Logan")
        studentScores = loganScores;

    decimal sumAssignmentScores = 0;
    decimal currentStudentGrade = 0;
    decimal gradedAssignments = 0;
    decimal extraCredit= 0;

    decimal examScore = 0;
    decimal totalExamScore = 0;

    decimal extraAssignments = 0;
    decimal extraPoints = 0;
    decimal currentExtraPoints = 0;
    /* 
    the inner foreach loop sums assignment scores
    extra credit assignments are worth 10% of an exam score
    */
    foreach (decimal score in studentScores)
    {
        gradedAssignments += 1;

        if (gradedAssignments <= examAssignments) 
        {
            examScore += score;
            sumAssignmentScores += score;
        } else {
            sumAssignmentScores += score / 10;
        }

        if (gradedAssignments > examAssignments) {
            extraAssignments++;
            extraCredit += score;
        }
        
    }

    // Points
    currentExtraPoints = extraCredit / extraAssignments;
    extraPoints = extraCredit / 10 / examAssignments;

    // Exam Score / Overall Grade
    totalExamScore = examScore / examAssignments;
    currentStudentGrade = sumAssignmentScores / examAssignments;

    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";
    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";
    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";
    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";
    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";
    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";
    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";
    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";
    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";
    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";
    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";
    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";
    else
        currentStudentLetterGrade = "F";

    // Student         Grade
    // Sophia:         92.2    A-

    Console.WriteLine($"{currentStudent}\t\t{totalExamScore}\t\t{currentStudentGrade:F2}\t{currentStudentLetterGrade}\t{currentExtraPoints} ({extraPoints} pts)");
}

// required for running in VS Code (keeps the Output windows open to view results)
Console.WriteLine("\n\rPress the Enter key to continue");
Console.ReadLine();
