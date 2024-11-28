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
            Cuddle = true;
            Hungry = false;
            NeedToilet = false;

        }
        public void InteractMenu()
        {
            Console.WriteLine(" Hey " + Name + "!");
            Console.WriteLine(" Type: " + Type);
            Console.WriteLine(" Age " + Age);
            Console.WriteLine(" Has been cuddled " + Cuddle);
            Console.WriteLine(" Is starving " + Hungry);
            Console.WriteLine(" Need to poop " + NeedToilet);
            Console.WriteLine("\nwhat do you want to do?");
        
        }

    }
}