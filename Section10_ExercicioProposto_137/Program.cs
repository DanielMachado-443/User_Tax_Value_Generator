using System;
using System.Collections.Generic;
using Section10_ExercicioProposto_137.Entities;

namespace Section10_ExercicioProposto_137
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n   Éoq of Section10 137 proposed exercise ");

            Console.Write("\n   Enter the number of tax payers: ");
            int TPayers = int.Parse(Console.ReadLine());

            List<Client> ClientList = new List<Client>();
            for(int i = 1; i <= TPayers; i++)
            {
                Console.Write($"\n\n   Is this #{i} client an individual or company? (i/c) ");
                char Answer = char.Parse(Console.ReadLine());

                while(Answer != 'i' && Answer != 'c')
                {
                    Console.WriteLine("\n   You've entered a invalid answer. Please, try it again! ");
                    Console.Write($"   Is this #{i} client an individual or company? (i/c)");
                    Answer = char.Parse(Console.ReadLine());
                }

                Console.Write("\n   What is the name of this client? ");
                string CName = Console.ReadLine();

                Console.Write("\n   Enter the client's year incoming ");
                double CIncoming = double.Parse(Console.ReadLine());
        
                if(Answer == 'i')
                {
                    Console.Write("\n   Enter the individual's heath spendings value: ");
                    double IHealth = double.Parse(Console.ReadLine());
                    ClientList.Add(new Individual(CName, CIncoming, IHealth));
                }
                else
                {
                    Console.Write("\n   Enter the company's number of employees: ");
                    int CEmployees = int.Parse(Console.ReadLine());
                    ClientList.Add(new Company(CName, CIncoming, CEmployees));
                }
            }

            double TotalTaxes = 0.0;            
            List<string> Conv = new List<string>();
            foreach(Client thatClient in ClientList)
            {
                TotalTaxes += thatClient.Taxes();
                Console.WriteLine(thatClient.ClientInfo());
                Conv.Add(thatClient.ClientInfo());

                if (ClientList.IndexOf(thatClient) == (ClientList.Count - 1))
                {
                    Console.WriteLine("\n   Total taxes: $" + TotalTaxes.ToString("F2"));
                    Conv.Add("\n   Total taxes: $" + TotalTaxes.ToString("F2"));
                }                
            }

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"G:\CS TXT Files\Section10_ExercicioProposto_137\Relatory " + ClientList.Count + ".txt"))
            foreach (string line in Conv)
            {
                file.WriteLine(line);
            }

            // FIRST QUESTION

            Console.Write("\n\n   Do you want to add a new list of clients? Type y to yes or n to finish: ");
            char Answer2 = char.Parse(Console.ReadLine());

            while(Answer2 != 'y' && Answer2 != 'Y' && Answer2 != 'n' && Answer2 != 'N')
            {
                Console.Write("\n   You've entered a invalid answer. Please, try it again! ");
                Console.Write("\n   Do you want to add a new list of clients? Type y to yes or n to finish: ");
                Answer2 = char.Parse(Console.ReadLine());
            }

            if(Answer2 == 'y' || Answer2 == 'Y')
            {
                Console.WriteLine();
                Operations(ClientList);
            }
            else
            {
                Console.WriteLine("\n   The end ");
                Console.WriteLine();
            }

            // DIVISION

            static void Operations(List<Client> thatList)
            {
                bool KeepIt = true;
                while(KeepIt)
                {
                    Console.Write("\n   Enter the number of tax payers: ");
                    int TPayers = int.Parse(Console.ReadLine());

                    List<Client> ClientList = new List<Client>();
                    for (int i = 1; i <= TPayers; i++)
                    {
                        Console.Write($"\n\n   Is this #{i} client an individual or company? (i/c) ");
                        char Answer = char.Parse(Console.ReadLine());

                        while (Answer != 'i' && Answer != 'c')
                        {
                            Console.WriteLine("\n   You've entered a invalid answer. Please, try it again! ");
                            Console.Write($"   Is this #{i} client an individual or company? (i/c)");
                            Answer = char.Parse(Console.ReadLine());
                        }

                        Console.Write("\n   What is the name of this client? ");
                        string CName = Console.ReadLine();

                        Console.Write("\n   Enter the client's year incoming ");
                        double CIncoming = double.Parse(Console.ReadLine());

                        if (Answer == 'i')
                        {
                            Console.Write("\n   Enter the individual's heath spendings value: ");
                            double IHealth = double.Parse(Console.ReadLine());
                            thatList.Add(new Individual(CName, CIncoming, IHealth));
                        }
                        else
                        {
                            Console.Write("\n   Enter the company's number of employees: ");
                            int CEmployees = int.Parse(Console.ReadLine());
                            thatList.Add(new Company(CName, CIncoming, CEmployees));
                        }
                    }

                    double TotalTaxes = 0.0;
                    List<string> Conv = new List<string>();
                    foreach (Client thatClient in thatList)
                    {
                        TotalTaxes += thatClient.Taxes();
                        Console.WriteLine(thatClient.ClientInfo());
                        Conv.Add(thatClient.ClientInfo());
                        
                        if (thatList.IndexOf(thatClient) == (thatList.Count - 1))
                        {
                            Console.WriteLine("\n   Total taxes: $" + TotalTaxes.ToString("F2"));
                            Conv.Add("\n   Total taxes: $" + TotalTaxes.ToString("F2"));
                        }
                    }                                        
                    
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"G:\CS TXT Files\Section10_ExercicioProposto_137\Inside\Relatory " + thatList.Count + ".txt"))
                    foreach (string line in Conv)
                    {
                        file.WriteLine(line);
                    }

                    // LOOP QUESTION

                    Console.Write("\n\n   Do you want to add a new list of clients? Type y to yes or n to finish: ");
                    char Answer2 = char.Parse(Console.ReadLine());

                    while (Answer2 != 'y' && Answer2 != 'Y' && Answer2 != 'n' && Answer2 != 'N')
                    {
                        Console.Write("\n   You've entered a invalid answer. Please, try it again! ");
                        Console.Write("\n   Do you want to add a new list of clients? Type y to yes or n to finish: ");
                        Answer2 = char.Parse(Console.ReadLine());
                    }

                    if (Answer2 == 'y' || Answer2 == 'Y')
                    {
                        Console.WriteLine();                        
                    }
                    else
                    {
                        KeepIt = false;
                        Console.WriteLine("\n   The end ");
                        Console.WriteLine();
                    }
                }                
            }
        }
    }
}
