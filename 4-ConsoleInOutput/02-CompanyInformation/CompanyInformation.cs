using System;
 /* Problem 2. Print Company Information

    A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
    Write a program that reads the information about a company and its manager and prints it back on the console.

Example input:
program 	user
Company name: 	Telerik Academy
Company address: 	31 Al. Malinov, Sofia
Phone number: 	+359 888 55 55 555
Fax number: 	
Web site: 	http://telerikacademy.com/
Manager first name: 	Nikolay
Manager last name: 	Kostov
Manager age: 	25
Manager phone: 	+359 2 981 981
  */

class CompanyInformation
{
    static void Main()
    {
        Console.WriteLine("Input Company Information:");
        Console.Write("Comapny name:" ); string companyName = Console.ReadLine();
        Console.Write("Comapny address:"); string companyAddress = Console.ReadLine();
        Console.Write("Comapny phone number:"); string companyPhone = Console.ReadLine();
        Console.Write("Comapny fax number:"); string companyFax = Console.ReadLine();
        Console.Write("Manager first name:"); string managerFirstname = Console.ReadLine();
        Console.Write("Manager last name:"); string managerLastname = Console.ReadLine();
        Console.Write("Manager age:"); byte managerAge = byte.Parse(Console.ReadLine());
        Console.Write("Manager phone number:"); string managerPhone = Console.ReadLine();
        Console.WriteLine("********* Company Information *********");
        Console.WriteLine("Company name: {0}\nCompany address: {1}\n", companyName, companyAddress);
        Console.WriteLine("Company phone number: {0}\nCompany fax number: {1}\n", companyPhone, companyFax);
        Console.WriteLine("Manager name: {0} {1}\nManager age: {2}\nManager phone number: {3}", managerFirstname, managerLastname, managerAge, managerPhone);
    }
}

 