using System;


//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account. Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.




class BankAccountData
    {
        static void Main(string[] args)
        {
            string firstName = "Aleksandur";
            string middleName = "Valeriev";
            string lastName = "Atanasov";
            decimal amaountOfMoney = 983.7189312412m;
            string bankName = "OBB";
            string iban = "2000116548";
            string firstCardNumber = "2431";
            string secondCardNumber = "2532";
            string thirdCardNumber = "2633";


            Console.WriteLine("First name: {0}\nMiddle name: {1}\nLast name: {2}\nAmount of the money: {3}\nBank name: {4}\nIBAN: {5}\nFirst card number: {6}\nSecond card number: {7}\nThird card number: {8}\n",firstName,middleName,lastName,amaountOfMoney,bankName,iban,firstCardNumber,secondCardNumber,thirdCardNumber);


            Console.ReadLine();

        }
    }

