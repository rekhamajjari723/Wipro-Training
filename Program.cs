// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");

// arrays

int[] num = new int[5];
num[0] = 10;
num[1] = 20;
num[2] = 30;
num[3] = 40;
num[4] = 50;
for(int i=0;i<num.Length;i++)
{
    Console.WriteLine("element at index " + i + ":" + num[i]);
    //Console.WriteLine(Array.Sort(num));
  

}

// performing different operations on array
//Array.Sort(num);
//Array.Reverse(num);
//Array.IndexOf(num, 40);




// performing string
String[] movies = { "dootha", "leo", "dammu","rebal","hanu","nayudu"};
for(int i = 0; i < movies.Length; i++)
{
    Console.WriteLine("movies" + "=" + movies[i]);
}
Console.WriteLine("movie count" + "= " + movies.Count());
Console.WriteLine("movie index value" + "= " + movies.IndexOf("leo"));


// array types
//Getting started with 2D Arrays in C#
//Step 1: Declare a 2D array of type int syntax : dataType[,] arrayName = new dataType[rows, columns];
//Step 2: Initialize the 2D array with values
int[,] matrix = new int[3, 3] //3 rows and 3 columns
{
    {1, 2, 3}, //Row 0
    {4, 5, 6}, //Row 1
    {7, 8, 9}  //Row 2
};
Console.WriteLine("created a 2D array !!");
//step 3: using nested loop
for (int i = 0; i < matrix.GetLength(0); i++) // rows
{
    for (int j = 0; j < matrix.GetLength(1); j++) // columns
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}







//jagged Arrays in C# : where each element is an array itself ex
//Arrays  of arrays , specific rows can have different number of columns
//Biggest benefit : memory efficiency when dealing with non-uniform data ex
// a table where each row represents a different entity with varying attributes in case of e commerce products
//Step 1: Declare a jagged array
//Step 2: Initialize each row with different sizes
//Step 3: Print the values of the jagged array using nested for loops
//hence we use jagged arrays when we have non uniform data to save memory over a 2D array,
//where all rows must have same number of columns



int[][] jaggedArray = new int[3][];
// Step 2: Initialize each row with different sizes
jaggedArray[0] = new int[] { 1, 2 };              // Row 0 has 2 elements
jaggedArray[1] = new int[] { 3, 4, 5 };           // Row 1 has 3 elements
jaggedArray[2] = new int[] { 6, 7, 8, 9 };        // Row 2 has 4 elements

Console.WriteLine("created a jagged array !!");
// Step 3: Print values using nested for loops
for (int i = 0; i < jaggedArray.Length; i++)      // Loop through rows
{
    for (int j = 0; j < jaggedArray[i].Length; j++) // Loop through columns
    {
        Console.Write(jaggedArray[i][j] + " ");
    }
    Console.WriteLine(); // Move to next row
}




//Case study : Using Arrays to Manage Student Grades
//if i want to store marks of students in different subjects: "Subject wise marks for each student"
//Step 1: Declare a 2D array to store marks of 3 students in 4 subjects
//Step 2: Initialize the array with sample marks
//Step 3: Calculate and print the average marks for each student
//Step 4: Calculate and print the average marks for each subject
//Step 5: Find and print the highest and lowest marks in the class
// Syntax for declaraing  2D array as per above  sceanrio is 
// dataType[,] arrayName = new dataType[rows, columns];


int[,] sample_marks = new int[3, 4] //3 rows and 3 columns
{
    {80, 75, 90,70}, //Row 0
    {40, 50, 60, 80}, //Row 1
    {70, 80, 90,70}  //Row 2
};
int students = sample_marks.GetLength(0); // rows
int subjects = sample_marks.GetLength(1); // columns

// Step 3: Average marks per student
Console.WriteLine("Average marks per student:");
for (int i = 0; i < students; i++)
{
    int sum = 0;
    for (int j = 0; j < subjects; j++)
        sum += sample_marks[i, j];

    double avg = (double)sum / subjects;
    Console.WriteLine($"Student {i + 1}: {avg}");
}
// Step 4: Average marks per subject
Console.WriteLine("\nAverage marks per subject:");
for (int j = 0; j < subjects; j++)
{
    int sum = 0;
    for (int i = 0; i < students; i++)
        sum += sample_marks[i, j];

    double avg = (double)sum / students;
    Console.WriteLine($"Subject {j + 1}: {avg}");
}
int highest = sample_marks[0, 0];
int lowest = sample_marks[0, 0];

for (int i = 0; i < students; i++)
{
    for (int j = 0; j < subjects; j++)
    {
        if (sample_marks[i, j] > highest) highest = sample_marks[i, j];
        if (sample_marks[i, j] < lowest) lowest = sample_marks[i, j];
    }
}

Console.WriteLine($"\nHighest mark in class: {highest}");
Console.WriteLine($"Lowest mark in class: {lowest}");



