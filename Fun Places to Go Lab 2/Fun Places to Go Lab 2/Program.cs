using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Fun_Places_to_Go_Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {  
            String greeting = "Welcome user, to the magical world of your imagination! What would you like to do today?";
            String options = "I have many amazing adventures to choose from below: ";
            String participants = "How many wonderful individuals will you be bringing with you today? ";
            String[] opt = { "Action", "Chill Times", "Danger", "Good Food" };
            
            String action = "Okay, if you're in the mood for some sweet sweet ";
            String chill = "Okay, when the mood is just right for some ";
            String danger = "Okay, it would seem you're in the mood for some ";
            String goodFood = "Okay if you're in the mood for some succulent ";

            String error = "Ah Ah Ah! You didn't say the magic word! \nPlease enter a valid selection: ";

            int fun = 0;
            int peeps = 0;
            bool chk = false;

            // LOOPING PROGRAM UNTIL PROMPTED BY USER TO EXIT
            bool repeat = true;            
            while (repeat)
            {

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(greeting +"\n");

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(options);

                    // Listing my array
                    Console.WriteLine("(1) " + opt[0]);
                    Console.WriteLine("(2) " + opt[1]);
                    Console.WriteLine("(3) " + opt[2]);
                    Console.WriteLine("(4) " + opt[3]);

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Please select your adventure: ");
                chk = Int32.TryParse(Console.ReadLine(), out fun);

                while (fun < 1 || fun > 4)
                    {
                        Console.Beep(); Console.Beep(); Console.Beep(); // ADDING BEEPS FOR ERRORS
                        Console.Write(error);
                    //fun = int.Parse(Console.ReadLine());
                    chk = Int32.TryParse(Console.ReadLine(), out fun);
                } 
                
                Console.Write(participants);
                chk = Int32.TryParse(Console.ReadLine(), out peeps);

                Console.WriteLine(); // ADD EMPTY LINE FOR FORMATTING

                while (peeps < 0)
                {
                    Console.Beep(); Console.Beep(); Console.Beep(); // ADDING BEEPS FOR ERRORS
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You just murdered " + (peeps * -1) + " magnificent creatures, good going, hope you feel better.");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Try again: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    //peeps = int.Parse(Console.ReadLine());
                    chk = Int32.TryParse(Console.ReadLine(), out peeps);
                }

                Console.ForegroundColor = ConsoleColor.Yellow; // ADD COLOR TO OUTPUT USER RESULTS
                // ACTION LOOP
                if ((fun == 1) && (peeps == 0))
                {
                    Console.WriteLine(action + opt[0] + " then you should go for a jog! and travel in your sneakers.");
                }
                else if ((fun == 1) && (peeps >= 1 && peeps <= 4))
                {
                    Console.WriteLine(action + opt[0] + " then you should shoot some pool! and travel in a sedan.");
                }
                else if ((fun == 1) && (peeps >= 5 && peeps <= 10))
                {
                    Console.WriteLine(action + opt[0] + " then you should play basketball! and travel in a Volkswagen bus!");
                }
                else if ((fun == 1) && (peeps >= 11))
                {
                    Console.WriteLine(action + opt[0] + " then you should go to a concert! and travel in an airplane.");
                }
                // END ACTION LOOP

                // CHILL LOOP
                if ((fun == 2) && (peeps == 0))
                {
                    Console.WriteLine(chill + opt[1] + " then you should watch Netflix and CHILL! and travel in your pajamas!");
                }
                else if ((fun == 2) && (peeps >= 1 && peeps <= 4))
                {
                    Console.WriteLine(chill + opt[1] + " then you should watch the Football game! and travel to your couch!");
                }
                else if ((fun == 2) && (peeps >= 5 && peeps <= 10))
                {
                    Console.WriteLine(chill + opt[1] + " then you should go to the movies! and travel in a Volkswagen bus!");
                }
                else if ((fun == 2) && (peeps >= 11))
                {
                    Console.WriteLine(chill + opt[1] + " then you should go the beach! and travel in an airplane.");
                }
                // END CHILL LOOP

                // DANGER LOOP
                if ((fun == 3) && (peeps == 0))
                {
                    Console.WriteLine(danger + opt[2] + " then you should go skydiving! and travel on a magic carpet!");
                }
                else if ((fun == 3) && (peeps >= 1 && peeps <= 4))
                {
                    Console.WriteLine(danger + opt[2] + " then you should go white water rafting! and travel in a boat!");
                }
                else if ((fun == 3) && (peeps >= 5 && peeps <= 10))
                {
                    Console.WriteLine(danger + opt[2] + " then you should go spelunking! and travel in a Volkswagen bus!");
                }
                else if ((fun == 3) && (peeps >= 11))
                {
                    Console.WriteLine(danger + opt[2] + " then you should rob a bank! and travel in an armored vehicle!");
                }
                // END DANGER LOOP

                // GOOD FOOD LOOP
                if ((fun == 4) && (peeps == 0))
                {
                    Console.WriteLine(goodFood + opt[3] + " then you should go to your kitchen! and travel in your socks.");
                }
                else if ((fun == 4) && (peeps >= 1 && peeps <= 4))
                {
                    Console.WriteLine(goodFood + opt[3] + " then you should go to Taco Bell! and travel in a sedan.");
                }
                else if ((fun == 4) && (peeps >= 5 && peeps <= 10))
                {
                    Console.WriteLine(goodFood + opt[3] + " then you should TGI Friday's! and travel in a Volkswagen bus!");
                }
                else if ((fun == 4) && (peeps >= 11))
                {
                    Console.WriteLine(goodFood + opt[3] + " then you should go to a buffet! and travel in an airplane.");
                }
                // END GOOD FOOD LOOP

                Console.WriteLine(); // ADD EMPTY LINE FOR FORMATTING

                bool inval = true;
                while (inval)
                {
                    Console.Write("Would you like to try a new expierence? Y/N? ");
                    string go = Console.ReadLine();
                    if ((go == "Y") || (go == "y") || (go == "Yes") || (go == "yes"))
                    {
                        repeat = true;
                        Console.Clear();
                        break;
                    }
                    else if ((go == "N") || (go == "n") || (go == "No") || (go == "no"))
                    {
                        repeat = false;
                        break;
                    }
                    else if ((go != "Y") || (go != "y") || (go != "N") || (go != "n"))
                    {
                        Console.Beep(); Console.Beep(); Console.Beep();
                        Console.WriteLine(error);
                    }
                    else
                    {
                        repeat = false;
                    }
                }
            }
            Console.ForegroundColor = ConsoleColor.Green; // ADDING COLOR
            Console.WriteLine(); // ADD EMPTY LINE FOR FORMATTING
            Console.WriteLine("Excellent choices my beautiful user!! \nHave an extraordinary day! \nGoodbye :) \nPress any key to exit. . . ");
            Console.ReadKey();
        }
    }
}
