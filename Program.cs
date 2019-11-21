using System;

namespace Csharp_Dog
{
    class Program
    {
        private const string V = "";

        static void Main(string[] args)
        {
            int dogNum = 0;
            Console.WriteLine("Hello! I'm here to help you add your pets to our database. Let's start off by telling me how many pets you have. Please list the number of cats and dogs you have total.");
            dogNum = Int32.Parse(Console.ReadLine());
            Console.WriteLine(dogNum);
            if
                (dogNum > 0)
            {
                Pet[] pets = new Pet[dogNum];
                for (int i = 0; i < dogNum - 1; i++)
                {
                    Console.WriteLine("What is your pet's name?");

                    pets[i] = new Pet(Console.ReadLine());

                    Console.WriteLine($"Is {pets[i].Name} a male or female? [M/F]");
                    pets[i].Sx(Console.ReadLine());
                    string pronoun;
                    string fixSurgery;

                    if (pets[i].Sx() == "M")
                    {
                        pronoun = "he";
                        fixSurgery = "neuter";
                    }
                    else
                    {
                        pronoun = "she";
                        fixSurgery = "spay";
                    };
                    Console.WriteLine($"Is {pronoun} a cat or a dog?");
                    pets[i].Species = Console.ReadLine();
                    Console.WriteLine($"How old is {pets[i].Name}?");
                    pets[i].Age = Int32.Parse(Console.ReadLine());
                    Console.WriteLine($"Approximately how much does {pronoun} weigh?");
                    pets[i].Weight = Double.Parse(Console.ReadLine());

                    Console.WriteLine($"Do you know {pets[i].Name}'s breed?");
                    string afterBreed;
                    if (Console.ReadLine() == "Y" || Console.ReadLine() == "Yes")
                    {
                        Console.WriteLine($"Great! What is the breed?");
                        pets[i].Breed = Console.ReadLine();
                        afterBreed = "";
                    }
                    else
                    {
                        pets[i].Breed = "Unknown";
                        afterBreed = "That's okay!";
                    }
                    Console.WriteLine($"{afterBreed} The last thing we need to know is whether or not {pets[i].Name} has been {fixSurgery}ed.");
                    string fixedResponse = Console.ReadLine();
                    if (fixedResponse == "Y" || fixedResponse == "Yes")
                    {
                        pets[i].Fixed = true;
                    }
                    else
                    {
                        pets[i].Fixed = false;
                    }
                    if(i<pets.Length){
                        Console.WriteLine("Alright! Let's go on to the next pet.");
                        
                    }else{Console.WriteLine("Okay that's everybody! Thank you!");}
                }
            }
        }
    }

}

