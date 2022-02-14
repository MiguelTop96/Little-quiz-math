using System;

class quiz{

    static void Main(string[] arg){

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WindowHeight = 20;
        Console.WindowWidth = 60;
        Console.Title = "QuizMath!!!";

//start...

        Console.WriteLine("welcome to the Quiz Math!!!");
        Console.WriteLine("please, deposit 5 coins to take the ticket!");

        int cash = Convert.ToInt32(Console.ReadLine());

        if(cash < 5){
            int lack = 5 - cash;
            Console.WriteLine("sorry man, but lack " + lack + " of money to proceed");
            Console.ReadKey();
            Environment.Exit(0);
        }else if(cash == 5){
            Console.WriteLine("well, let`s begin...");
            Console.ReadKey();
            Console.Clear();
        }else{
            int change = cash - 5;
            Console.WriteLine("So, here take this ticket and... \nhere are the " + change + " coins of the change");
            Console.WriteLine("well, let`s begin...");
            Console.ReadKey();
            Console.Clear();
        }


//first question...

        Console.WriteLine(" well, the first question: \n 10 * 5 + 2");
        Console.WriteLine("\n 1 = 34\n 2 = 56\n 3 = 52\n 4 = 80\n 5 = 12");

        int num = Convert.ToInt32(Console.ReadLine());

        switch (num) {
            case 1:
            Console.WriteLine("incorrect");
            Console.ReadKey();
            Environment.Exit(0);
            break;
            case 2:
            Console.WriteLine("incorrect");
            Console.ReadKey();
            Environment.Exit(0);
            break;
            case 3:
            Console.WriteLine("correct!!");
            Console.ReadKey();
            Console.Clear();
            break;
            case 4:
            Console.WriteLine("incorrect");
            Console.ReadKey();
            Environment.Exit(0);
            break;
            case 5:
            Console.WriteLine("incorrect");
            Console.ReadKey();
            Environment.Exit(0);
            break;
            default:
            Console.WriteLine("no no no, that`s is not a option");
            Console.ReadKey();
            Environment.Exit(0);
            break;
        }

//second question...

        Console.WriteLine(" Second question: \n 120 * 15 - 450");
        Console.WriteLine("\n 1 = 1500 \n 2 = 1350 \n 3 = 1760 \n 4 = 1920 \n 5 = 1200");

        int num2 = Convert.ToInt32(Console.ReadLine());

        switch (num2){
            case 1:
            Console.WriteLine("incorrect");
            Console.ReadKey();
            Environment.Exit(0);
            break;
            case 2:
            Console.WriteLine("correct");
            Console.ReadKey();
            Console.Clear();
            break;
            case 3:
            Console.WriteLine("incorrect");
            Console.ReadKey();
            Environment.Exit(0);
            break;
            case 4:
            Console.WriteLine("incorrect");
            Console.ReadKey();
            Environment.Exit(0);
            break;
            case 5: 
            Console.WriteLine("incorrect");
            Console.ReadKey();
            Environment.Exit(0);
            break;
            default:
            Console.WriteLine("nononononono, that`s not a answer");
            Console.ReadKey();
            Environment.Exit(0);
            break;
        }

//final question...
        
        Console.WriteLine(" third and final question!!!");
        Console.WriteLine(" Jonh wants to go on the playground, but...\n only have 12 years old, and have 130 (cm)\n So, what`s the attractions who jonh can go to?");
        Console.WriteLine("\n 1 - roller coaster = age - 15 or height - 160\n 2 - cavern boat = age - 14 or height - 120\n 3 - bumper car = age 12 or height - 150 ");

        int num3 = Convert.ToInt32(Console.ReadLine());

        if (num3 == 1){
            Console.WriteLine("incorrect");
            Console.ReadKey();
            Environment.Exit(0);
        }else if (num3 == 2|| num3 == 3){
            Console.WriteLine("Correct!!");
            Console.ReadKey();
            Console.Clear();
        }


        Console.WriteLine("congratulations, you did answer all question!!");
        Console.ReadKey();
    }

}
