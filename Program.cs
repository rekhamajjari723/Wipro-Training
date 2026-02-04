// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Net.NetworkInformation;
using static System.Reflection.Metadata.BlobBuilder;

Console.WriteLine("Hello, World!");

//A Smart Parking System is developed to manage vehicle entry, parking allocation, billing, and exit processing.
//The system must:
//Track parking slots
//Handle vehicle types
//Continuously monitor availability
//Process user choices until exit
//Loop : for initialized parking slots.
//for each loop can be used for Displaying parking status
//Switch : vehicle type handling(car, bike, truck, others)
//While : 
//Do While

//Step 1: Initialize parking with the help of for loop 
//Step 2: parking vehicles
//Step 3: exit vehicles
//Step 4: calculate charges based on vehicle type
//step 5: Keeping the application running until the user exits.






//Why we need function in C#?
//A school needs a small program to:
//Calculate total marks
//Calculate average marks
//Determine pass or fail
mainFunction();

// by using functions we can solve it 
int calculateTotal (int mark1, int mark2, int mark3)
{
    return (mark1 + mark2 + mark3);
}
double calculateAverage(int totalMarks, int numberOfSubjects = 3) // default parameter
{
    return (double)totalMarks / numberOfSubjects;
}
//fucntion to check result 
string checkResult(double averageMarks, double passMark = 40.0) // default parameter
{
    if (averageMarks >= passMark)
    {
        return "Pass";
    }
    else
    {
        return "Fail";
    }
}


//creating main function to call other functions
void mainFunction()
{
    int marks1 = 50;
    int marks2 = 80;
    int marks3 = 92;
    int totalMarks = calculateTotal(marks1, marks2, marks3);// function call
    double averageMarks = calculateAverage(totalMarks);
    string result = checkResult(averageMarks);

    Console.WriteLine("below is the result ...!!");
    Console.WriteLine($"Total Marks: {totalMarks}");
    Console.WriteLine($"Average Marks: {averageMarks}");
    Console.WriteLine($"Result: {result}");
}