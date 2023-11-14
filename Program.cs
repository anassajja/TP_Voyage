using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****************************Hello To Our Trip Agency***************************************");
            List<Chauffeur> chauffeurs = new List<Chauffeur>{
                new Chauffeur("123456", "Anass", "AJJA"),
                new Chauffeur("654321", "Ziyad", "TEGTI"),
                new Chauffeur("987654", "Yassine", "EL HAMIDI"),
            };
            List<Bus> buses = new List<Bus>{
                new Bus("123456AA", "BMW", "Série 3"),
                new Bus("654321BB", "Honda", "Civic"),
                new Bus("987654CC", "Mercedes", "Classe A"),
            };
            List<Voyage> voyages = new List<Voyage>{
                new Voyage(1, chauffeurs[1], buses[1], new DateTime(2023, 9, 9), "Casablanca", "Saidia", 18, 2000.00f),
                new Voyage(2, chauffeurs[1], buses[1], new DateTime(2023, 12, 23), "Casablanca", "Al hoceima", 10, 1000.00f),
            };

            void FindDriver()
            {
                Console.Write("Enter the driver CIN : ");
                string? cin = Console.ReadLine() ?? "";
                bool driverFound = false;
                foreach (Chauffeur chauffeur in chauffeurs)
                {
                    if (chauffeur.Cin == cin)
                    {
                        Console.WriteLine(chauffeur.ToString());
                        driverFound = true;
                        break;  // Move the break statement inside the if condition
                    }
                }
                if (!driverFound)
                {
                    Console.WriteLine("No driver found with this CIN !");
                }
            }

            void FindBus()
            {
                Console.Write("Enter the bus immatriculation : ");
                string? immatriculation = Console.ReadLine() ?? "";
                bool busFound = false;
                foreach (Bus bus in buses)
                {
                    if (bus.Immatriculation == immatriculation)
                    {
                        Console.WriteLine(bus.ToString());
                        busFound = true;
                        break;  // Exit the loop once a bus is found
                    }
                }
                if (!busFound)
                {
                    Console.WriteLine("No bus found with this immatriculation !");
                }
            }

            void FindVoyage()
            {
                Console.Write("Enter the voyage number : ");
                int? numeroVoyage = int.Parse(Console.ReadLine() ?? "");
                bool voyageFound = false;
                foreach (Voyage voyage in voyages)
                {
                    if (voyage.NumeroVoyage == numeroVoyage)
                    {
                        Console.WriteLine(voyage.ToString());
                        voyageFound = true;
                        break;  // Exit the loop once a voyage is found
                    }
                }
                if (!voyageFound)
                {
                    Console.WriteLine("No voyage found with this number !");
                }
            }

            int choice = 0;
            
            do
            {
                Console.WriteLine("Menu :");
                Console.WriteLine("1. Display the list of drivers");
                Console.WriteLine("2. Display the list of buses");
                Console.WriteLine("3. Display the list of voyages");
                Console.WriteLine("4. Find a driver");
                Console.WriteLine("5. Find a bus");
                Console.WriteLine("6. Find a voyage");
                Console.WriteLine("7. Add a driver");
                Console.WriteLine("8. Add a bus");
                Console.WriteLine("9. Add a voyage");
                Console.WriteLine("10. Display the list of voyages between two dates");
                Console.WriteLine("11. Number of voyages per recent years");
                Console.WriteLine("12. Number of voyagers per recent years");
                Console.WriteLine("13. Quitter");
                Console.Write("Enter choice : ");
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    switch (choice)
                    {
                        case 1:
                            foreach (Chauffeur chauffeur in chauffeurs)
                            {
                                Console.WriteLine(chauffeur.ToString());
                            }
                            break;

                        case 2:
                            foreach (Bus bus in buses)
                            {
                                Console.WriteLine(bus.ToString());
                            }
                            break;

                        case 3:
                            foreach (Voyage voyage in voyages)
                            {
                                Console.WriteLine(voyage.ToString());
                            }
                            break;

                        case 4:
                            FindDriver();
                            break;

                        case 5:
                            FindBus();
                            break; 

                        case 6:
                            FindVoyage();
                            break; 

                        case 7:

                            Console.WriteLine("Enter the driver CIN :");
                            string? cin = Console.ReadLine() ?? "";
                            Console.WriteLine("Enter the driver Last name :");
                            string? nom = Console.ReadLine() ?? "";
                            Console.WriteLine("Enter the driver First name:");
                            string? prenom = Console.ReadLine() ?? "";
                            chauffeurs.Add(new Chauffeur(cin, nom, prenom));
                            break;
                        case 8:

                            Console.WriteLine("Enter the bus immatriculation :");
                            string? immatriculation = Console.ReadLine() ?? "";
                            Console.WriteLine("Enter the bus brand :");
                            string? marque = Console.ReadLine() ?? "";
                            Console.WriteLine("Enter the bus model :");
                            string? modele = Console.ReadLine() ?? "";
                            buses.Add(new Bus(immatriculation, marque, modele));
                            break;

                        case 9:
                            // Assuming you have a variable to keep track of the maximum voyage number
                            int maxVoyageNumber = voyages.Count > 0 ? voyages.Max(v => v.NumeroVoyage) : 0;
                            // Increment the maxVoyageNumber for the new voyage
                            int numeroVoyage = maxVoyageNumber + 1;
                            Console.WriteLine($"The voyage number is automatically set to {numeroVoyage}: ", numeroVoyage);
                            Console.Write("Enter the voyage driver CIN : ");
                            string? cinVoyage = Console.ReadLine() ?? "";
                            Console.Write("Enter the voyage bus immatriculation : ");
                            string? immatriculationVoyage = Console.ReadLine() ?? "";
                            Console.Write("Enter the voyage date : ");
                            DateTime? dateVoyage = DateTime.Parse(Console.ReadLine() ?? "");
                            Console.Write("Enter the voyage departure city : ");
                            string? villeDepart = Console.ReadLine() ?? "";
                            Console.Write("Enter the voyage arrival city : ");
                            string? villeArrivee = Console.ReadLine() ?? "";
                            Console.Write("Enter the voyage number of seats : ");
                            int? numberDePlace = int.Parse(Console.ReadLine() ?? "");
                            Console.Write("Enter the voyage ticket price : ");
                            float? prixBillet = float.Parse(Console.ReadLine() ?? "");
                            foreach (Chauffeur chauffeur in chauffeurs)
                            {
                                foreach (Bus bus in buses)
                                {
                                    if (chauffeur.Cin == cinVoyage && bus.Immatriculation == immatriculationVoyage)
                                    {
                                        voyages.Add(new Voyage(numeroVoyage, chauffeur, bus, dateVoyage ?? DateTime.Now, villeDepart, villeArrivee, numberDePlace ?? 0, prixBillet ?? 0.0f));
                                        break;  // Exit the loop once a bus is found
                                    }
                                    else
                                    {
                                        if (chauffeur.Cin != cinVoyage)
                                        {
                                            Console.WriteLine("No driver found with this CIN !");
                                            Console.WriteLine("Voyage not added !");
                                            
                                        }
                                        if (bus.Immatriculation != immatriculationVoyage)
                                        {
                                            Console.WriteLine("No bus found with this immatriculation !");
                                            Console.WriteLine("Voyage not added !");
                                            
                                        }
                                    }
                                    break;
                                }
                                break;
                            }
                            break;

                        case 10:
                            Console.Write("Enter the start date : \n");
                            DateTime? startDate = DateTime.Parse(Console.ReadLine() ?? "");
                            Console.Write("Enter the end date : \n");
                            DateTime? endDate = DateTime.Parse(Console.ReadLine() ?? "");
                            foreach (Voyage voyage in voyages)
                            {
                                if (voyage.DateVoyage >= startDate && voyage.DateVoyage <= endDate)
                                {
                                    Console.WriteLine(voyage.ToString());
                                }
                                else
                                {
                                    Console.WriteLine("No voyages found in this period");
                                }
                            }
                            break;

                        case 11:
                            foreach (Voyage voyage in voyages)
                            {
                                if (voyage.DateVoyage.Year == DateTime.Now.Year)
                                {
                                    Console.WriteLine(voyage.ToString());
                                }
                                else
                                {
                                    Console.WriteLine("No voyages found in this year");
                                }
                            }
                            break;
                            
                        case 12:
                            int total = 0;
                            foreach (Voyage voyage in voyages)
                            {
                                if (voyage.DateVoyage.Year == DateTime.Now.Year)
                                {
                                    total += voyage.NumberDePlace;
                                }
                            }
                                Console.WriteLine($"The total number of voyagers in {DateTime.Now.Year} is {total}");
                            break;

                        case 13:
                            Console.WriteLine("Goodbye !");
                            break;

                        default:   
                            Console.WriteLine("Invalid choice");
                            break;
                    }
                }
                else
                {
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    Console.WriteLine("Error parsing choice");
                }
            } while (choice != 13);
        }
    }
}
