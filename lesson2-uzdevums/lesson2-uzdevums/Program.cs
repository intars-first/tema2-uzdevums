using System;

namespace lesson2_uzdevums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kā tevi sauc?");
            string userAnswer = Console.ReadLine();
            //Console.WriteLine("Sveiks, " + userAnswer);
            Console.WriteLine($"Sveiks, {userAnswer}\n");

            Console.WriteLine("=======================================================");

            Console.WriteLine("Kāds ir tavs vecums?");
            string ageText = Console.ReadLine();

            int ageNumber = int.Parse(ageText);

            Console.WriteLine($"Nakamgad tev paliks {ageNumber + 1}, Tu esi pilngadīgs: {ageNumber > 18}\n");


            Console.WriteLine("====================Maximuma aprēķins=========================");

            string userInput1 = "";
            string userinput2 = "";
            double number1 = default;
            double number2 = default;
            double result = default;
            
            Console.WriteLine("Ievadi pirmo skaitli!");
            userInput1 = Console.ReadLine();
            number1 = double.Parse(userInput1);

            Console.WriteLine("Ievadi otro skaitli!");
            userinput2 = Console.ReadLine();
            number2 = double.Parse(userinput2);

            result = Math.Max(number1, number2);
            Console.WriteLine($"{result} ir lielākais skaitlis starp {number1} un {number2}\n");

            Console.WriteLine("====================Minimuma aprēķins=========================");

            Console.WriteLine("Ievadi pirmo skaitli!");
            userInput1 = Console.ReadLine();
            number1 = double.Parse(userInput1);

            Console.WriteLine("Ievadi otro skaitli!");
            userinput2 = Console.ReadLine();
            number2 = double.Parse(userinput2);

            result = Math.Min(number1, number2);
            Console.WriteLine($"{result} ir mazākais skaitlis starp {number1} un {number2}\n");

            Console.WriteLine("======================Atlikuma aprēķins======================");

            Console.WriteLine("Ievadi pirmo skaitli!");
            userInput1 = Console.ReadLine();
            number1 = double.Parse(userInput1);

            Console.WriteLine("Ievadi otro skaitli!");
            userinput2 = Console.ReadLine();
            number2 = double.Parse(userinput2);

            result = number1 % number2;
            Console.WriteLine($"{result} ir atlikums {number1} un {number2} dalījumam\n");

            Console.WriteLine(@"======================Pāra/nepāra noteikšana===============");

            Console.WriteLine("Ievadi skaitli!");
            userInput1 = Console.ReadLine();
            number1 = double.Parse(userInput1);

            result = number1 % 2;
            bool evenNumber = result == 0;

            Console.WriteLine($"{number1} ir {evenNumber} pāra skaitlis \n");

            Console.WriteLine(@"======================Taisnstūra laukums==================");

            Console.WriteLine("Ievadi īsākās malas garumu!");
            userInput1 = Console.ReadLine();
            number1 = double.Parse(userInput1);

            Console.WriteLine("Ievadi garākās malas garumu!");
            userinput2 = Console.ReadLine();
            number2 = double.Parse(userinput2);

            result = number1 * number2;
            result = Math.Round(result, 2);
            Console.WriteLine($"Taisnstūra laukums (noapaļots līdz 2 zīmēm aiz komata) ir {result}\n");

            Console.WriteLine(@"======================Vienādsānu trijstūris================");

            Console.WriteLine("Ievadi katetes garumu!");
            userInput1 = Console.ReadLine();
            number1 = double.Parse(userInput1);

 
            result = number1 * number1/2;
       
            Console.WriteLine($"Vienādsānu taisnleņķa trijstūra laukums ir {result}\n");

            Console.WriteLine(@"======================Interpolācija=======================");

            Console.WriteLine("Kāds ir tavs vārds?");
            userInput1 = Console.ReadLine();

            Console.WriteLine("Kāds ir tavs vecums?");
            userinput2 = Console.ReadLine();
            number2 = double.Parse(userinput2);

            Console.WriteLine($"Sveiks, {userInput1 }, tavs vecums ir {number2}\n");


        }
    }
}
