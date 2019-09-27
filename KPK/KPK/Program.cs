using System;

namespace KPK
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kivipaberkäärid!");
            Console.WriteLine("Kuidas mängida? Kivi=1 ; Paber=2 ; Käärid=3");
            Console.WriteLine("Sisesta oma käemärk (nr)");
            
            int käemärk;
            int rolls = 0;
            int userscore = 0;
            int cpuscore = 0;

            while (rolls < 3)
            {
                
                käemärk = int.Parse(Console.ReadLine());

                if (käemärk < 1 || käemärk > 3)
                {
                    Console.WriteLine("Sisesta sobiv number.");
                }
                else
                {
                    if (käemärk == 1)
                    {
                        Console.WriteLine("Sa viskasid Kivi.");
                    }
                    else if (käemärk == 2)
                    {
                        Console.WriteLine("Sa viskasid Paberi");
                    }
                    else
                    {
                        Console.WriteLine("Sa viskasid Käärid.");

                    }


                    Random randomGenerator = new Random();
                    int randomNumber = randomGenerator.Next(1, 3);
                    if (randomNumber == 1)
                    {
                        Console.WriteLine("Arvuti viskas Kivi");
                    }
                    else if (randomNumber == 2)
                    {
                        Console.WriteLine("Arvuti viskas Paberi.");
                    }
                    else
                    {
                        Console.WriteLine("Arvuti viskas käärid.");
                    }



                    if (käemärk == 1 && randomNumber == 1)
                    {
                        Console.WriteLine("Viik!");

                    }
                    else if (käemärk == 1 && randomNumber == 2)
                    {
                        Console.WriteLine("Sa kaotasid!");
                        cpuscore++;
                    }
                    else if (käemärk == 1 && randomNumber == 3)
                    {
                        Console.WriteLine("Sa võitsid");
                        userscore++;
                    }
                    else if (käemärk == 2 && randomNumber == 1)
                    {
                        Console.WriteLine("Sa võitsid");
                        userscore++;
                    }
                    else if (käemärk == 2 && randomNumber == 2)
                    {
                        Console.WriteLine("Viik!");
                        
                    }
                    else if (käemärk == 2 && randomNumber == 3)
                    {
                        Console.WriteLine("Sa kaotasid!");
                        cpuscore++;
                    }
                    else if (käemärk == 3 && randomNumber == 1)
                    {
                        Console.WriteLine("Sa kaotasid!");
                        cpuscore++;
                    }
                    else if (käemärk == 3 && randomNumber == 2)
                    {
                        Console.WriteLine("Sa võitsid!");
                        userscore++;
                    }
                    else if (käemärk == 3 && randomNumber == 3)
                    {
                        Console.WriteLine("Viik!");
                        continue;
                    }
                    // score display
                    Console.WriteLine($"Punktid on järgmised,  sina:{userscore} arvuti:{cpuscore}");

                    rolls++;

                    
                }
                
                
                   
            }
 if (userscore < cpuscore)
                    {
                        Console.WriteLine($"Võitja on arvuti skooriga {cpuscore}:{userscore}");
                    }
                    else if (userscore > cpuscore)
                    {
                        Console.WriteLine($"Võitja on inimene skooriga {userscore}:{cpuscore}");
                    }
                    else
                    {
                        Console.WriteLine("Tegu on viigiga!");
                    }
                
                Console.ReadLine();
        }

    }
}
