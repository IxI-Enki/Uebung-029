/*------------------------------------------------------------------------------
 *                      HTBLA-Leonding / Class: 3ACIF
 *------------------------------------------------------------------------------
 *                      Jan Ritt
 *------------------------------------------------------------------------------
 *  Description:  The program generates a random number between 1 and 100
 *                and the user shall guess it, 
 *                or abort the program with "E" or "e"
 *------------------------------------------------------------------------------
*/
using System;

namespace Zahlenraten
{
  internal class Program
  {
    static void Main()
    {
      int rndNumber,
          userInt = -1,
          guessCounter = 1;
      string userInput;
      bool abort = false;

      // generate a Random Number between 1 and 100:
      Random random = new Random();
      rndNumber = random.Next(1, 101);

      Console.Write("\n           Zahlenraten          " +
                    "\n================================" +
                    "\n versuche meine Zahl zu erraten " +
                    "\n ( von 1 bis 100 )");
      do
      {
        Console.Write($"\n {guessCounter}. Versuch:  ");
        userInput = Console.ReadLine();
        int.TryParse(userInput, out userInt);
        if ((userInput == "E") || (userInput == "e"))
        {
          abort = true;
        }
        else
        {
          if (userInt < rndNumber)
          {
            Console.Write("\n Gesuchte Zahl ist größer, ");
          }
          if (userInt > rndNumber)
          {
            Console.Write("\n Gesuchte Zahl ist kleiner, ");
          }
          guessCounter++;
        }
      } while ((!abort) && (userInt != rndNumber));

      if (!abort)
      {
        if (guessCounter > 0 && guessCounter <= 5)
        {
          Console.Write("\n Tolle Leistung!");
        }
        else if (guessCounter > 5 && guessCounter <= 10)
        {
          Console.Write("\n Schon ganz gut!");
        }
        else
          Console.Write("\n Endlich geschafft!");
      }
      Console.Write("\nZum Beenden bitte Eingabetaste drücken ...");
      Console.ReadLine();
      Console.Clear();
    }
  }
}