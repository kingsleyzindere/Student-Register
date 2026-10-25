// Create two students with starting names and ages.
Student student1 = new Student("Kingsley", 21);
Student student2 = new Student("Chiedza", 21);

// Create a list of Student objects and add both students.
List<Student> students = new List<Student>();
students.Add(student1);
students.Add(student2);

// Ask for the new student's name.
Console.WriteLine("Please enter your name");
string name = Console.ReadLine();

// Keep asking if the name is empty or contains only spaces.
do
{
    if (string.IsNullOrWhiteSpace(name))
    {
        Console.WriteLine("Name cannot be empty. Please enter a valid name.");
        name = Console.ReadLine();
    }
}
while (string.IsNullOrWhiteSpace(name));

// Track whether the new student has been successfully added.
bool studentAdded = false;

// Keep asking for an age until a student is added.
do
{
    Console.WriteLine("Please enter your age");

    try
    {
        // Convert the entered text into an integer.
        int age = int.Parse(Console.ReadLine());

        // Reject ages outside the accepted range.
        if (age < 1 || age > 120)
        {
            Console.WriteLine("Age must be between 1 and 120");
        }
        else
        {
            // Create and add the student using the entered details.
            Student student3 = new Student(name, age);
            students.Add(student3);

            // Mark the task as complete so the age loop stops.
            studentAdded = true;
        }
    }
    catch (FormatException)
    {
        // Handle input that cannot be converted into an integer.
        Console.WriteLine("Please enter a whole number for age.");
    }
    catch (OverflowException)
    {
        // Handle numbers outside the range an int can store.
        Console.WriteLine("That number is too large or too small.");
    }
}
while (!studentAdded);

// Display the number of students in the list.
Console.WriteLine($"Students in register:  {students.Count}");

// Introduce every student in the list.
foreach (Student student in students)
{
    student.Introduce();
}

// Ask which name to search for.
Console.WriteLine("Enter a name to search for in the register");
string searchName = Console.ReadLine();

// Track whether any student matches the search.
bool studentFound = false;

foreach (Student student in students)
{
    // Compare names without treating capital letters as different.
    if (string.Equals(student.Name, searchName, StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine($"Found student: {student.Name}, Age: {student.Age}");
        studentFound = true;
    }
}

// Show this message only after the entire list has been checked.
if (!studentFound)
{
    Console.WriteLine("Student not found in the register.");
}

// Define the properties and behaviour of a Student object.
class Student
{
    // Store each student's name and age.
    public string Name { get; set; }
    public int Age { get; set; }

    // Set the starting properties when a Student object is created.
    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Display this student's name and age.
    public void Introduce()
    {
        Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
    }
}