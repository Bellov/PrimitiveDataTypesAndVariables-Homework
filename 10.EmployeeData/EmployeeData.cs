using System;

//A marketing company wants to keep record of its employees. Each record would have the following characteristics:
//•	First name
//•	Last name
//•	Age (0...100)
//•	Gender (m or f)
//•	Personal ID number (e.g. 8306112507)
//•	Unique employee number (27560000…27569999)
//Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.




class EmployeeData
{
    static void Main()
    {
        string firstName = "Aleksandur";
        string lastName = "Atanasov";
        byte age = 24;
        char gender = 'm';
        string personalId = "9009176455";
        long employeeNumber = 27569999;
        Console.BufferHeight = Console.WindowHeight;

        //Console.WriteLine("{0},{1},{2},{3},{4},{5}", firstName,lastName,age,gender,personalId,employeeNumber);
        Console.WriteLine("First Name: {0} \nLast Name: {1} \nAge: {2} \nGenger: {3} \nPersonal ID: {4} \nEmployee number: {5} \n",firstName,lastName,age,gender,personalId,employeeNumber);


        Console.ReadLine();
    }
}

