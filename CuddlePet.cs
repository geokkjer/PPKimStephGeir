using System.Security.Cryptography.X509Certificates;

namespace MasterSpace
{ 
    public class CuddlePet
    {
        public Pet Hypno = new Pet ("Hypno","Frog",1);
        public Pet Billy = new Pet("Billy", "Goat", 2);

        public void MainMenu()
        {    
            Console.WriteLine("Choose a pet");
            Console.WriteLine("1. Hypno the frog");
            Console.WriteLine("2. Billy the goat");
            var userInput = Console.ReadLine();
            switch (userInput) { 
                case "1":
                    Hypno.InteractMenu();
                    break;
                case "2":
                    Billy.InteractMenu();
                    break;
                case "3":
                    break;

            }
        
        }  
     
    }
}