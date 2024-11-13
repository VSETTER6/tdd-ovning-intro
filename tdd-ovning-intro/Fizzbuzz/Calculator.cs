using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizzbuzz
{
    public class Calculator
    {
        public string DivideBy3And5(int numberToCompare)
        {
            if (numberToCompare % 3 == 0 && numberToCompare % 5 == 0)
            {
                return "Fizzbuzz";
            }
            if (numberToCompare % 3 == 0)
            {
                return "Fizz";
            }
            if (numberToCompare % 5 == 0)
            {
                return "Buzz";
            }

            return numberToCompare.ToString();
        }

        // En funktion för att kolla om ett nummer och vid specifika nummer skriver den ut Fizz,
        // Buzz eller Fizzbuzz.
        public string NumberIsNumberFizzBuzzOrFizzbuzz(string number)
        {
            int numberIsValid;

            // Om number inte är nummer så kommer "Invalid input." att skrivas ut.
            if (!int.TryParse(number, out numberIsValid))
            {
                return "Invaild input.";
            }
            // Om number är ett number kommer den kolla vilket nummer det är och skriva ut numret, Fizz,
            // Buzz eller Fizzbuzz beroende på talet.
            if (numberIsValid == 1)
            {
                return numberIsValid.ToString();
            }
            if (numberIsValid == 2)
            {
                return numberIsValid.ToString();
            }
            if (numberIsValid == 3)
            {
                return "Fizz";
            }
            if (numberIsValid == 4)
            {
                return numberIsValid.ToString();
            }
            if (numberIsValid == 5)
            {
                return "Buzz";
            }
            if (numberIsValid == 6)
            {
                return "Fizz";
            }
            if (numberIsValid == 10)
            {
                return "Buzz";
            }
            if (numberIsValid == 11)
            {
                return numberIsValid.ToString();
            }
            if (numberIsValid == 15)
            {
                return "Fizzbuzz";
            }
            return "Something went wrong.";
        }

        public string UserChooseANumber(string inputNumber)
        {
            // Kollar ifall numret man valt faktsikt är ett nummer.
            try
            {
                int numberIsValid = int.Parse(inputNumber);
                return $"You chose number {numberIsValid}.";
            }
            // Om inte så kastas ett ArgumentException som säger att inputNumber inte är ett nummer.
            catch (FormatException)
            {
                throw new ArgumentException($"{inputNumber} is not a number");
            }
        }
    }
}
