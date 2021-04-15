 using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, id, password, age;
            

            Console.WriteLine("\n\n\n\t=====Welcome to Allen's Employee Training Management System=====\n\n\n");
            Console.WriteLine("\tLogin!\t");
            Console.Write("\tEnter your User Name: \t");
            name = Convert.ToString(Console.ReadLine());
            Console.Write("\tEnter your User ID: \t");
            id = Convert.ToString(Console.ReadLine());
            Console.Write("\tEnter your Password: \t");
            password = Convert.ToString(Console.ReadLine());
            Console.Write("\tEnter your Age: \t");
            age = Convert.ToString(Console.ReadLine());



            if (name == "Allen James" && id == "0907" && password == "0000" && age == "19")
            {

                Console.WriteLine("\n\n\t --------------------------------------------\t");
                Console.WriteLine("\t|             You are logged in              |\t");
                Console.WriteLine("\t --------------------------------------------\t");

                Console.WriteLine("\n\n\n\t=====Allen Employee Training Management System=====\n\n\n\t");
                Console.WriteLine(" \tHello " + name + " Welcome to our system! \n \tAge: \t " + age);
                Console.WriteLine("\n\nPress Enter to Continue!\n\n");

                

                Console.ReadLine();
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
                        Console.WriteLine("You are in the Visual Exercises ");
                        Console.WriteLine("A visual prompt is a photograph, illustration or icon to represent a task. There are different types of");
                        Console.WriteLine("visual prompts depending upon what each individual needs. For example, we all use visual prompts in");
                        Console.WriteLine("our daily lives. We see an icon on the the restroom door, and we know it is a bathroom. We write a to do");
                        Console.WriteLine("ist and leave it on the counter – it is a visual reminder or prompt to complete the tasks.");
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
                        Console.WriteLine("Kinaesthetic");
                        Console.WriteLine("On Going...");
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                        
                            
                }

                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("Login Unsuccessful!");
            }
            Console.ReadLine();


        }

      

    }
}
