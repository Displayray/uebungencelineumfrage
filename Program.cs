using System;

namespace  umfrageübungceline
{
    class Program
    {
        static void Main()
        {
            string[] namen = { "Clown", "Dummi", "Fiti", "Halt", "Lustig", "Mausi", "Mimi", "Null", "Rost", "Toll", "Zelli", "Zorn" };
            int[] koerpergroeße = { 171, 189, 167, 192, 176, 183, 190, 172, 185, 167, 191, 180 };
            int[] geschwister = { 3, 1, 4, 0, 2, 4, 3, 0, 1, 2, 4, 0 };
            string[] lieblingsfach = { "Sport", "IT", "Englisch", "Sport", "Mathe", "Sport", "Englisch", "Mathe", "IT", "Sport", "Mathe", "Englisch" };

            /* A2 Durschnittliche Größe 
            int gesamtgröße = 0;
            for (int i = 0; i < koerpergroeße.Length; i++)
            {
                gesamtgröße += koerpergroeße[i];
            }
            int durchschnitt = gesamtgröße / koerpergroeße.Length;
            Console.WriteLine($"Durschnittliche Körpergröße: {durchschnitt}cm"); */
            
            /* A3 Anzahl der Schüler mit mindestens 2 Geschwistern 
            int anzahl = 0;
            for (int i = 0; i < geschwister.Length; i++)
            {
                if (geschwister[i] >= 2) anzahl++;
            }
            double prozentsatz = ((double)anzahl / (double)geschwister.Length) * 100;
            prozentsatz = Math.Round(prozentsatz);
            Console.WriteLine($"Prozentsatz der Schüler mit mindestens 2 Geschwistern: ({prozentsatz}%)");*/
            
            /* A4 180 und nicht sport
            for (int i = 0; i < koerpergroeße.Length; i++)
            {
                if(koerpergroeße[i] >= 180 && lieblingsfach[i] != "Sport")
                {
                    Console.WriteLine(namen[i] + " ist über 180cm und mag kein Sport");
                }
            }*/
            
            /* A5 häufigstes lieblingsfach */
            
            /* A6 namen der Personen mit dem Lieblingsfach IT 
            for(int i = 0;i < lieblingsfach.Length; i++)
            {
                if(lieblingsfach[i] == "IT")
                {
                    Console.WriteLine(namen[i]);
                }
            }*/
            
            /* A7 Namen die mit "M" beginnen
            for (int i = 0; i < namen.Length; i++)
            {
                string curname = namen[i];
                char firstletter = curname[0];
                if(firstletter == 'M')
                {
                    Console.WriteLine(namen[i]);
                }
            }*/

        }
    }
}