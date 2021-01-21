using System;
using System.Collections.Generic;
namespace NotePad___
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Note> myNotes = new List<Note>();

            Console.WriteLine("======NOTEPAD======");

            Note newNote = new Note("Skata", "Simera xestika poli!");
            
            Note newNote1 = new Note("kaka", "Simera afodefsa poli <3");

            myNotes.Add(newNote);
            myNotes.Add(newNote1);

            ///////
            ///
            
            for (int i = 0; i < myNotes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {myNotes[i].MyTitle}");
            }

            Console.WriteLine("Pleas enter index of note to print");

            while (true) 
            {
                int index = 0;

                if (int.TryParse(Console.ReadLine(), out index) && index - 1 < myNotes.Count)
                {
                    Console.WriteLine($" its a number");

                    Console.WriteLine($"{myNotes[index - 1].MyTitle}\n{myNotes[index - 1].MyText}");

                    break;
                }

                break;
            }

        }
    }
}
