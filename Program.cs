Console.ForegroundColor = ConsoleColor.Magenta;
int menyVal = 0;
int minTal = 1;
int maxTal = 10;
int dittTal = 0;
int datornsTal = 0;

string speletsRegler = "I varje omgång av gissa talet ska datorn slumpa fram ett heltal mellan 1 och 10." +
    "\nAnvändaren ska gissa vilket talet är ända tills hen gissar rätt. " +
    "\nEfter varje gissning ska användaren få veta om gissningar var rätt, för hög eller för låg.";

Random slumpTal = new Random();

// Välkomna användaren till Gissa Talet
Console.WriteLine("Hej, välkommen till gissa talet.");
Console.WriteLine("Gör ett menyval.");

//Presentera menyval
//1. Spela "Gissa Talet"
//2. Spelets regler.
//3. Avsluta program
// Default
while (menyVal != 3)
{
    Console.WriteLine("1. Spela Gissa Talet.");
    Console.WriteLine("2. Spelets regler.");
    Console.WriteLine("3. Avsluta program.");

    menyVal = Convert.ToInt32(Console.ReadLine());

    switch (menyVal)
    {
         
        case 1:
            //Datorn slumpar fram ett tal mellan 1-10
            datornsTal = slumpTal.Next(minTal, maxTal);

            //Användaren gissar vilket tal som datorn slumpat fram
            Console.WriteLine("Gissa talet, 1-10");
            dittTal = Convert.ToInt32(Console.ReadLine());

            //Användaren gissar tills talet är rätt
            //Efter varje gissning får användaren veta om den gissat rätt, för högt eller för lågt.
            while (dittTal != datornsTal)
            {
                if (dittTal > datornsTal)
                {
                    Console.WriteLine($"Du gissade fel. Talet {dittTal} var för högt.");
                }

                else if (dittTal < datornsTal)

                {
                    Console.WriteLine($"Du gissade fel. Talet {dittTal} var för lågt.");
                }
                

                //datornsTal = slumpTal.Next(minTal, maxTal);


                Console.WriteLine("Gissa talet igen, 1-10");
                dittTal = Convert.ToInt32(Console.ReadLine());

            }
            if (dittTal == datornsTal)
            {
                Console.WriteLine($"Grattis! Du gissade rätt. Talet var {dittTal}");
                break;
            }
            
            break;

        case 2:

            Console.WriteLine($"Detta är spelets regler: {speletsRegler}");
            
            break;

        case 3:

            Console.WriteLine("Programmet avslutas..");

            break;

        default:

            Console.WriteLine("Felaktig inmatning.. vänligen försök igen. Välj menyval 1-3.");

            break;
    }

    
}
Console.ReadLine();
