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

            return input;
        }

        public void Animation(int runtime)
        {
            // Stores the animation.
            // the animation has a base time of 4 seconds to complete
            string[] animation = { "-", "\\", "|", "/" };
            int count = 0;
            Console.WriteLine("Just a moment...");

            while (count != runtime)
            {
                foreach (string value in animation)
                {
                    Thread.Sleep(1000);
                    Console.Write("\b");
                    Console.Write(value);
                }
                Console.Write("\b");
                Console.WriteLine();
                Console.WriteLine();
                count++;
            }
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

            Console.WriteLine(activityDescription);

            Console.Write("Please enter the amount of time you would like the activity to run for in intervales of 10 seconds: ");
            int duration = Convert.ToInt32(Console.ReadLine());
            return duration;
        }

        public void ExitMSG()
        {
            // Congragulate the user for completed activity
            Console.WriteLine("Well Done!");
            Animation(5);
        }

        // ------- ------- Activity Runs ------- ------- \\ 

        public void RunListening(Listening listening)
        {
            // Welcome and description messages
            int duration = BuildStartMessage("listening", listening.GetActivityDescription());
            listening.SetDuration(duration);

            // Activity instructions
            Console.WriteLine("  List as many response as you can,:");
            Console.WriteLine("Hit enter to move to the next response.");
            Console.WriteLine("---------------------------------------");
            Animation(5);

            // Print question then wait for user to be ready
            listening.GetQuestion();
            Console.WriteLine("Hit enter when ready.");

            // Let user enter responses as long as time isn't up
            while (listening.CheckTime() != 1)
            {
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
        }
    }
}