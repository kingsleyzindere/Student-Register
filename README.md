# Student Register

A C# console application that stores student details, validates user input, and searches for students by name.

## Features

- Starts with two existing students.
- Lets the user add one new student.
- Rejects empty names and names containing only spaces.
- Accepts ages from 1 to 120.
- Handles invalid age input and numbers outside the integer range.
- Displays the student count and introduces every student.
- Searches by name without requiring matching capitalisation.
- Displays a message if no matching student is found.

## How to Run

1. Clone or download this repository.
2. Open the solution in Visual Studio 2022 with the .NET desktop development workload installed.
3. Press Ctrl + F5 to run.
4. Enter the new student's name and age.
5. Enter a name to search the register.

## What I Practised

- Classes and objects
- Properties and constructors
- Instance methods
- Lists of objects using List<Student>
- foreach and do/while loops
- Input validation
- Error handling with try/catch
- Boolean variables to track progress
- Case-insensitive string comparisons

## Storage

Students are stored in memory while the program runs. Added students are not saved after the program closes.
