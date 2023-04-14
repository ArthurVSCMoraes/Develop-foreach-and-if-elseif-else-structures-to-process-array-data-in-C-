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

int currentAssignments = 5;
int[] sophiaAllNotes = { 90, 86, 87, 98, 100 };
int[] andrewAllNotes = { 92, 89, 81, 96, 90 };
int[] emmaAllNotes = { 90, 85, 87, 98, 68 };
int[] loganAllNotes = { 90, 95, 87, 88, 96 };

Console.WriteLine("Student\t\tGrade\n");

string[] studentsNames = { "Sophia", "Andrew", "Emma", "Logan" };
foreach (string names in studentsNames)
{
    if (names == "Sophia")
    {
        decimal sophiaScore;
        int sophiaSum = 0;

        foreach (int sophia in sophiaAllNotes)
        {
            sophiaSum += sophia;
        }
        sophiaScore = (decimal)sophiaSum / currentAssignments;
        Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");


    }
    else if (names == "Andrew")
    {
        decimal andrewScore;
        int andrewSum = 0;

        foreach (int andrew in andrewAllNotes)
        {
            andrewSum += andrew;
        }
        andrewScore = (decimal)andrewSum / currentAssignments;
        Console.WriteLine("Andrew:\t\t" + andrewScore + "\tB+");

    }
    else if (names == "Emma")
    {
        decimal emmaScore;
        int emmaSum = 0;

        foreach (int emma in emmaAllNotes)
        {
            emmaSum += emma;
        }
        emmaScore = (decimal)emmaSum / currentAssignments;
        Console.WriteLine("Emma:\t\t" + emmaScore + "\tB");

    }
    if (names == "Logan")
    {
        decimal loganScore;
        int loganSum = 0;

        foreach (int items in loganAllNotes)
        {
            loganSum += items;
        }
        loganScore = (decimal)loganSum / currentAssignments;
        Console.WriteLine("Logan:\t\t" + loganScore + "\tA-");


    }


}


Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
