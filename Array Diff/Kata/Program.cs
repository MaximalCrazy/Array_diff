using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata
{
    public class Program
    {
        static void Main(string[] args)
        {

        }
    }
    /* Note Aufgabe
        https://www.codewars.com/kata/523f5d21c841566fde000009/train/csharp
        Your goal in this kata is to implement a difference function, which subtracts one list from another and returns the result.
     
        It should remove all values from list a, which are present in list b.
        Kata.ArrayDiff(new int[] {1, 2}, new int[] {1}) => new int[] {2}

        If a value is present in b, all of its occurrences must be removed from the other:
        Kata.ArrayDiff(new int[] {1, 2, 2, 2, 3}, new int[] {2}) => new int[] {1, 3}
        
        // A: 1, 2     B: 1    => 2
        // A: 1, 2, 2  B: 1    => 2, 2
        // A: 1, 2, 2  B: 2    => 1
        // A: 1, 2, 2  B:      => 1, 2, 2
        // A:          B: 1, 2 => 
     */
    public class Kata
    {
        public static int[] ArrayDiff(int[] a, int[] b)
        {
            //Übergabe der Arrays als Liste
            return ExtractDiff(a.ToList(), b.ToList());
        }

        public static int[] ExtractDiff(List<int> a, List<int> b)
        {
            //NiceToKnow: .ToList() wird hier genutzt, um eine Temporäre Kopie
            //anzulegen, damit hier die Liste zur Laufzeit angepasst werden kann
            foreach (var zahlB in b.ToList())
            {
                //Wenn Liste A mindestens einmal den aktuellen Wert
                //aus Liste B enthält, werden alle Treffer gesucht und gelöscht
                if (a.Contains(zahlB))
                {
                    foreach (var zahlA in a.ToList())
                    {
                        if (zahlB == zahlA)
                        {
                            //ToDo RemoveAll testen
                            a.Remove(zahlA);
                        }
                    }
                }
            }
            //Zurück ins Ursprungsformat
            return a.ToArray();
        }
    }
}
