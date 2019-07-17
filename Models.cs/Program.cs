using System;
using System.Collections.Generic;
using Park.Models;
namespace Park {
    public class Program {
        public static void Main () {
            Animal tiger = new Animal ("Mufasa", "tiger", "big", 5, 2014);
            Animal lion = new Animal ("Pumba", "lion", "big", 5, 2014);
            Animal mouse = new Animal ("Mickey", "mouse", "small", 1, 2019);
            Animal badger = new Animal ("Bill", "badger", "medium", 6, 2013);
            Animal parrot = new Animal ("Popka", "parrot", "small", 2, 2017);
            Animal deer = new Animal ("Bambi", "deer", "medium", 5, 2014);

            List<Animal> Animals = new List<Animal> () { tiger, lion, mouse, badger, parrot, deer };
            Console.WriteLine (tiger.GetAge ());
            Console.WriteLine ("Welcome to Animal Tracker! You can our animal by kind, size. age and date.");
            Console.WriteLine ("Press N to exit the tracker.");

            string input = Console.ReadLine ();
            if (input == "kind") {
                KindPhase ();
            } else if (input == "size") {
                SizePhase();

            } else if (input == "age") {

            } else if (input == "date") {

            } else if (input == "n") {

            }

            void KindPhase () {
                Console.WriteLine ("You have chosen to search by animal kind.");
                Console.WriteLine ("We have the following animal kinds: " + string.Join(",", AnimalKinds(Animals))); //method for getting all animal kinds
                Console.WriteLine ("Type in any of those to get those animals:");
                string kindInput = Console.ReadLine ();
                Console.WriteLine (GetByKind (kindInput, Animals)); //currently does not handle case of no animals in that list
            }

            HashSet<string> AnimalKinds(List<Animal> animalsList){
                HashSet<string> animalKinds= new HashSet<string>(); 
                for(int i = 0; i < animalsList.Count; i++){
                    animalKinds.Add(animalsList[i].GetKind());
                }
                return animalKinds;
            }

            List<Animal> GetByKind (string kind, List<Animal> animalsList) {
                List<Animal> returnList = new List<Animal> ();
                for (int i = 0; i < animalsList.Count; i++) {
                    if (animalsList[i].GetKind () == kind) {
                        returnList.Add (animalsList[i]);
                    }
                }
                return returnList;
            }
                void SizePhase () {
                Console.WriteLine ("You have chosen to search by animal size.");
                Console.WriteLine ("We have the following animals of these sizes: " + "zebras"); //method for getting all animal kinds
                Console.WriteLine ("Type in any of those to get those animals:big, small, medium");
                string sizeInput = Console.ReadLine ();
                Console.WriteLine (GetBySize (sizeInput, Animals)); //currently does not handle case of no animals in that list
            }

            

            List<Animal> GetBySize(string size, List<Animal> animalsList) {
                List<Animal> returnList = new List<Animal> ();
                for (int i = 0; i < animalsList.Count; i++) {
                    if (animalsList[i].GetSize () == size) {
                        returnList.Add (animalsList[i]);
                    }
                }
                return returnList;
            }


            //     List<Animal> GetBySize (string size, List<Animal> animalsList) {
            //         List<Animal> returnList = new List<Animal> ();
            //         for (int i = 0; i < animalsList.Count; i++) {
            //             if (animalsList[i].getSize () == size) {
            //                 returnList.Add (animalsList[i]);
            //             }
            //         }
            //         return returnList;
            //     }

            //     List<Animal> GetByAge (int age, List<Animal> animalsList) {
            //         List<Animal> returnList = new List<Animal> ();
            //         for (int i = 0; i < animalsList.Count; i++) {
            //             if (animalsList[i].getAge () >= age) {
            //                 returnList.Add (animalsList[i]);
            //             }
            //         }
            //         return returnList;
            //     }

            //     List<Animal> GetByDate (int date, List<Animal> animalsList) {
            //         List<Animal> returnList = new List<Animal> ();
            //         for (int i = 0; i < animalsList.Count; i++) {
            //             if (animalsList[i].getDate () >= age) {
            //                 returnList.Add (animalsList[i]);
            //             }
            //         }
            //         return returnList;
            //     }

        }

    }

}