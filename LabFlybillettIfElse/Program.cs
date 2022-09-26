using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFlybillettIfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Oppgave i if else, med litt prosentregning

            //Et flyselskap gir følgende rabatter på billettprisen, avhengig av alder:
            //Under 2 år: 90 % rabatt
            //2 - 12 år: 50 % rabatt
            //13 - 18 år: 30 % rabatt
            //19 - 66 år: 0 % rabatt
            //67 år og over: 40 % rabatt

            //Lag et program(Console Application,  som leser inn full pris og kundens alder, og deretter beregner og skriver ut prisen kunden skal betale.

            //Litt hjelp på veien:

            //Bruk feks disse tre variablene:
            //int alder;
            //int fullPris;
            //double prisEtterRabatt;

            //Skrive til konsoll:
            //Console.WriteLine("tast inn pris!");
            //Lese inn fra konsoll:
            //alder = int.Parse(Console.ReadLine());

            //Hvordan regne med prosent:
            double sum;//vi bruker datatypen double fordi regning med prosent kan bli et desimaltall
            //Hva må du betale hvis du får 30% avslag på 100 kr?
            sum = 100 * 0.7;
            //hva må du betale hvis du får 80% avslag på 100 kr?
            sum = 100 * 0.2;

            //hvordan bruke intervaller i en if?
            //Eksempel. Du skal bare få rabatt hvis du er fra og med 20 år til og med 30 år. Det vil si at er alder større enn 19 og mindre enn 31.
            //Console.WriteLine("Tast inn hvilken type flybillet du reiser med. 1 for Øknomi, 2 for Business, 3 for First Class.");
            //int fullPriss = int.Parse(Console.ReadLine());
            //int billettType = int.Parse(Console.ReadLine());
            int fullPris;

            while (true)
            {
                Console.WriteLine("Tast inn hvilken type flybillet du reiser med. 1 for Øknomi, 2 for Business, 3 for First Class.");
                int billettType = int.Parse(Console.ReadLine());

                if (billettType == 1)
                {
                    fullPris = 1500;
                    Console.WriteLine("Økonomi fullpris er 1500NOK"); 
                    break;
                }
                else if (billettType == 2)
                {
                    fullPris = 5000;
                    Console.WriteLine("Business fullpris er 5000NOK");
                    break;
                }
                else if (billettType == 3)
                {
                    fullPris = 12000;
                    Console.WriteLine("Economy fullpris er 12000NOK");
                    break;
                }
                else
                {
                    Console.WriteLine("Vennligst tast inn en gyldig billett type.");
                }
            }

            while (true)
            {
                Console.WriteLine("Tast inn din alder for å sjekke rabatt");
                int alder = int.Parse(Console.ReadLine());

                if (alder > 0 && alder < 3)//større enn 19 og mindre enn 31. && betyr og 
                {
                    double prisEtterRabatt = fullPris * 0.1;
                    Console.WriteLine("Du får 90% rabatt på billetten din. Din nye pris er nå: " + prisEtterRabatt + "NOK");
                    break;
                }
                else if (alder > 1 && alder < 13)
                {
                    double prisEtterRabatt = fullPris * 0.5;
                    Console.WriteLine("Du får 50% rabatt på billetten din. Din nye pris er nå: " + prisEtterRabatt + "NOK");
                    break;
                }
                else if (alder > 12 && alder < 19)
                {
                    double prisEtterRabatt = fullPris * 0.7;
                    Console.WriteLine("Du får 30% rabatt på billetten din. Din nye pris er nå: " + prisEtterRabatt + "NOK");
                    break;
                }
                else if (alder > 18 && alder < 67)
                {
                    Console.WriteLine("Din aldersgruppe (18 - 67) får dessverre ingen rabatt på denne turen. Din billett vil koste: " + fullPris + "NOK");
                    break;
                }
                else if (alder > 66)
                {
                    double prisEtterRabatt = fullPris * 0.6;
                    Console.WriteLine("Du får 40% rabatt på billetten din. Din nye pris er nå: " + prisEtterRabatt + "NOK");
                    break;
                }
                else
                {
                    Console.WriteLine("Vennligst skriv inn en gyldig alder.");
                }
            }
            Console.ReadLine();

            //les linken under for å se hvordan if -  else if og else brukes

                //lesestoff: https://kodify.net/csharp/if-else/cascaded-if-statement/

                //DIN KODE UNDER HER
        }
    }
}
