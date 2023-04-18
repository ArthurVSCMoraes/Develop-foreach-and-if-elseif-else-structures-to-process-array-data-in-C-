// Best GRade
// 97 - 100   A+
// 93 - 96    A
// 90 - 92    A-
// 87 - 89    B+
// 83 - 86    B
// 80 - 82    B-
// 77 - 79    C+
// 73 - 76    C
// 70 - 72    C-
// 67 - 69    D+
// 63 - 66    D
// 60 - 62    D-
// 0  - 59    F

using System;

int examAssignments = 5;

int[] sophiaAllNotes = { 90, 86, 87, 98, 100, 94, 90  };
int[] andrewAllNotes = { 92, 89, 81, 96, 90, 89 };
int[] emmaAllNotes = { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganAllNotes = {  90, 95, 87, 88, 96, 96 };
int[] beckyAllNotes = { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisAllNotes = { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericAllNotes = { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorAllNotes = { 91, 91, 91, 91, 91, 91, 91 };
Console.WriteLine("Student\t\tGrade\n");

string[] studentsNames = { "Sophia", "Andrew", "Emma", "Logan", "Becky", " Chris", "Eric", "Gregor" };
int[] studentScore = new int[10];
string studentGrading = "";
foreach (string names in studentsNames)
{
    string currentStudant = names;
    if (currentStudant == "Sophia")
    {
        studentScore = sophiaAllNotes;
    }
    else if (currentStudant == "Andrew")
    {
        studentScore = andrewAllNotes;
    }
    else if (currentStudant == "Emma")
    {
        studentScore = emmaAllNotes;
    }
    else if (currentStudant == "Logan")
    {
        studentScore = loganAllNotes;
    }
    else if ( currentStudant == "Becky")
    {
        studentScore = beckyAllNotes;
    }
    else if ( currentStudant == "Chris")
    {
        studentScore = chrisAllNotes;
    }
    else if ( currentStudant == "Eric")
    {
        studentScore = ericAllNotes;
    }
    else if ( currentStudant == "Gregor")
    {
        studentScore = gregorAllNotes;
    }
        else
        continue;
    int totalSum = 0;
    decimal studentGrade = 0;

    int gradedAssingments = 0;
    foreach (int score in studentScore)
    {
        gradedAssingments += 1;
        if (gradedAssingments <= examAssignments)
        {
            totalSum +=  score;
        }
        else 
        {
            totalSum += score / 10;
        }
    }
    studentGrade = (decimal)(totalSum) / examAssignments;


    //Qualificia no método de notas americanas, com base em letras, as  notas dos alunos utilizando o studentGrade como variavel de chamada
    if (studentGrade >= 97)
    {
        studentGrading = "A+";
    }
    else if (studentGrade >= 93)
    {
        studentGrading = "A";
    }
    else if (studentGrade >= 90)
    {
        studentGrading = "A-";
    }
    else if (studentGrade >= 87)
    {
        studentGrading = "B+";
    }
    else if (studentGrade >= 83)
    {
        studentGrading = "B";
    }
    else if (studentGrade >= 80)
    {
        studentGrading = "B-";
    }
    else if (studentGrade >= 77)
    {
        studentGrading = "C+";
    }
    else if (studentGrade >= 73)
    {
        studentGrading = "C";
    }
    else if (studentGrade >= 70)
    {
        studentGrading = "C-";
    }
    else if (studentGrade >= 67)
    {
        studentGrading = "D+";
    }
    else if (studentGrade >= 63)
    {
        studentGrading = "D";
    }
    else if (studentGrade >= 60)
    {
        studentGrading = "D-";
    }
    else
    {
        studentGrading = "F";
    }
    Console.WriteLine($"{names}\t\t{studentGrade}\t{studentGrading}");
}
Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();

