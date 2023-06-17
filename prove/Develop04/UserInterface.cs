using System;
using System.Threading;

namespace Develop04
{
    class UserInterface
    {
        public int Menu()
        {
            // Console display
            Console.WriteLine("1. Start breathing activity.");
            Console.WriteLine("2. Start reflection activity.");
            Console.WriteLine("3. Start listing activity.");
            Console.WriteLine("4. Quit.");
            Console.Write("Enter a number to select an option: ");

            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Clear();

            return input;
        }

        public void Animation(int runtime)
        {
            // Stores the animation.
            // the animation has a base time of 4 seconds to complete
            string[] animation = { "-", "\\", "|", "/" };
            int count = 0;
            Console.WriteLine("Just a moment...");

            // loops trought the animation takes about 5 seconds
            while (count != runtime)
            {
                foreach (string value in animation)
                {
                    Thread.Sleep(1000);
                    Console.Write(value);
                    Console.Write("\b");
                }
                count++;
            }
            Console.WriteLine();
        }

        public void CountDown(int runtime)
        {
            // Stores the animation.
            // the animation has a base time of 4 seconds to complete
            for (int i = runtime; i > -1; i--)
            {
                Thread.Sleep(1000);
                Console.Write(i);
                Console.Write("\b");
            }
            Console.WriteLine();
        }

        // Builds the start message for all the activies and returns the user input for activity duration 
        private int BuildStartMessage(string activityType, string activityDescription)
        {
            Console.WriteLine($"Welcome to the {activityType} activity.");
            Console.WriteLine();

            Console.WriteLine(activityDescription);
            Console.WriteLine();

            Console.Write("Please enter the amount of time you would like the activity to run for in intervales of 10 seconds: ");
            int duration = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            return duration;
        }

        // the exit MSG show at teh end of all activities
        public void ExitMSG()
        {
            // Congragulate the user for completed activity
            Console.WriteLine("Well Done!");
            Animation(1);
            Console.Clear();
        }

        // ------- ------- ------- Activity Runs ------- ------- ------- \\ 

        public void RunListening(Listening listening)
        {
            // Welcome and description messages
            int duration = BuildStartMessage("listening", listening.GetActivityDescription());
            listening.SetDuration(duration);

            // Activity instructions
            Console.WriteLine("  List as many response as you can,:");
            Console.WriteLine("Hit enter to move to the next response.");
            Console.WriteLine("---------------------------------------");
            Animation(2);
            Console.Clear();

            // Print question then wait for user to be ready
            listening.GetQuestion();
            Console.WriteLine("Hit enter when ready.");

            listening.StartTimer();

            // Let user enter responses as long as time isn't up
            while (listening.CheckTime() != 1)
            {
                // ------------------------- BUG HERE -------------------------------------- BUG
                Console.Write("> ");
                string response = Console.ReadLine();
                listening.StoreResponse(response);
            }
        }

        public void RunBreathing(Breathing breath)
        {
            // Welcome and description messages
            int duration = BuildStartMessage("breathing", breath.GetActivityDescription());
            breath.SetDuration(duration);

            // Set the breating in and out times
            breath.setBreathInTime(5);
            breath.setBreathOutTime(5);
            Animation(1);
            Console.Clear();

            // Give them a warning the activity is about to start
            Console.WriteLine("Get ready...");
            Console.WriteLine();

            breath.StartTimer();

            // Run the activity until time is up
            while (breath.CheckTime() != 1)
            {
                Console.Write("Breath In... ");
                CountDown(5);

                Console.Write("Breath Out... ");
                CountDown(5);
            }
        }

        public void RunReflection(Reflection reflect)
        {
            // Welcome and description messages
            int duration = BuildStartMessage("reflection", reflect.GetActivityDescription());
            reflect.SetDuration(duration);

            // Show promt and wait for user to be ready
            Console.WriteLine("Consder the following prompt");
            Console.WriteLine($">> {reflect.ShowPrompt()}");
            Console.Write("When you have some ideas in mind, press enter...");
            Console.ReadLine();
            Console.Clear();

            // Count down tell avtivity start
            Console.WriteLine("Answer each of the following questions as they relate to your experience.");
            Console.Write("You may beigin in...");
            CountDown(5);

            reflect.StartTimer();

            // Show questions until time is up
            while (reflect.CheckTime() != 1)
            {
                Console.WriteLine(reflect.ShowQuestion());
                CountDown(5);
            }
        }
    }
}