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
            int alder;
            alder = 23;
            if (alder > 19 && alder < 31)//større enn 19 og mindre enn 31. && betyr og 
            {
                Console.WriteLine("Du er et sted mellom 20 og 30 år.");
            }

            //les linken under for å se hvordan if -  else if og else brukes

            //lesestoff: https://kodify.net/csharp/if-else/cascaded-if-statement/

            //DIN KODE UNDER HER
        }
    }
}
