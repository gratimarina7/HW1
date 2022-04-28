
namespace C_Sharp_Lesson_1_Homework
{
    public class Homework
    {
        public void CheckIfNumberIsEvenOrOdd(int number)
        {
            /* Exercise 1
          * using "if" write a programm that checks whether an integer is greater then zero and even or odd
          * Example:
          * -------------------------------------------------
          * |input   | result                               |
          * |--------|--------------------------------------|
          * |  1     | even                                 |
          * |--------|--------------------------------------|
          * |  2     | odd                                  |
          * |--------|--------------------------------------|
          * | -1     | the value should be greater then zero|
          * -------------------------------------------------
          * 
          */
            //your code here
            if (number > 0)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine("Even");
                }
                else
                {
                    Console.WriteLine("Odd");
                }
            }
            else
            {
                Console.WriteLine("The number should be greater than zero!");
            }

            /* if (number < 0)
             {

                 Console.WriteLine("The number should be greater than zero!");
             }

             else if (number % 2 == 0)
             {

                 Console.WriteLine("Even");
             }

             else { 
                 Console.WriteLine("Odd");
             }
            */
        }
        public void NumberDivideToFour(int number)
        {
            /* Exercise 2
        * using a ternary operator write a program that print if number divide to 4
        * Example: 
        * --------------------------------------------
        * |input   | result                          |
        * |--------|---------------------------------|
        * |  -4    | The number divide to 4          |
        * |--------|---------------------------------|
        * |   2    | The number doesn't divide to 4  |
        * --------------------------------------------
        */
            //your code here
            var result = number % 4 == 0 ? "The number divide to 4" : "The number doesn't divide to 4";

            Console.WriteLine(result);
        }
        public void DayOfWeek(string day)
        {
            /* Exercise 3
             * using "switch" statement write a program that print the number of day of week
             * Example: monday - 1, tuesday - 2 etc. 
             * ---------------------------------------------------------
             * |day           |number                                  |
             * |--------------|----------------------------------------|
             * |monday        |   1                                    |
             * |tuesday       |   2                                    |
             * |wednesday     |   3                                    |
             * |thursday      |   4                                    |
             * |friday        |   5                                    |
             * |saturday      |   6                                    |
             * |sunday        |   7                                    |
             * |default value |Wrong value! Please give a day of a week|
             * ---------------------------------------------------------
             */
            
            switch (day)
            {
                //your code here
                case "Monday":
                    Console.WriteLine(1);
                    break;
                case "Tuesday":
                    Console.WriteLine(2);
                    break;
                case "Wednesday":
                    Console.WriteLine(3);
                    break;
                case "Thurday":
                    Console.WriteLine(4);
                    break;
                case "Friday":
                    Console.WriteLine(5);
                    break;
                case "Saturday":
                    Console.WriteLine(6);
                    break;
                case "Sunday":
                    Console.WriteLine(7);
                    break;
                default:
                    Console.WriteLine("Wrong value! Please give a day of a week!");
                    break;
            }
        }
        public void CheckLetterIfVowel(char character)
        {
            /* Exercise 4
             * write a program that will print input character is a vowel, consonant or not a letter
             * Method 1: using a switch case
             * Method 2: using if
             * ---------------------------
             * |input| result            |
             * |-----|-------------------|
             * |  a  | a is a vowel      |
             * |  b  | b is a consonant  |
             * ---------------------------
             */
            //your code here
            // Method 1: using a switch case
            switch (character)
            {
                case 'a':
                    Console.WriteLine("vowel");
                    break;
                case 'A':
                    Console.WriteLine("vowel");
                    break;
                case 'e':
                    Console.WriteLine("vowel");
                    break;
                case 'E':
                    Console.WriteLine("vowel");
                    break;
                case 'i':
                    Console.WriteLine("vowel");
                    break;
                case 'I':
                    Console.WriteLine("vowel");
                    break;
                case 'o':
                    Console.WriteLine("vowel");
                    break;
                case 'O':
                    Console.WriteLine("vowel");
                    break;
                case 'u':
                    Console.WriteLine("vowel");
                    break;
                case 'U':
                    Console.WriteLine("vowel");
                    break;
                case 'b':
                    Console.WriteLine("consonant");
                    break;
                case 'B':
                    Console.WriteLine("consonant");
                    break;
                case 'c':
                    Console.WriteLine("consonant");
                    break;
                case 'C':
                    Console.WriteLine("consonant");
                    break;
                case 'd':
                    Console.WriteLine("consonant");
                    break;
                case 'D':
                    Console.WriteLine("consonant");
                    break;
                case 'f':
                    Console.WriteLine("consonant");
                    break;
                case 'F':
                    Console.WriteLine("consonant");
                    break;
                case 'g':
                    Console.WriteLine("consonant");
                    break;
                case 'G':
                    Console.WriteLine("consonant");
                    break;
                case 'h':
                    Console.WriteLine("consonant");
                    break;
                case 'H':
                    Console.WriteLine("consonant");
                    break;
                case 'j':
                    Console.WriteLine("consonant");
                    break;
                case 'J':
                    Console.WriteLine("consonant");
                    break;
                case 'k':
                    Console.WriteLine("consonant");
                    break;
                case 'K':
                    Console.WriteLine("consonant");
                    break;
                case 'l':
                    Console.WriteLine("consonant");
                    break;
                case 'L':
                    Console.WriteLine("consonant");
                    break;
                case 'm':
                    Console.WriteLine("consonant");
                    break;
                case 'M':
                    Console.WriteLine("consonant");
                    break;
                case 'n':
                    Console.WriteLine("consonant");
                    break;
                case 'N':
                    Console.WriteLine("consonant");
                    break;
                case 'p':
                    Console.WriteLine("consonant");
                    break;
                case 'P':
                    Console.WriteLine("consonant");
                    break;
                case 'q':
                    Console.WriteLine("consonant");
                    break;
                case 'Q':
                    Console.WriteLine("consonant");
                    break;
                case 'r':
                    Console.WriteLine("consonant");
                    break;
                case 'R':
                    Console.WriteLine("consonant");
                    break;
                case 's':
                    Console.WriteLine("consonant");
                    break;
                case 'S':
                    Console.WriteLine("consonant");
                    break;
                case 't':
                    Console.WriteLine("consonant");
                    break;
                case 'T':
                    Console.WriteLine("consonant");
                    break;
                case 'v':
                    Console.WriteLine("consonant");
                    break;
                case 'V':
                    Console.WriteLine("consonant");
                    break;
                case 'w':
                    Console.WriteLine("consonant");
                    break;
                case 'W':
                    Console.WriteLine("consonant");
                    break;
                case 'x':
                    Console.WriteLine("consonant");
                    break;
                case 'X':
                    Console.WriteLine("consonant");
                    break;
                case 'y':
                    Console.WriteLine("consonant");
                    break;
                case 'Y':
                    Console.WriteLine("consonant");
                    break;
                case 'z':
                    Console.WriteLine("consonant");
                    break;
                case 'Z':
                    Console.WriteLine("consonant");
                    break;
                default:
                    Console.WriteLine("is not a letter");
                    break;
            }


            // Method 2: using if
            if (character == 'a' || character == 'A' || character == 'e' || character == 'E' || character == 'i' || character == 'I' || character == 'o' || character == 'O' || character == 'u' || character == 'U')
            {
                Console.WriteLine(character + " is a Vowel.");
            }
            else if (character == 'b' || character == 'B' || character == 'c' || character == 'C' || character == 'd' || character == 'D' || character == 'f' || character == 'F' || character == 'g' || character == 'G' || character == 'h' || character == 'H' || character == 'j' || character == 'J' || character == 'k' || character == 'K' || character == 'l' || character == 'L' || character == 'm' || character == 'M' || character == 'n' || character == 'N' || character == 'p' || character == 'P' || character == 'q' || character == 'Q' || character == 'r' || character == 'R' || character == 's' || character == 'S' || character == 't' || character == 'T' || character == 'v' || character == 'V' || character == 'w' || character == 'W' || character == 'x' || character == 'X' || character == 'y' || character == 'Y' || character == 'z' || character == 'Z')
            {
                Console.WriteLine(character + " is a Consonant.");
            }
            else
            {
                Console.WriteLine(character + " is not a letter.. ");
            }

            /*if ((character >= 'a' && character <= 'z') || (character >= 'A' && character <= 'Z'))
            {
                if (character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u' || character == 'A' || character == 'E' || character == 'I' || character == 'O' || character == 'U')
                {

                    Console.WriteLine(character + " is a Vowel.");

                }
                else if ((character >= 'a' && character <= 'z') || (character >= 'A' && character <= 'Z'))
                {
                    Console.WriteLine(character + " is a Consonant.");
                }
            }
            else if (character >= '0' && character <= '9')
            {
                Console.WriteLine(character + " is a Digit. ");
            }
            else
            {
                Console.WriteLine(character + " is a Special character.. ");
            }*/

        }
        public static void Main(String[] args)
        {
         Homework homework = new Homework();

            homework.CheckIfNumberIsEvenOrOdd(-11);
            homework.CheckIfNumberIsEvenOrOdd(11);
            homework.CheckIfNumberIsEvenOrOdd(8);
            homework.CheckIfNumberIsEvenOrOdd(101);
            homework.CheckIfNumberIsEvenOrOdd(83);
            //---------------------------------------
            homework.NumberDivideToFour(10);
            homework.NumberDivideToFour(16);
            homework.NumberDivideToFour(400);
            homework.NumberDivideToFour(61);
            homework.NumberDivideToFour(104);
            homework.NumberDivideToFour(2340);
            //---------------------------------------
            homework.DayOfWeek("Monday");
            homework.DayOfWeek("Sunday");
            homework.DayOfWeek("Tuesday");
            homework.DayOfWeek("Wednesday");
            homework.DayOfWeek("some day");
            //---------------------------------------
            homework.CheckLetterIfVowel('p');
            homework.CheckLetterIfVowel('i');
            homework.CheckLetterIfVowel('Z');
            homework.CheckLetterIfVowel('a');
            homework.CheckLetterIfVowel('w');
            homework.CheckLetterIfVowel('@');
            homework.CheckLetterIfVowel('%');
        }
    }
}
