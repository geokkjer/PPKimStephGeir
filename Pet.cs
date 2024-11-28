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
            Console.WriteLine((Cuddle) ? " Need to cuddle " : " Has been cuddled ");
            Console.WriteLine((Hungry) ? " Is starving " : " Has a full belly");
            Console.WriteLine((NeedToilet) ? " Need to poop " : " Doesn't need to to poop");
            Console.WriteLine("\nwhat do you want to do?");
        }

    }
}