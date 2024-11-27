namespace CuddlePet
{
    public class Pet
    {
        string Name;
        string Type;
        int Age;
        bool Cuddle;
        bool Hungry;
        bool NeedToilet;

        void PetConstructor(string name, string type, int age)
        {
            Name = name;
            Type = type;
            Age = age;
            Cuddle = true;
            Hungry = false;
            NeedToilet = false;
        }
    }
}