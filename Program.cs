using System;

namespace Exercise9_LanguageApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("*********************************************");
            Console.WriteLine("Welcome to The Olde World Language Translator");
            Console.WriteLine("*********************************************");

            bool translate = true;

            do
            {
                Console.WriteLine();
                Console.Write("Please enter an Olde Language: ");
                //Console.WriteLine();

                var userInput = Console.ReadLine();
                int isNumber;
                bool isNumberTest = int.TryParse(userInput, out isNumber);
                var language = isNumberTest ? "" : userInput.ToLower();

                switch (language)
                {
                    case "":
                        Console.WriteLine("Sorry, The " + userInput + " language was not found in ur database.");
                        break;
                    case "chinese":
                        Console.WriteLine("shì jiè nín hǎo！ The " + userInput + " language is over 6000 years old.");
                        break;
                    case "lithuanian":
                        Console.WriteLine("Labas pasauli! The " + userInput + " language is over 5000 years old.");
                        break;
                    case "tamil":
                        Console.WriteLine("Vaṇakkam ulakam! The " + userInput + " language is over 5000 years old.");
                        break;
                    case "greek":
                        Console.WriteLine("Geiá sou Kósme! The " + userInput + " language is over 2900 years old.");
                        break;
                    case "basque":
                        Console.WriteLine("Kaixo Mundua! The " + userInput + " language is over 2200 years old.");
                        break;
                    case "arabic":
                        Console.WriteLine("Marhaban Bialealami!, The " + userInput + " language is over 1500 years old.");
                        break;
                    case "english":
                        Console.WriteLine("Hello World!, The " + userInput + " language is over 1400 years old and just a baby compared to others.");
                        break;
                    case "icelandic":
                        Console.WriteLine("Halló heimur!, The " + userInput + " language is over 1200 years old.");
                        break;
                    default:
                        Console.WriteLine("So sorry, a " + userInput + " translator is not yet available.");
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("To translate another language, pleas enter 'yes' or 'y' -OR- press any other key to exit.");
                Console.WriteLine();

                var translateAnother = Console.ReadLine().ToLower();
                if (translateAnother != "y" && translateAnother != "yes")
                {
                    translate = false;
                    Console.WriteLine("Thank you for visiting The Olde World Language Translator. Bye-bye!");
                }
            } while (translate == true);

            Console.Read();
        }
    }
}