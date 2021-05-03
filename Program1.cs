using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        string newname = "You are in the Kinaesthetic Program!";
        public string newfunction(string input)
        {
            string message = input;
            return message;
        }

        static void Main(string[] args)
        {

            string userName = "Allen";
            string userID = "0907";
            string userPassword = "0000";
            string Name, ID, Password;
            

            Console.WriteLine("\n\n\n\t=====Welcome to Allen's Employee Training Management System =====\n\n\n");
            Console.WriteLine("\tLogin into your Account!\t");
            Console.Write("\tEnter your User Name: \t");
            Name = Convert.ToString(Console.ReadLine());
            Console.Write("\tEnter your User ID: \t");
            ID = Convert.ToString(Console.ReadLine());
            Console.Write("\tEnter your Password: \t");
            Password = Convert.ToString(Console.ReadLine());

            if (Name == userName && ID == userID && Password == userPassword)
            {
                MainMenu();
            }
            else
            {
                Console.WriteLine("Invalid Input!");
            }

            static void MainMenu()
            {
                string userName = "Allen";
                Console.WriteLine("\n\n\t --------------------------------------------\t");
                Console.WriteLine("\t|             You are logged in  |\t");
                Console.WriteLine("\t --------------------------------------------\t");

                Console.WriteLine("\n\n\n\t=====Allen Employee Training Management System =====\n\n\n\t");
                Console.WriteLine(" \tHello " + userName + " Welcome to our system! \n");
                Console.WriteLine("\tWhat kind of training do you want to do?\t");
                Console.WriteLine(" (A) My Co-Trainees");
                Console.WriteLine(" (B) My Exercises");
                Console.WriteLine(" (C) Training Management");
                Console.WriteLine(" (D) Exit the Program");

                Console.Write("\tChoose from the following?\t");
                char selection = Console.ReadKey().KeyChar;

                switch (selection)
                {
                    case 'A':
                    case 'a':
                        Trainees();
                        break;

                    case 'B':
                    case 'b':
                        TrainingExercises();
                        break;

                    case 'C':
                    case 'c':
                        TrainingManagement();
                        break;

                    case 'D':
                    case 'd':
                        Exit();
                        break;

                    default:
                        Console.WriteLine("Invalid Input!");
                        break;

                }
            }

            static List<string> TraineesName()
            {
                var TraineesList = new List<string>(){"Allen","Jonard","Rudolph","Kenneth","Kenjie","Randy","Darren"};
                return TraineesList;
            }

            static List<string> TrainingList()
            {
                var TrainingList = new List<string>(){"Visual","Auditory","Kinaesthetic"};
                return TrainingList;
            }

            static void Trainees()
            {
                Console.WriteLine($"List of Trainees: ");
                foreach (var trainees in TraineesName())
                {
                    Console.WriteLine(trainees);
                }
                MainMenu();
            }

            static void TrainingExercises()
            {
                Console.WriteLine($"List of Trainees: ");
                foreach (var exercises in TrainingList())
                {
                    Console.WriteLine(exercises);
                }
                MainMenu();
            }

            static void TrainingManagement()
            {
                Console.WriteLine($"List of Traings: ");
                foreach (var trainings in TrainingList())
                {
                    string optionSelected;
                    Console.WriteLine(trainings);
                    Console.WriteLine("\tWhat kind of training do you want to do?\t");
                    Console.WriteLine(" (A) Visual");
                    Console.WriteLine(" (B) Auditory");
                    Console.WriteLine(" (C) Kinaesthetic");


                    Console.Write("\tChoose from the following?\t");
                    char selection = Console.ReadKey().KeyChar;

                    switch (selection)
                    {
                        case 'a':
                        case 'A':
                            Console.WriteLine("Please type a if you want to continue and b if you want to exit");
                            Console.WriteLine("Input: ");

                            optionSelected = Console.ReadLine().ToLower();
                            if(optionSelected.Equals("a"))
                            {
                                char choices = Console.ReadKey().KeyChar;
                                Console.WriteLine("Would you take the test now? select x to continue and y to exit");
                                switch (choices) 
                                {
                                    case 'X':
                                        Console.WriteLine("What do you see?");
                                        Console.WriteLine("-----");
                                        Console.WriteLine("|    |");
                                        Console.WriteLine("|    |");
                                        Console.WriteLine("-----");
                                        Console.WriteLine("Enter Answer: ");
                                        break;
                                    
                                    case 'Y':
                                        Console.WriteLine("Exit the Program");
                                        System.Environment.Exit(0);
                                        break;

                                    default:
                                        Console.WriteLine("Invalid Option");
                                        break;

                                }
                            }
                            else if (optionSelected.Equals("b"))
                            {
                                Console.WriteLine("Exit the Program");
                                System.Environment.Exit(0);
                            }
                            else 
                            {
                                Console.WriteLine("Invalid Input!");
                            }

                            break;
                        case 'b':
                        case 'B':
                            string color, Noun, Name;
                            Console.WriteLine("Enter a color: ");
                            color = Console.ReadLine();
                            Console.WriteLine("Enter a plural noun: ");
                            Noun = Console.ReadLine();
                            Console.WriteLine("Enter a celebrity name: ");
                            Name = Console.ReadLine();

                            Console.WriteLine("Roses are " + color);
                            Console.WriteLine(Noun + " are blue");
                            Console.WriteLine("I love " + Name);
                            break;
                        case 'c':
                        case 'C':

                            Program f= new Program();
                            string str = f.newfunction(f.newname);
                            Console.WriteLine("Input String is =" + str);
                            Console.Read();

                            break;
                        default:
                            Console.WriteLine("Invalid Option");
                            break;


                    }

                    Console.ReadKey();


                }
                MainMenu();
            }
            static void Exit()
            {
                Console.WriteLine("Exit the Program");
                System.Environment.Exit(0);
            }

        }

    }
}
