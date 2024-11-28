using System.Xml.Linq;

namespace MasterSpace
{
    public class Pet
    {
        string Name;
        string Type;
        int Age;
        bool Cuddle;
        bool Hungry;
        bool NeedToilet;
        public Pet(string name, string type, int age)
        {
            Name = name;
            Type = type;
            Age = age;
            Cuddle = false;
            Hungry = false;
            NeedToilet = false;

        }
        
        public void InteractMenu()
        {
            bool running = true;
            
            while (running)
            {
                Thread.Sleep(1000);
               Console.Clear();

                Console.WriteLine(" Hey " + Name + "!");
                Console.WriteLine(" Type: " + Type);
                Console.WriteLine(" Age " + Age);
                Console.WriteLine((Cuddle) ?  " Need to cuddle " : " Has been cuddled ");
                Console.WriteLine((Hungry) ?  " Is starving " : " Has a full belly");
                Console.WriteLine((NeedToilet) ?   " Need to poop " : " Doesn't need to to poop");


                Console.WriteLine("\nwhat do you want to do?");
                Console.WriteLine();
                Console.WriteLine("1. Cuddle");
                Console.WriteLine("2. Feed");
                Console.WriteLine("3. WC");
                Console.WriteLine("4. Exit");
                var userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        Cuddles();
                        break;
                    case "2":
                        Feed();
                        break;
                    case "3":
                        NeedToilet = true;
                        Console.WriteLine("Buisness Done!");
                        break;
                    case "4":
                        running = false;
                        break;

                }



            }
        }

        void Cuddles()
        {
            if (Cuddle)
            {
                Console.WriteLine("Happy Camper!");
                Cuddle = false;
            }
            else
            {
                Console.WriteLine("Bites!!");
                Cuddle = true;
            }
        }

        void Feed()
        {
            if (Hungry)
            {
                Console.WriteLine("Fed And Well");
                Hungry = false;
            }
            else
            {
                Console.WriteLine("Throws up!!");
                Hungry = true;
            }
        }

        void Walk()
        {
            if (NeedToilet)
            {
                Console.WriteLine("Jumps all around and Plays");
                NeedToilet = false;
            }
            else
            {
                Console.WriteLine("Run Away!!");
                NeedToilet = true;
            }
        }

    }
}