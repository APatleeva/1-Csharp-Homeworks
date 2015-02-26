using System;
/* Problem 10. Employee Data

A marketing company wants to keep record of its employees. Each record would have the following characteristics:
    First name
    Last name
    Age (0...100)
    Gender (m or f)
    Personal ID number (e.g. 8306112507)
    Unique employee number (27560000…27 569 999)

Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.*/

class EmployeeData
{
    static void Main(string[] args)
    {
        string firstName = "Ivan";
        string lastName = "Petrov";
        byte age = 20;
        char gender = 'm';
        long personalID = 8306112507L;
        uint employeeNumber = 27560000;
        Console.WriteLine("Emploee "+firstName+ " " +lastName+ " data:");
        Console.WriteLine("\tFirst name: {0}\n\tLast name: {1}\n\tAge: {2}\n\tGender: {3}\n\tPersonal ID number: {4}\n\tUnique employee number: {5}", firstName, lastName, age, gender, personalID, employeeNumber);
    }
}