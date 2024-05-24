using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProgrammering_uke_1
{
    internal class Pets
    {
        public string PetName { get; private set; }
        public int PetAge { get; private set; }
        bool IsHungry = false;
        bool MustUseToilet = false;

        public Pets(string petName, int petAge, bool isHungry, bool mustUseToilet)
        {
            PetName = petName;
            PetAge = petAge;
            IsHungry = isHungry;
            MustUseToilet = mustUseToilet;
        }

        public Pets()
        {
        }
        public void ShowPet()
        {

            List<Pets> pets = new List<Pets>();

            Pets pet1 = new Pets("Theodor", 4, IsHungry, MustUseToilet);
            pets.Add(pet1);

            Pets pet2 = new Pets("Cassandra", 5, IsHungry, MustUseToilet);
            pets.Add(pet2);

            Pets pet3 = new Pets("Camilla", 6, IsHungry, MustUseToilet);
            pets.Add(pet3);

            Pets pet4 = new Pets("Sil", 3, IsHungry, MustUseToilet);
            pets.Add(pet4);

            Pets pet5 = new Pets("Bendy", 1, IsHungry, MustUseToilet);
            pets.Add(pet5);

            Console.WriteLine("Kjæledyr:");
            foreach (Pets pet in pets)
            {
                Console.WriteLine($"Navn: {pet.PetName}, Alder: {pet.PetAge}, Sult: {pet.IsHungry}, Blære: {pet.MustUseToilet}");
            }
            
            Console.WriteLine("Velg en av kattene for å klappe de, skriv ett tall mellom 1-5");

            var petChoise = Console.ReadLine();

            switch (petChoise)
            {
                case "1":
                
                    Console.WriteLine($"Navn: {pet1.PetName}");
                    Console.WriteLine("Hei, du har klappet meg, tusen takk! Mjau mjau.");
                    break;
                case "2":
                    Console.WriteLine($"Navn: {pet2.PetName}");
                    Console.WriteLine("prrmau :3");
                    break;
                case "3":
                    Console.WriteLine($"Navn: {pet3.PetName}");
                    Console.WriteLine("Jeg ville ikke bli klappet akkurat nå, kom tilbake senere!");
                    break;
                case "4":
                    Console.WriteLine($"Navn: {pet4.PetName}");
                    Console.WriteLine("Klapp meg på haka, eller bli banka");
                    break;
                case "5":
                    Console.WriteLine($"Navn: {pet5.PetName}");
                    Console.WriteLine("Magekos takk, jeg lover å ikke bite :3");
                    break;


            }

            

            

        }
    }
}